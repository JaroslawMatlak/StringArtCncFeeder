namespace StringArtConsole
{
    internal class RoundCanvas
    {
        public readonly List<Nail> Nails = new List<Nail>();

        public void AddNail(double x, double y) {
            AddNail(new Nail(x, y));
        }
        public void AddNail(Nail nail)
        {
            Nails.Add(nail);
        }
    }
}
