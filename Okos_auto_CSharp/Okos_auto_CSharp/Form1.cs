using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Okos_auto_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string terkepFIleName = "terkep.txt";
        private const string szenzorFileName = "szenzor.txt";

        private AutoUt autoUt;
        private int terkepX = 0;
        private int terkepY = 0;
        private TextBox[,] idoPillanatban;
        private ComboBox idopillanatok = new ComboBox();

        private void Form1_Load(object sender, EventArgs e)
        {
            idoPillanatokInicializalas();
            try
            {
                autoUt = autoUtGeneralas();
                idoPillanatban = new TextBox[terkepX, terkepY];

                //Programból létrehozott elemek ablakhoz adása
                ablakhozAdas();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Valamely file nem található.", "Olvasási hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.Message,"Adathiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ismeretlen hiba történt a futás során", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void idoPillanatokInicializalas()
        {
            idopillanatok.SelectedIndexChanged += new System.EventHandler(idoPillanatValtas);
        }
        private void ablakhozAdas()
        {
            idoPillanatban.Cast<TextBox>().ToList().ForEach(x => this.Controls.Add(x));
            this.Controls.Add(idopillanatok);

        }
        private void idoPillanatValtas(object sender, System.EventArgs e)
        {

        }
        private AutoUt autoUtGeneralas()
        {
            Terkep terkep = Terkep.terkepEloallitasFilebol(terkepFIleName);
            this.terkepX = terkep.tablazat.GetLength(0);
            this.terkepY = terkep.tablazat.GetLength(1);
            List<Szenzor> szenzorAdatok = Szenzor.szenzorAdatokEloallitasFilebol(szenzorFileName);
            return new AutoUt(terkep, szenzorAdatok);
        }
    }
}
