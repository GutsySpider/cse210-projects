using System;

class Address
{
    private string _streetAdress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAdress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }
    public string DisplayAll()
    {
        return $"Address: {_streetAdress}, {_city}, {_state} {_country}";
    }
}