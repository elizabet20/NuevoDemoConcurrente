namespace DemoConcurrencia
{
    public partial class frmConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public frmConcurrencia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ACtualizarResultado("Iniciando proceso secuencial");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2000);
                ACtualizarResultado($"Actividad - paso {i + 1}");
            }
            Thread.Sleep(5000);
            ACtualizarResultado("Fin del proceso secuencial");
        }

        private void ACtualizarResultado(string mensaje)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ACtualizarResultado(mensaje)));
                return;
            }
            txtResultado.AppendText($" {DateTime.Now:HH:mm:ss.fff}:{mensaje}{Environment.NewLine}");
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarHilo_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread Hilo1 = new Thread(() =>
            {
                try
                {
                    ACtualizarResultado($"Iniciar nuevo Thred {Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ACtualizarResultado($"Actividad en hilo:{Thread.CurrentThread.ManagedThreadId} - paso {i + 1}");
                    }
                    ACtualizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId}terminado.");

                }
                catch (OperationCanceledException)
                {

                    ACtualizarResultado(" Hilo Cancelado");
                }
            });
            Hilo1.Start();
        }


        private async void btnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
            {
                try
                {
                    ACtualizarResultado($"Iniciando Task{Task.CurrentId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ACtualizarResultado($"Actividad en tarea {Task.CurrentId} - paso{i + 1}");
                    }
                    ACtualizarResultado($"Task {Task.CurrentId} completada");
                }
                catch (Exception)
                {
                    ACtualizarResultado("Tarea cancelada");
                }
            });
        }

        private void btnCancelarHilo_Click(object sender, EventArgs e)
        {
            _cts?.Cancel();
        }
    }
}
