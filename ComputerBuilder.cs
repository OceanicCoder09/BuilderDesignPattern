namespace BuilderDesignPattern
{
    public class ComputerBuilder
    {
        private Computer c = new Computer();

        public ComputerBuilder SetCPU(string cpu)
        {
            c.CPU = cpu;
            return this;
        }

        public ComputerBuilder SetRAM(string ram)
        {
            c.RAM = ram;
            return this;
        }

        public ComputerBuilder SetStorage(string storage)
        {
            c.Storage = storage;
            return this;
        }

        public ComputerBuilder SetGPU(string gpu)
        {
            c.GPU = gpu;
            return this;
        }

        public Computer Build()
        {
            return c;
        }
    }
}
