using System;
using System.Collections.Generic;

namespace CountryInfo
{
    public class CountryResponse
    {
        public List<Country>? Data { get; set; }
    }

    public class Country
    {
        public Name? name { get; set; }
        public List<string>? tld { get; set; }
        public string? cca2 { get; set; }
        public string? ccn3 { get; set; }
        public string? cca3 { get; set; }
        public string? cioc { get; set; }
        public bool cndependent { get; set; }
        public string? status { get; set; }
        public bool unMember { get; set; }
        public Dictionary<string, Currency>? currencies { get; set; }
        public Idd? idd { get; set; }
        public List<string>? capital { get; set; }
        public List<string>? altSpellings { get; set; }
        public string? region { get; set; }
        public string? subregion { get; set; }
        public Dictionary<string, string>? languages { get; set; }
        public Dictionary<string, Translation>? translations { get; set; }
        public List<double>? latlng { get; set; }
        public bool landlocked { get; set; }
        public List<string>? borders { get; set; }
        public double area { get; set; }
        public Demonyms? demonyms { get; set; }
        public string? flag { get; set; }
        public Maps? maps { get; set; }
        public int population { get; set; }
        public Dictionary<string, double>? gini { get; set; }
        public string? fifa { get; set; }
        public Car? car { get; set; }
        public List<string>? timezones { get; set; }
        public List<string>? continents { get; set; }
        public Flags? flags { get; set; }
        public CoatOfArms? coatOfArms { get; set; }
        public string? startOfWeek { get; set; }
        public CapitalInfo? capitalInfo { get; set; }
        public PostalCode? postalCode { get; set; }
    }

    public class Name
    {
        public string? common { get; set; }
        public string? official { get; set; }
        public Dictionary<string, NativeName>? nativeName { get; set; }
    }

    public class NativeName
    {
        public string? official { get; set; }
        public string? common { get; set; }
    }

    public class Currency
    {
        public string? name { get; set; }
        public string? symbol { get; set; }
    }

    public class Idd
    {
        public string? root { get; set; }
        public List<string>? suffixes { get; set; }
    }

    public class Translation
    {
        public string? official { get; set; }
        public string? common { get; set; }
    }

    public class Demonyms
    {
        public Gender? demonymEng { get; set; }
        public Gender? demonymFra { get; set; }
    }

    public class Gender
    {
        public string? f { get; set; }
        public string? m { get; set; }
    }

    public class Maps
    {
        public string? googleMaps { get; set; }
        public string? openStreetMaps { get; set; }
    }

    public class Car
    {
        public List<string>? signs { get; set; }
        public string? side { get; set; }
    }

    public class Flags
    {
        public string? png { get; set; }
        public string? svg { get; set; }
        public string? alt { get; set; }
    }

    public class CoatOfArms
    {
        public string? png { get; set; }
        public string? svg { get; set; }
    }

    public class CapitalInfo
    {
        public List<double>? latlng { get; set; }
    }

    public class PostalCode
    {
        public string? format { get; set; }
        public string? regex { get; set; }
    }
}
