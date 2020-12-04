using System;
using System.Collections.ObjectModel;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCodeDay4
{
    public class VerifyPassports
    {
        public int CalcNbValidPassports(
            string file,
            bool verifyValues)
        {
            var lines = File.ReadAllLines(file);

            var nbValidPassports = 0;
            var passport = string.Empty;
            var mandatoryFields = new Collection<string>
            {
                "byr",
                "iyr",
                "eyr",
                "hgt",
                "hcl",
                "ecl",
                "pid",
//                "cid"
            };

            var nbLine = 0;
            foreach (var line in lines)
            {
                nbLine++;
                if (line != string.Empty)
                {
                    passport += line + ' ';
                    if (nbLine < lines.Count())
                        continue;
                }

                var fields = passport.Split(' ');
                var passportOk = true;
                foreach (var mandatoryField in mandatoryFields)
                {
                    if (!passport.Contains(mandatoryField))
                    {
                        passportOk = false;
                        break;
                    }
                    if (verifyValues)
                    {
                        foreach (var field in fields)
                        {
                            if (!field.StartsWith(mandatoryField))
                                continue;

                            var tab = field.Split(':');

                            if (!VerifyValues(mandatoryField, tab[1]))
                            {
                                passportOk = false;
                                break;
                            }
                        }
                    }
                };

                if (passportOk)
                    nbValidPassports++;

                passport = string.Empty;
            }
            return nbValidPassports;
        }

        private bool VerifyValues(
            string fieldToVerify,
            string fieldValue)
        {
            switch (fieldToVerify)
            {
                case "byr":
                    {
                        var byr = int.Parse(fieldValue);
                        if (byr < 1920 || byr > 2002)
                            return false;
                        break;
                    };
                case "iyr":
                    {
                        var iyr = int.Parse(fieldValue);
                        if (iyr < 2010 || iyr > 2020)
                            return false;
                        break;
                    };
                case "eyr":
                    {
                        var eyr = int.Parse(fieldValue);
                        if (eyr < 2020 || eyr > 2030)
                            return false;
                        break;
                    };
                case "hgt":
                    {
                        if (fieldValue.EndsWith("cm") || fieldValue.EndsWith("in"))
                        {
                            var unit = fieldValue.Substring(fieldValue.Length - 2);
                            var hgt = int.Parse(fieldValue.Substring(0, fieldValue.Length - 2));
                            if (unit == "cm")
                            {
                                if (hgt < 150 || hgt > 193)
                                    return false;
                            }
                            else if (unit == "in")
                            {
                                if (hgt < 59 || hgt > 76)
                                    return false;
                            }
                        }
                        else
                            return false;
                        break;
                    };
                case "hcl":
                    {
                        if (!fieldValue.StartsWith("#"))
                            return false;
                        if (fieldValue.Length != 7)
                            return false;
                        var hcl = fieldValue.Substring(1, 6);
                        string regexString = @"^[a-z0-9]+$";
                        var regexStringValidator =
                            new RegexStringValidator(regexString);
                        try
                        {
                            regexStringValidator.Validate(hcl);
                            return true;
                        }
                        catch
                        {
                            return false;
                        }

                    }
                case "ecl":
                    {
                        return (fieldValue == "amb" ||
                            fieldValue == "blu" ||
                            fieldValue == "brn" ||
                            fieldValue == "gry" ||
                            fieldValue == "grn" ||
                            fieldValue == "hzl" ||
                            fieldValue == "oth");
                    }
                case "pid":
                    {
                        if (fieldValue.Length != 9)
                            return false;
                        break;
                    }
            }

            return true;
        }
    }
}
