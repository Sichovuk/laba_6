using System;
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

                // Використання інтерфейсу як типу
                ISolid pyramid = new Pyramid(basis, height);
                ISolid sphere = new Sphere(radius);

                double pyramidVolume = pyramid.GetVolume();
                double sphereVolume = sphere.GetVolume();

                tbVPyr.Text = pyramidVolume.ToString("F2");
                tbVSph.Text = sphereVolume.ToString("F2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Будь ласка, введіть коректні числові значення.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
