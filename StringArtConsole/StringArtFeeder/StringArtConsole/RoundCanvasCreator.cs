namespace StringArtConsole
{
    internal static class RoundCanvasCreator
    {
        public static RoundCanvas CreateCanvas(int nailsNumber = 100)
        {
            var canvas = new RoundCanvas();
            for (var i = 0; i < nailsNumber; ++i)
            {
                double angle = 2*Math.PI * i / nailsNumber;
                double x = 500 + 500 * Math.Sin(angle);
                double y = 500 + 500 * Math.Cos(angle);

                canvas.AddNail(x, y);
            }
            return canvas;
        }
    }
}
