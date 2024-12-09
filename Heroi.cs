namespace bootcamp_18_ClassesDeUmJogo
{
    internal class Heroi
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Tipo { get; set; }

        public void Atacar()
        {
            string ataque = "";

            switch (Tipo)
            {
                case "guerreiro":
                    ataque = "espada";
                    break;

                case "mago":
                    ataque = "magia";
                    break;

                case "monge":
                    ataque = "artes marciais";
                    break;

                case "ninja":
                    ataque = "shuriken";
                    break;
            }

            Console.WriteLine($"o {Tipo} atacou usando {ataque}");
        }
    }
}
