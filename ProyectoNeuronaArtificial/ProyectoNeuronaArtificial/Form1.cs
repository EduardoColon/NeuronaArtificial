using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoNeuronaArtificial
{
    public partial class Form1 : Form
    {
        int filaAjustar;
        List<List<double>> tabla = new List<List<double>>();
        List<double> pesos = new List<double>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvPesos.Rows.Add("W" + (dgvPesos.Rows.Count + 1), txtPeso.Value);
            txtPeso.Value = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bAjustar.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numVariables = dgvPesos.Rows.Count + 1;
            llenarMatriz(numVariables - 1);
        }

        private void llenarMatriz(int numVariables)
        {
            bAgregar.Enabled = false;
            bAjustar.Enabled = false;

            List<double> fila = new List<double>();
            List<double> resultados = new List<double>();

            bool insertandoPositivo = true;
            bool necesarioAjuste = false;
            bool ingresoLetra = false;

            int contadorInsertados = 0;
            double filas = Math.Pow(2, numVariables);
            double intervalo = filas / 2;

            dgvMatriz.Rows.Clear();
            tabla.Clear();
            pesos.Clear();
            resultados.Clear();
            dgvMatriz.ColumnCount = numVariables + 2;

            foreach (DataGridViewRow row in dgvPesos.Rows)
            {
                try
                {
                    pesos.Add(double.Parse(row.Cells[1].Value.ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Solo se aceptan numeros");
                    ingresoLetra = !ingresoLetra;
                }
            }

            if (!ingresoLetra)
            {
                pesos.Add(double.Parse(txtUmbral.Value.ToString()));

                for (int i = 0; i < numVariables; i++)
                {
                    insertandoPositivo = true;

                    for (int j = 0; j < filas; j++)
                    {
                        contadorInsertados++;

                        if (insertandoPositivo)
                            fila.Add(1);
                        else if (!insertandoPositivo)
                            fila.Add(-1);

                        if (contadorInsertados == intervalo)
                        {
                            insertandoPositivo = !insertandoPositivo;

                            contadorInsertados = 0;
                        }
                    }

                    intervalo = intervalo / 2;
                    tabla.Add(new List<double>(fila));
                    fila.Clear();
                }

                for (int i = 0; i < filas; i++)
                {
                    fila.Add(-1);
                }
                tabla.Add(new List<double>(fila));
                fila.Clear();

                for (int i = 0; i < filas; i++)
                {
                    bool existePositivo = false;
                    for (int j = 0; j < numVariables; j++)
                    {
                        if (tabla[j][i] == 1)
                            existePositivo = true;
                    }

                    if (existePositivo)
                        fila.Add(1);
                    else
                        fila.Add(-1);
                }
                tabla.Add(new List<double>(fila));
                fila.Clear();

                for (int i = 0; i < filas; i++)
                {
                    double sumatoria = 0.00;

                    for (int j = 0; j < numVariables + 1; j++)
                    {
                        sumatoria = tabla[j][i] * pesos[j] + sumatoria;
                    }
                    resultados.Add(sumatoria);
                }

                for (int i = 0; i < filas; i++)
                {
                    DataGridViewRow row = (DataGridViewRow)dgvMatriz.Rows[0].Clone();

                    for (int j = 0; j < numVariables + 1; j++)
                    {
                        if (tabla[j][i] == 1)
                            row.Cells[j].Value = "+" + tabla[j][i] + "(" + pesos[j] + ")";
                        else
                            row.Cells[j].Value = tabla[j][i] + "(" + pesos[j] + ")";
                    }

                    if (resultados[i] >= double.Parse(txtUmbral.Value.ToString()))
                    {
                        if (tabla[numVariables + 1][i] == 1)
                        {
                            row.Cells[numVariables + 1].Value = "= " + resultados[i];
                            dgvMatriz.Rows.Add(row);
                        }
                        else
                        {
                            if (!necesarioAjuste)
                            {
                                necesarioAjuste = true;
                                bAjustar.Enabled = true;
                                filaAjustar = i;
                            }


                            row.Cells[numVariables + 1].Value = "= " + resultados[i] + " *";
                            row.Cells[numVariables + 1].Style.BackColor = Color.Red;
                            row.Cells[numVariables + 1].Style.ForeColor = Color.White;
                            dgvMatriz.Rows.Add(row);
                        }
                    }
                    else
                    {
                        if (tabla[numVariables + 1][i] == -1)
                        {
                            row.Cells[numVariables + 1].Value = "= " + resultados[i];
                            dgvMatriz.Rows.Add(row);
                        }
                        else
                        {
                            if (!necesarioAjuste)
                            {
                                necesarioAjuste = true;
                                bAjustar.Enabled = true;
                                filaAjustar = i;
                            }

                            row.Cells[numVariables + 1].Value = "= " + resultados[i] + " *";
                            row.Cells[numVariables + 1].Style.BackColor = Color.Red;
                            row.Cells[numVariables + 1].Style.ForeColor = Color.White;
                            dgvMatriz.Rows.Add(row);
                        }
                    }

                }

                if (!necesarioAjuste)
                {
                    dgvMatriz.BackgroundColor = Color.Green;
                    dgvMatriz.ForeColor = Color.White;

                    foreach (DataGridViewRow row in dgvMatriz.Rows)
                    {
                        foreach (DataGridViewColumn col in dgvMatriz.Columns)
                        {
                            row.Cells[col.Index].Style.BackColor = Color.Green;
                            row.Cells[col.Index].Style.ForeColor = Color.White;
                        }
                    }

                    dgvPesos.BackgroundColor = Color.Green;
                    dgvPesos.ForeColor = Color.White;

                    foreach (DataGridViewRow row in dgvPesos.Rows)
                    {
                        foreach (DataGridViewColumn col in dgvPesos.Columns)
                        {
                            row.Cells[col.Index].Style.BackColor = Color.Green;
                            row.Cells[col.Index].Style.ForeColor = Color.White;
                        }
                    }

                    txtFactorAjuste.BackColor = Color.Green;
                    txtFactorAjuste.ForeColor = Color.White;
                    txtFactorAjuste.Font = new Font(txtFactorAjuste.Font, FontStyle.Bold);

                    txtUmbral.BackColor = Color.Green;
                    txtUmbral.ForeColor = Color.White;
                    txtUmbral.Font = new Font(txtFactorAjuste.Font, FontStyle.Bold);


                    MessageBox.Show("Solucion encontrada");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvPesos.Rows.Clear();
            dgvMatriz.Rows.Clear();
            txtPeso.Value = 0;
            txtUmbral.Value = 0;
            txtFactorAjuste.Value = 0;
            bAgregar.Enabled = true;
            pesos.Clear();
            tabla.Clear();

            dgvMatriz.BackgroundColor = Color.White;
            dgvMatriz.ForeColor = Color.Black;

            foreach (DataGridViewRow row in dgvMatriz.Rows)
            {
                foreach (DataGridViewColumn col in dgvMatriz.Columns)
                {
                    row.Cells[col.Index].Style.BackColor = Color.White;
                    row.Cells[col.Index].Style.ForeColor = Color.Black;
                }
            }


            dgvPesos.BackgroundColor = Color.White;
            dgvPesos.ForeColor = Color.Black;

            foreach (DataGridViewRow row in dgvPesos.Rows)
            {
                foreach (DataGridViewColumn col in dgvPesos.Columns)
                {
                    row.Cells[col.Index].Style.BackColor = Color.White;
                    row.Cells[col.Index].Style.ForeColor = Color.Black;
                }
            }

            txtFactorAjuste.BackColor = Color.White;
            txtFactorAjuste.ForeColor = Color.Black;
            txtFactorAjuste.Font = new Font(txtFactorAjuste.Font, FontStyle.Regular);

            txtUmbral.BackColor = Color.White;
            txtUmbral.ForeColor = Color.Black;
            txtFactorAjuste.Font = new Font(txtFactorAjuste.Font, FontStyle.Regular);

        }

        private void bAjustar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesos y umbral ajustados correctamente");

            List<double> nuevosValores = new List<double>();
            for (int i = 0; i < pesos.Count; i++)
            {
                double nuevoValor = pesos[i] + (2 * double.Parse(txtFactorAjuste.Value.ToString()) * tabla[pesos.Count][filaAjustar] * tabla[i][filaAjustar]);
                nuevosValores.Add(nuevoValor);
            }

            dgvPesos.Rows.Clear();
            for (int i = 0; i < nuevosValores.Count - 1; i++)
            {
                dgvPesos.Rows.Add("W" + (dgvPesos.Rows.Count + 1), nuevosValores[i]);
            }

            txtUmbral.Value = decimal.Parse(nuevosValores[nuevosValores.Count - 1].ToString());

            bAjustar.Enabled = false;
            bCalcular.Enabled = true;
        }

        private void dgvPesos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}