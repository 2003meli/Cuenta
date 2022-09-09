class Banco
    {
        //INICIO DE CLASE BANCO
        public static void Main(string[] args)
        {
            Banco banco1 = new Banco();
            banco1.Operar();
            banco1.DepositosTotales();
            Console.ReadKey();
        }

        public Cliente cliente1, cliente2, cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Sergio");
            cliente2 = new Cliente("Andrés");
            cliente3 = new Cliente("Melissa");
        }

        public void Operar()
        {
            cliente1.Depositar(100);
            cliente2.Depositar(150);
            cliente3.Depositar(200);
            cliente3.Retirar(150);
        }

        public void DepositosTotales()
        {
            int t = cliente1.RetornarMonto() +
                    cliente2.RetornarMonto() +
                    cliente3.RetornarMonto();
            Console.WriteLine("El total de dinero en el banco es:" + t);
            cliente1.Imprimir();
            cliente2.Imprimir();
            cliente3.Imprimir();
        }
    }