using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntColonyAlgorithmApp
{
    public partial class MainScreen : Form
    {
 
        int center = 10 / 2;
        int circleSize = 10;
        int witdh = 800;
        int height = 600;

        public static System.Windows.Forms.SplitContainer container1;
        public MainScreen()
        {
           
            InitializeComponent();

            this.Width = this.splitContainer1.Panel1.Width+ witdh + World.margin * 4;
            this.Height = this.splitContainer2.Panel2.Height+ height + World.margin * 4;
            MainScreen.container1 = this.splitContainer1;
            World.generatorChoice = World.RandomNumberGenerators.Beta;
            
        }

        private void MainScreen_Paint(object sender, PaintEventArgs e)
        {
            /*if (newWorld == null)
                return;
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Brush b = new SolidBrush(Color.Blue))
                {
                    using (Pen p = new Pen(Color.Black))
                    {
                        foreach (Neighbor item2 in this.newWorld.neighbors)
                        {
                            g.DrawLine(p, item2.points[0].location.X + center, item2.points[0].location.Y + center, item2.points[1].location.X + center, item2.points[1].location.Y + center);

                        }
                        foreach (LPoint item in this.newWorld.locations)
                        {
                            g.FillEllipse(b, item.location.X, item.location.Y, circleSize, circleSize);
                            g.DrawEllipse(p, item.location.X, item.location.Y, circleSize, circleSize);

                        }

                        g.FillEllipse(new SolidBrush(Color.Red), newWorld.colony.home.location.X, newWorld.colony.home.location.Y, circleSize, circleSize);
                        g.DrawEllipse(p, newWorld.colony.home.location.X, newWorld.colony.home.location.Y, circleSize, circleSize);
                    }

                }
            }*/

        }

     
        
        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {
           /* if (World.isSet == false)
                return;
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Brush b = new SolidBrush(Color.Blue))
                {
                    using (Pen p = new Pen(Color.Black))
                    {
                        
                        foreach (Neighbor item2 in World.neighbors)
                        {
                            if (item2.isEliminated)
                            {
                                continue;
                            }
                            int c = 255 - (int)item2.pheromoneValue;
                            if (c < 0)
                                c = 0;
                            Pen p1 = new Pen(Color.FromArgb(c, c, c));
                            g.DrawLine(p1, item2.points[0].location.X + center, item2.points[0].location.Y + center, item2.points[1].location.X + center, item2.points[1].location.Y + center);
                            
                        }
                        foreach (LPoint item in World.locations)
                        {
                            g.FillEllipse(b, item.location.X, item.location.Y, circleSize, circleSize);
                            g.DrawEllipse(p, item.location.X, item.location.Y, circleSize, circleSize);

                        }
                       /* Brush b1 = new SolidBrush(Color.Orange);
                        foreach (Ant item in Colony.ants)
                        {
                            g.FillRectangle(b1, item.visitedPoints[item.visitedPoints.Count-1].location.X, item.visitedPoints[item.visitedPoints.Count - 1].location.Y, 5, 5);
                           

                        }


                        g.FillEllipse(new SolidBrush(Color.Red), Colony.home.location.X, Colony.home.location.Y, circleSize, circleSize);
                        g.DrawEllipse(p, Colony.home.location.X, Colony.home.location.Y, circleSize, circleSize);
                    }

                }
            }*/

        }

        private void btn_set_Click(object sender, EventArgs e)
        {
         
            World.setWorld(witdh, height);
            center = circleSize / 2;
            World.CreateRandomWorld((int)nupd_pointCount.Value);
            World.CreateAColony((int)nupd_antCount.Value);

            txt_stepCount.Text = "0";
            btn_step.Enabled = true;
            btn_runAll.Enabled = true;
            nupd_stepSize.Enabled = true;
            nupd_runCount.Enabled = true;
            this.splitContainer2.Panel1.Refresh();

        }

        private void btn_step_Click(object sender, EventArgs e)
        {
            int stepSize = (int)nupd_stepSize.Value;
            World.RunWord(stepSize);
            txt_stepCount.Text = World.runTimes.ToString();
           


            this.splitContainer2.Panel1.Refresh();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {

            World.ResetWorld();
            Colony.ResetColony((int)nupd_antCount.Value);
            txt_stepCount.Text = World.runTimes.ToString();
            this.splitContainer2.Panel1.Refresh();

        }

        private void Beta_CheckedChanged(object sender, EventArgs e)
        {
            World.generatorChoice = World.RandomNumberGenerators.Beta;
        }

        private void rdio_uniform_CheckedChanged(object sender, EventArgs e)
        {
            World.generatorChoice = World.RandomNumberGenerators.Uniform;
        }

        private void rdio_binominal_CheckedChanged(object sender, EventArgs e)
        {
            World.generatorChoice = World.RandomNumberGenerators.Exponential;
        }

        private void rdio_gamma_CheckedChanged(object sender, EventArgs e)
        {
            World.generatorChoice = World.RandomNumberGenerators.Gamma;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (World.isSet == false)
                return;
            using (Graphics g = e.Graphics)
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Brush b = new SolidBrush(Color.Blue))
                {
                    using (Pen p = new Pen(Color.Black))
                    {

                        foreach (Neighbor item2 in World.neighbors)
                        {
                            if (item2.isEliminated)
                            {
                                continue;
                            }
                            int c = 255 - (int)item2.pheromoneValue;
                            if (c < 0)
                                c = 0;
                            Pen p1 = new Pen(Color.FromArgb(c, c, c));
                            g.DrawLine(p1, item2.points[0].location.X + center, item2.points[0].location.Y + center, item2.points[1].location.X + center, item2.points[1].location.Y + center);

                        }
                        foreach (LPoint item in World.locations)
                        {
                            g.FillEllipse(b, item.location.X, item.location.Y, circleSize, circleSize);
                            g.DrawEllipse(p, item.location.X, item.location.Y, circleSize, circleSize);

                        }
                        /* Brush b1 = new SolidBrush(Color.Orange);
                         foreach (Ant item in Colony.ants)
                         {
                             g.FillRectangle(b1, item.visitedPoints[item.visitedPoints.Count-1].location.X, item.visitedPoints[item.visitedPoints.Count - 1].location.Y, 5, 5);


                         }*/


                        g.FillEllipse(new SolidBrush(Color.Red), Colony.home.location.X, Colony.home.location.Y, circleSize, circleSize);
                        g.DrawEllipse(p, Colony.home.location.X, Colony.home.location.Y, circleSize, circleSize);
                    }

                }
            }
        }

        private void btn_runAll_Click(object sender, EventArgs e)
        {
            nupd_stepSize.Enabled = false;
            btn_step.Enabled = false;
            int stepSize = (int)nupd_stepSize.Value;

            World.generatorChoice = World.RandomNumberGenerators.Beta;
            for (int i = 0; i < nupd_runCount.Value; i++)
            {
               
                World.RunWord(stepSize);

                lstb_betaResult.Items.Add((i+1)+". Try | Best:"+World.theBest.pathLenght);
                World.ResetWorld();
                Colony.ResetColony((int)nupd_antCount.Value);
               
            }

            World.generatorChoice = World.RandomNumberGenerators.Exponential;
            for (int i = 0; i < nupd_runCount.Value; i++)
            {
                World.RunWord(stepSize);
                lstb_expoResult.Items.Add((i + 1) + ". Try | Best:" + World.theBest.pathLenght);
                World.ResetWorld();
                Colony.ResetColony((int)nupd_antCount.Value);
            }

            World.generatorChoice = World.RandomNumberGenerators.Gamma;
            for (int i = 0; i < nupd_runCount.Value; i++)
            {
                World.RunWord(stepSize);
                lstb_gammaResult.Items.Add((i + 1) + ". Try | Best:" + World.theBest.pathLenght);
                World.ResetWorld();
                Colony.ResetColony((int)nupd_antCount.Value);
            }


            World.generatorChoice = World.RandomNumberGenerators.Uniform;
            for (int i = 0; i < nupd_runCount.Value; i++)
            {
                World.RunWord(stepSize);
                lstb_uniformResult.Items.Add((i + 1) + ". Try | Best:" + World.theBest.pathLenght);
                World.ResetWorld();
                Colony.ResetColony((int)nupd_antCount.Value);
            }


            nupd_stepSize.Enabled = true;
            btn_step.Enabled = true;

        }

        private void lstb_betaResult_KeyDown(object sender, KeyEventArgs e)
        {
       
                if (e.Control && (e.KeyCode == Keys.C))
                {
                String total ="";
                foreach (String item in lstb_betaResult.SelectedItems)
                {
                    total += item + "\n";
                }
                Clipboard.SetText(total);
                }
            
        }





        /*public void Draw()
        {
            Graphics g= 
        }*/

    }
}
