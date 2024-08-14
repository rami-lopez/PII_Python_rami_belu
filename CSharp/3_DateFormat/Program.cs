string testDate = "10/11/1977";
Console.WriteLine(string.Format("{0} se convierte a: {1}", testDate, Functions.DateFormat(testDate)));

public static class Functions
{
    public static string DateFormat(string testDate)
    {
        string nuevaPalabra = "";
        nuevaPalabra = testDate.Substring(6, 4);
        nuevaPalabra += "-";
        nuevaPalabra += testDate.Substring(3, 2);
        nuevaPalabra += "-";
        nuevaPalabra += testDate.Substring(0, 2);
        return nuevaPalabra;
    }
}

