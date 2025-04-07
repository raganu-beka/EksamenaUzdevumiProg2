class CssdCar
{
    public string Zimols { get; set; }
    public string Modelis { get; set; }
    public string RegistracijasDatums { get; set; }
    public int PilnaMasa { get; set; }
    public string DegvielasVeids { get; set; }

    public CssdCar(string mark, string model, string registrationtime, int height, string fuel)
    {
        this.Zimols = mark;
        this.Modelis = model;
        this.RegistracijasDatums = registrationtime;
        this.PilnaMasa = height;
        this.DegvielasVeids = fuel;
    }

    public void PritVehicles()
    {
        Console.WriteLine($"Mark{Zimols} Model{Modelis} Registrationtime{RegistracijasDatums} height{PilnaMasa} fuel{DegvielasVeids}");
    }
}
