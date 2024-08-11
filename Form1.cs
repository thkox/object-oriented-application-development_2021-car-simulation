using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace P20094_FirstProject
{
    public partial class GamePanel : Form
    {
        // List of images for the traffic lights.
        private List<Image> imagesTrafficLights = new List<Image>();
        // List of car PictureBoxes for horizontal and vertical movement.
        private List<PictureBox> pictureBoxesCarsHorizontal = new List<PictureBox>();
        private List<PictureBox> pictureBoxesCarsVertical = new List<PictureBox>();

        public GamePanel()
        {
            InitializeComponent();
        }

        private void GamePanel_Load(object sender, EventArgs e)
        {
            // Load traffic light images from the "images" folder.
            imagesTrafficLights.Add(Image.FromFile(Application.StartupPath + "/images/trafficLight_green.png"));
            imagesTrafficLights.Add(Image.FromFile(Application.StartupPath + "/images/trafficLight_orange.png"));
            imagesTrafficLights.Add(Image.FromFile(Application.StartupPath + "/images/trafficLight_red.png"));

            trafficLightLeft.Image = imagesTrafficLights[0];
            trafficLightRight.Image = imagesTrafficLights[2];

            // Add horizontal cars to the PictureBox list.
            pictureBoxesCarsHorizontal.Add(carYellowish);
            pictureBoxesCarsHorizontal.Add(carPurple);
            pictureBoxesCarsHorizontal.Add(carBlue);

            // Add vertical cars to the PictureBox list.
            pictureBoxesCarsVertical.Add(carGreen);
            pictureBoxesCarsVertical.Add(carOrange);
            pictureBoxesCarsVertical.Add(carRed);
        }

        private void startTheGame_Click(object sender, EventArgs e)
        {
            if (startTheGame.Text == "Start The Game")
            {
                trafficLight.Start();
                carSpeed.Start();
                startTheGame.Text = "Stop";
            }
            else
            {
                trafficLight.Stop();
                carSpeed.Stop();
                startTheGame.Text = "Start The Game";
            }
        }

        private void changeState_Click(object sender, EventArgs e)
        {
            trafficLight.Stop();
            carSpeed.Stop();
            trafficLightLeft.Image = imagesTrafficLights[0];
            trafficLightRight.Image = imagesTrafficLights[2];
            changeLightCounter = 0;

            startTheGame.Text = "Start The Game";
            if (changeState.Text == "What if... a car crosses the road when the light is red?")
            {
                carYellowish.Left = 309;
                carPurple.Left = 201;
                carBlue.Left = 1149;

                carGreen.Top = 472;
                carOrange.Top = 564;
                carRed.Top = 656;

                changeState.Text = "Ok, but what if... TWO cars cross the road when their corresponding lights are red?";
            }
            else if (changeState.Text == "Ok, but what if... TWO cars cross the road when their corresponding lights are red?")
            {
                carYellowish.Left = 309;
                carPurple.Left = 201;
                carBlue.Left = 1149;

                carGreen.Top = 472;
                carOrange.Top = 564;
                carRed.Top = 200;

                changeState.Text = "Ok, it's working. Let's put everything back in their place!";
            }
            else if (changeState.Text == "Ok, it's working. Let's put everything back in their place!")
            {
                carYellowish.Left = 309;
                carPurple.Left = 201;
                carBlue.Left = 98;

                carGreen.Top = 472;
                carOrange.Top = 564;
                carRed.Top = 656;

                changeState.Text = "What if... a car crosses the road when the light is red?";
            }
        }

        // Counter for the traffic light state.
        private int changeLightCounter = 0;

        private void trafficLight_Tick(object sender, EventArgs e)
        {
            // Cycle through the traffic light states.
            switch (changeLightCounter)
            {
                case 4:
                    trafficLightLeft.Image = imagesTrafficLights[1]; // Orange
                    changeLightCounter++;
                    break;
                case 6:
                    trafficLightLeft.Image = imagesTrafficLights[2]; // Red
                    trafficLightRight.Image = imagesTrafficLights[0]; // Green
                    changeLightCounter++;
                    break;
                case 10:
                    trafficLightRight.Image = imagesTrafficLights[1]; // Orange
                    changeLightCounter++;
                    break;
                case 12:
                    trafficLightLeft.Image = imagesTrafficLights[0]; // Green
                    trafficLightRight.Image = imagesTrafficLights[2]; // Red
                    changeLightCounter = 0;
                    break;
                default:
                    changeLightCounter++;
                    break;
            }
        }

        // Speed and respawn settings for horizontal cars.
        private int counterSpeedHorizontal = 2;
        private int respawnHorizontal = 2;

        // Speed and respawn settings for vertical cars.
        private int counterSpeedVertical = 2;
        private int respawnVertical = 2;

        private void carSpeed_Tick(object sender, EventArgs e)
        {
            // Update horizontal cars' positions.
            foreach (PictureBox carHorizontal1 in pictureBoxesCarsHorizontal)
            {
                foreach (PictureBox carHorizontal2 in pictureBoxesCarsHorizontal)
                {
                    if (!carHorizontal1.Bounds.IntersectsWith(carHorizontal2.Bounds) && carHorizontal1.Name != carHorizontal2.Name &&
                        (trafficLightLeft.Image == imagesTrafficLights[0] || carHorizontal1.Bounds.IntersectsWith(roadRight.Bounds)))
                    {
                        counterSpeedHorizontal = 2;
                        carHorizontal1.Left += counterSpeedHorizontal;

                        // Respawn car if it goes out of bounds.
                        if (carHorizontal1.Left > 1325 && respawnHorizontal <= 2 && respawnHorizontal != 0)
                        {
                            carHorizontal1.Left = -160 * (respawnHorizontal + 1);
                            respawnHorizontal--;
                        }
                        else
                        {
                            respawnHorizontal = 2;
                        }
                    }
                    else
                    {
                        counterSpeedHorizontal = 0;
                    }

                    // When the red light is on, cars should be near the red traffic light.
                    if (!carHorizontal1.Bounds.IntersectsWith(carHorizontal2.Bounds) && carHorizontal1.Name != carHorizontal2.Name &&
                        (trafficLightLeft.Image == imagesTrafficLights[2] || trafficLightLeft.Image == imagesTrafficLights[1]))
                    {
                        counterSpeedHorizontal = 1;

                        if (carHorizontal1.Left < 309 && carHorizontal1 == pictureBoxesCarsHorizontal[0])
                        {
                            carHorizontal1.Left += counterSpeedHorizontal;
                        }
                        if (carHorizontal1.Left < 201 && carHorizontal1 == pictureBoxesCarsHorizontal[1])
                        {
                            carHorizontal1.Left += counterSpeedHorizontal;
                        }
                        if (carHorizontal1.Left < 98 && carHorizontal1 == pictureBoxesCarsHorizontal[2])
                        {
                            carHorizontal1.Left += counterSpeedHorizontal;
                        }
                    }
                    else
                    {
                        counterSpeedHorizontal = 0;
                    }
                }
            }

            // Update vertical cars' positions.
            foreach (PictureBox carVertical1 in pictureBoxesCarsVertical)
            {
                foreach (PictureBox carVertical2 in pictureBoxesCarsVertical)
                {
                    if (!carVertical1.Bounds.IntersectsWith(carVertical2.Bounds) && carVertical1.Name != carVertical2.Name &&
                        (trafficLightRight.Image == imagesTrafficLights[0] || carVertical1.Bounds.IntersectsWith(roadUp.Bounds)))
                    {
                        counterSpeedVertical = 2;
                        carVertical1.Top -= counterSpeedVertical;

                        // Respawn car if it goes out of bounds.
                        if (carVertical1.Top < -200 && respawnVertical <= 2 && respawnVertical != 0)
                        {
                            carVertical1.Top = 738 + (100 * (respawnVertical + 1));
                            respawnVertical--;
                        }
                        else
                        {
                            respawnVertical = 2;
                        }
                    }
                    else
                    {
                        counterSpeedVertical = 0;
                    }

                    // When the red light is on, cars should be near the red traffic light.
                    if (!carVertical1.Bounds.IntersectsWith(carVertical2.Bounds) && carVertical1.Name != carVertical2.Name &&
                        (trafficLightRight.Image == imagesTrafficLights[2] || trafficLightRight.Image == imagesTrafficLights[1]))
                    {
                        counterSpeedVertical = 1;

                        if (carVertical1.Top > 472 && carVertical1 == pictureBoxesCarsVertical[0])
                        {
                            carVertical1.Top -= counterSpeedVertical;
                        }
                        if (carVertical1.Top > 564 && carVertical1 == pictureBoxesCarsVertical[1])
                        {
                            carVertical1.Top -= counterSpeedVertical;
                        }
                        if (carVertical1.Top > 656 && carVertical1 == pictureBoxesCarsVertical[2])
                        {
                            carVertical1.Top -= counterSpeedVertical;
                        }
                    }
                    else
                    {
                        counterSpeedVertical = 0;
                    }
                }
            }
        }

        private void minimizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }
    }
}
