namespace DGSCONTROLS.MasterClasses.PersonDetails
{
    public interface  IAddress 
    {
        string Number { get; set; }
        string StreetName1 { get; set; }
        string StreetName2 { get; set; }
        string Area { get; set; }
        string City { get; set; }
        string Taluk { get; set; }
        string District { get; set; }
        string State { get; set; }
        string Country { get; set; }
        string Pincode { get; set; }
    }
}
