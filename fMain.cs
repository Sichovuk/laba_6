using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba_6
{
    public partial class fMain : Form
    {
        // Інтерфейс замість абстрактного класу
        public interface ISolid
        {
            double GetVolume();
        }

        // Клас піраміди реалізує інтерфейс ISolid
        public class Pyramid : ISolid
        {
            public double A { get; set; }
            public double H { get; set; }

            public Pyramid(double a, double h)
            {
                A = a;
                H = h;
            }

            public double GetVolume()
            {
                return (1.0 / 3.0) * A * A * H;
            }
        }

        // Клас сфери реалізує інтерфейс ISolid
        public class Sphere : ISolid
        {
            public double R { get; set; }

            public Sphere(double r)
            {
                R = r;
            }

            public double GetVolume()
            {
                return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
            }
        }

        public fMain()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            try
            {
                double basis = Convert.ToDouble(tbBasis.Text);
                double height = Convert.ToDouble(tbHeight.Text);
                double radius = Convert.ToDouble(tbRadius.Text);

                // Список геометричних тіл (поліморфізм)
                List<ISolid> solids = new List<ISolid>
                {
                    new Pyramid(basis, height),
                    new Sphere(radius)
                };

                foreach (ISolid solid in solids)
                {
                    if (solid is Pyramid)
                        tbVPyr.Text = solid.GetVolume().ToString("F2");
                    else if (solid is Sphere)
                        tbVSph.Text = solid.GetVolume().ToString("F2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
