using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TerbilangLibrary
{
    public class Terbilang
    {
        public string TerbilangIndonesia(int nominal)
        {
            string strTot = string.Empty;
            string urai = string.Empty;
            string strJmlHuruf = string.Empty;
            string bil1 = string.Empty;
            string bil2 = string.Empty;

            int y = 0;
            int x = 0;
            int z = 0;

            strJmlHuruf = Convert.ToString(nominal);

            urai = string.Empty;
            while (x < strJmlHuruf.Length)
            {
                x++;
                strTot = strJmlHuruf.Substring(x - 1, 1);
                y = y + Convert.ToInt32(strTot);
                z = strJmlHuruf.Length - x + 1;
                switch (Convert.ToInt32(strTot))
                {
                    case 1:
                        if ((z == 1 | z == 7 | z == 10 | z == 13))
                        {
                            bil1 = "SATU ";
                        }
                        else if ((z == 4))
                        {
                            if ((x == 1))
                            {
                                bil1 = "SE";
                            }
                            else
                            {
                                bil1 = "SATU ";
                            }
                        }
                        else if ((z == 2 | z == 5 | z == 8 | z == 11 | z == 14))
                        {
                            x = x + 1;
                            strTot = strJmlHuruf.Substring(x - 1, 1);
                            z = strJmlHuruf.Length - x + 1;
                            bil2 = string.Empty;
                            switch (Convert.ToInt32(strTot))
                            {
                                case 0:
                                    bil1 = "SEPULUH ";
                                    break;
                                case 1:
                                    bil1 = "SEBELAS ";
                                    break;
                                case 2:
                                    bil1 = "DUA BELAS ";
                                    break;
                                case 3:
                                    bil1 = "TIGA BELAS ";
                                    break;
                                case 4:
                                    bil1 = "EMPAT BELAS ";
                                    break;
                                case 5:
                                    bil1 = "LIMA BELAS ";
                                    break;
                                case 6:
                                    bil1 = "ENAM BELAS ";
                                    break;
                                case 7:
                                    bil1 = "TUJUH BELAS ";
                                    break;
                                case 8:
                                    bil1 = "DELAPAN BELAS ";
                                    break;
                                case 9:
                                    bil1 = "SEMBILAN BELAS ";
                                    break;
                            }
                        }
                        else
                        {
                            bil1 = "SE";
                        }
                        break;
                    case 2:
                        bil1 = "DUA ";
                        break;
                    case 3:
                        bil1 = "TIGA ";
                        break;
                    case 4:
                        bil1 = "EMPAT ";
                        break;
                    case 5:
                        bil1 = "LIMA ";
                        break;
                    case 6:
                        bil1 = "ENAM ";
                        break;
                    case 7:
                        bil1 = "TUJUH ";
                        break;
                    case 8:
                        bil1 = "DELAPAN ";
                        break;
                    case 9:
                        bil1 = "SEMBILAN ";
                        break;
                    default:
                        bil1 = string.Empty;
                        break;
                }

                if ((Convert.ToInt32(strTot) > 0))
                {
                    if ((z == 2 | z == 5 | z == 8 | z == 11 | z == 14))
                    {
                        bil2 = "PULUH ";
                    }
                    else if ((z == 3 | z == 6 | z == 9 | z == 12 | z == 15))
                    {
                        bil2 = "RATUS ";
                    }
                    else
                    {
                        bil2 = string.Empty;
                    }
                }
                else
                {
                    bil2 = string.Empty;
                }

                if ((y > 0))
                {
                    switch (z)
                    {
                        case 4:
                            bil2 = bil2 + "RIBU ";
                            y = 0;
                            break;
                        case 7:
                            bil2 = bil2 + "JUTA ";
                            y = 0;
                            break;
                        case 10:
                            bil2 = bil2 + "MILYAR ";
                            y = 0;
                            break;
                        case 13:
                            bil2 = bil2 + "TRILYUN ";
                            y = 0;
                            break;
                    }
                }
                urai = urai + bil1 + bil2;
            }

            return urai + "RUPIAH";
        }
    }
}
