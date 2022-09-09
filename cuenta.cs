//CLASE
class Cliente
    {
        public string nombre;
        public int monto;


//CONSTRUCTOR
        public Cliente(string nom)
        {
            nombre = nom;
            monto = 0;
        }


//SET
        public void Depositar(int m)
        {
            this.monto = this.monto + m;
        }

        public void Retirar(int m)
        {
            this.monto = monto - m;
        }


//GET
        public int RetornarMonto()
        {
            return monto;
        }

        public void Imprimir()
        {
            Console.WriteLine(nombre + " tiene depositado la suma de " + monto);
        }
    }