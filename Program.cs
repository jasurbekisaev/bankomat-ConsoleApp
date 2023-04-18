
namespace bankomat_3_tilda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int password = 2408, cardpassword, einternet, internet, enumber, number, tarmoq, esoliq, soliq, ejarima;
            int epassword, gaz, kammunal, payment, notenoughcash, ecash, chek, jarima, xizmat, asosiymenyu, tries = 4, balans = 15000000;
            double card;
            Console.WriteLine("  Assalomu alaykum . Xush kelibsiz\n");
            Console.WriteLine(" tilni tanlang :\n 1 - o'zbek tili\n 2 - English\n 3 - руский\n");
            Console.WriteLine("");
            Console.WriteLine("  Afsuski faqat ozbeklar uchun ");
            Console.WriteLine(" ");
            int language;
            language = Convert.ToInt32(Console.ReadLine());
            switch (language)
            {
                // ozbek tili bolsa 
                case 1:
                    {
                    metkaparol:
                        Console.Write(" parrolni kiriting  :");
                        epassword = Convert.ToInt32(Console.ReadLine());
                        // parol togri bolsa
                        if (epassword == password)
                        {
                            Console.WriteLine(" Asosiy menyuga xush kelibsiz ");
                        metkabalansortga:
                            Console.WriteLine("                      Nimani amalga oshirmoqchisiz ?");
                            Console.Write(" 1 - Balans\n 2 - naqd pul olish\n 3 - To'lovlar\n 4 - SMS xabarnoma\n ");
                            asosiymenyu = Convert.ToInt32(Console.ReadLine());
                            switch (asosiymenyu)
                            {
                                // balansga kirilsa
                                case 1:
                                    {
                                        Console.WriteLine($" Sizning balansingizda {balans} som bor ; ");
                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n");
                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                        switch (xizmat)
                                        {
                                            // ortga qaytmoqchi bolsa
                                            case 1:
                                                {
                                                    goto metkabalansortga;
                                                }
                                                break;
                                            // amalni yakunlasa
                                            case 2:
                                                {
                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                    switch (chek)
                                                    {
                                                        case 1:
                                                            {
                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                return;
                                                            }
                                                            break;
                                                        case 2:
                                                            {
                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                return;
                                                            }
                                                            break;
                                                    }

                                                }
                                                break;
                                        }

                                    }
                                    break;
                                // naqd pul olmoqchi bolsa 
                                case 2:
                                    {
                                        Console.WriteLine($" Balansingzida {balans} som bor ");
                                    metkacashortga:
                                        Console.WriteLine(" qancha pul yechib olmoqchisiz  :");
                                        ecash = Convert.ToInt32(Console.ReadLine());
                                        //  agarda puli yetsa 
                                        if (ecash <= balans)
                                        {
                                            balans = balans - ecash;
                                            Console.WriteLine($" balansingzida {balans} som qoldi ");
                                            Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                            xizmat = Convert.ToInt32(Console.ReadLine());
                                            switch (xizmat)
                                            {
                                                // ortga qaytmoqchi bolsa
                                                case 1:
                                                    {
                                                        goto metkacashortga;
                                                    }
                                                    break;
                                                // amalni yakunlasa
                                                case 2:
                                                    {
                                                        Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                        chek = Convert.ToInt32(Console.ReadLine());
                                                        switch (chek)
                                                        {
                                                            // chek olsa
                                                            case 1:
                                                                {
                                                                    Console.WriteLine(" marhamat chekingizni oling ");
                                                                    return;
                                                                }
                                                                break;
                                                            // chek olmasa
                                                            case 2:
                                                                {
                                                                    Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                    return;
                                                                }
                                                                break;
                                                        }

                                                    }
                                                    break;
                                                // asosiy menyuga qaytsa 
                                                case 3:
                                                    {
                                                        goto metkabalansortga;
                                                    }
                                                    break;
                                            }

                                        }
                                        // agar puli yetmasa
                                        else
                                        {
                                            Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                            Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                            notenoughcash = Convert.ToInt32(Console.ReadLine());
                                            switch (notenoughcash)
                                            {

                                                // ortga qaytmoqchi bolsa
                                                case 1:
                                                    {
                                                        goto metkacashortga;
                                                    }
                                                    break;
                                                // amalni yakunlasa
                                                case 2:
                                                    {
                                                        Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                        chek = Convert.ToInt32(Console.ReadLine());
                                                        switch (chek)
                                                        {
                                                            // chek olsa
                                                            case 1:
                                                                {
                                                                    Console.WriteLine(" marhamat chekingizni oling ");
                                                                    return;
                                                                }
                                                                break;
                                                            // chek olmasa
                                                            case 2:
                                                                {
                                                                    Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                    return;
                                                                }
                                                                break;
                                                        }

                                                    }
                                                    break;
                                                // asosiy menyuga qaytsa 
                                                case 3:
                                                    {
                                                        goto metkabalansortga;
                                                    }
                                                    break;
                                            }

                                        }
                                    }
                                    break;
                                // tolov qilmoqchi bolsa
                                case 3:
                                    {
                                        Console.WriteLine(" Tolovlar bolimiga xush kelibsiz : ");
                                        Console.WriteLine(" Tolov turini tanlang : ");
                                    metkatolov:
                                        Console.WriteLine(" 1 - kommunal\n 2 - jarimalar\n 3 - soliqlar\n 4 - mobil\n 5 - internet\n 6 - asosiy menyuga qaytmoqchi bolsangiz");
                                        payment = Convert.ToInt32(Console.ReadLine());
                                        switch (payment)
                                        {
                                            // kommunal tolov qilsa
                                            case 1:
                                                {
                                                    Console.WriteLine(" kommunal tolovlar turini tanlang :");
                                                metkakammunal:
                                                    Console.WriteLine(" 1 - gaz\n 2 - suv\n 3 - svet\n 4 - chqindi\n 5 - ortga qaytish uchun ");
                                                    kammunal = Convert.ToInt32(Console.ReadLine());
                                                    switch (kammunal)
                                                    {
                                                        // gazga tolov qilmoqchi bolsa
                                                        case 1:
                                                            {
                                                                Console.WriteLine($" balansingzida {balans} som bor");
                                                            metkagaz:
                                                                Console.WriteLine(" gazga qancha tolov qilmoqchisiz :");
                                                                gaz = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (gaz <= balans)
                                                                {
                                                                    balans = balans - gaz;
                                                                    Console.WriteLine($" balansingzida {balans} som bor");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkagaz;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }



                                                                }
                                                                // puli yetmasa
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkakammunal;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // suvga tolov qilsa 
                                                        case 2:
                                                            {
                                                                Console.WriteLine($" balansingzida {balans} som bor");
                                                            metkasuv:
                                                                Console.WriteLine(" suvga qancha tolov qilmoqchisiz :");
                                                                gaz = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (gaz <= balans)
                                                                {
                                                                    balans = balans - gaz;
                                                                    Console.WriteLine($" balansingzida {balans} som bor");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkasuv;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }



                                                                }
                                                                // puli yetmasa
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkakammunal;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // svetga tolov qilsa
                                                        case 3:
                                                            {
                                                                Console.WriteLine($" balansingzida {balans} som bor");
                                                            metkasvet:
                                                                Console.WriteLine(" svetgaga qancha tolov qilmoqchisiz :");
                                                                gaz = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (gaz <= balans)
                                                                {
                                                                    balans = balans - gaz;
                                                                    Console.WriteLine($" balansingzida {balans} som bor");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkasvet;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }



                                                                }
                                                                // puli yetmasa
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkakammunal;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // chqindiga tolov qilsa
                                                        case 4:
                                                            {
                                                                Console.WriteLine($" balansingzida {balans} som bor");
                                                            metkachiqindi:
                                                                Console.WriteLine(" chiqindiga qancha tolov qilmoqchisiz :");
                                                                gaz = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (gaz <= balans)
                                                                {
                                                                    balans = balans - gaz;
                                                                    Console.WriteLine($" balansingzida {balans} som bor");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkachiqindi;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }



                                                                }
                                                                // puli yetmasa
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkakammunal;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // ortga qaytsa
                                                        case 5:
                                                            {
                                                                goto metkatolov;
                                                            }
                                                    }

                                                }
                                                break;
                                            // jarimaga tolov qilsa
                                            case 2:
                                                {
                                                    Console.WriteLine(" Jarimalar turini tanlang :  ");
                                                metkajarima:
                                                    Console.WriteLine(" 1 - GAI\n 2 - Soliq\n 3 - MIB\n");
                                                    jarima = Convert.ToInt32(Console.ReadLine());
                                                    switch (jarima)
                                                    {
                                                        // GAI ga tolov qilsa
                                                        case 1:
                                                            {
                                                                Console.WriteLine(" GAI ga qancha miqdorda jarima tolamoqchisiz ? ");
                                                                ejarima = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (ejarima <= balans)
                                                                {
                                                                    balans = balans - ejarima;
                                                                    Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkajarima;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkajarima;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // Soliqqa tolov qilsa
                                                        case 2:
                                                            {
                                                                Console.WriteLine(" SOliqqa ga qancha miqdorda jarima tolamoqchisiz ? ");
                                                                ejarima = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (ejarima <= balans)
                                                                {
                                                                    balans = balans - ejarima;
                                                                    Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkajarima;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkajarima;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // MIB
                                                        case 3:
                                                            {
                                                                Console.WriteLine(" MIB ga qancha miqdorda jarima tolamoqchisiz ? ");
                                                                ejarima = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (ejarima <= balans)
                                                                {
                                                                    balans = balans - ejarima;
                                                                    Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkajarima;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkajarima;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                    }

                                                }
                                                break;
                                            // soliqqa tolov qilsa
                                            case 3:
                                                {
                                                    Console.WriteLine(" Soliq bolimiga hush kelibsiz ");
                                                    Console.WriteLine("  Soliq turini tanlang : ");
                                                metkasoliq:
                                                    Console.WriteLine(" 1 - yer\n 2 - mol-mulk\n 3 - daromad\n 4 - aksiz\n 5 - ortga");
                                                    soliq = Convert.ToInt32(Console.ReadLine());
                                                    switch (soliq)
                                                    {
                                                        // yerga soliq
                                                        case 1:
                                                            {

                                                                Console.WriteLine(" Yer soligiga qancha miqdorda soliq tolamoqchisiz ? ");
                                                                esoliq = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (esoliq <= balans)
                                                                {
                                                                    balans = balans - esoliq;
                                                                    Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkasoliq;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                } //

                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkasoliq;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // Mol -MUlkka soliq
                                                        case 2:
                                                            {
                                                                Console.WriteLine(" Mol-mulk soligiga qancha miqdorda soliq tolamoqchisiz ? ");
                                                                esoliq = Convert.ToInt32(Console.ReadLine());
                                                                // puli yetsa
                                                                if (esoliq <= balans)
                                                                {
                                                                    balans = balans - esoliq;
                                                                    Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkasoliq;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                } //

                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkasoliq;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }

                                                            }
                                                            break;
                                                        // daromad soligag
                                                        case 3:
                                                            {
                                                                {
                                                                    Console.WriteLine(" Daromad soligiga qancha miqdorda soliq tolamoqchisiz ? ");
                                                                    esoliq = Convert.ToInt32(Console.ReadLine());
                                                                    // puli yetsa
                                                                    if (esoliq <= balans)
                                                                    {
                                                                        balans = balans - esoliq;
                                                                        Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkasoliq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    } //

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkasoliq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // aksiz soligi uchun 
                                                        case 4:
                                                            {
                                                                {
                                                                    {
                                                                        Console.WriteLine(" Aksiz soligiga qancha miqdorda soliq tolamoqchisiz ? ");
                                                                        esoliq = Convert.ToInt32(Console.ReadLine());
                                                                        // puli yetsa
                                                                        if (esoliq <= balans)
                                                                        {
                                                                            balans = balans - esoliq;
                                                                            Console.WriteLine($" balansingizda {balans} pul qoldi ");
                                                                            Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                            xizmat = Convert.ToInt32(Console.ReadLine());
                                                                            switch (xizmat)
                                                                            {
                                                                                // ortga qaytmoqchi bolsa
                                                                                case 1:
                                                                                    {
                                                                                        goto metkasoliq;
                                                                                    }
                                                                                    break;
                                                                                // amalni yakunlasa
                                                                                case 2:
                                                                                    {
                                                                                        Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                        chek = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (chek)
                                                                                        {
                                                                                            // chek olsa
                                                                                            case 1:
                                                                                                {
                                                                                                    Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                    return;
                                                                                                }
                                                                                                break;
                                                                                            // chek olmasa
                                                                                            case 2:
                                                                                                {
                                                                                                    Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                    return;
                                                                                                }
                                                                                                break;
                                                                                        }

                                                                                    }
                                                                                    break;
                                                                                // asosiy menyuga qaytsa 
                                                                                case 3:
                                                                                    {
                                                                                        goto metkabalansortga;
                                                                                    }
                                                                                    break;
                                                                            }

                                                                        } //

                                                                        else
                                                                        {
                                                                            Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                            Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                            notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                            switch (notenoughcash)
                                                                            {

                                                                                // ortga qaytmoqchi bolsa
                                                                                case 1:
                                                                                    {
                                                                                        goto metkasoliq;
                                                                                    }
                                                                                    break;
                                                                                // amalni yakunlasa
                                                                                case 2:
                                                                                    {
                                                                                        Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                        chek = Convert.ToInt32(Console.ReadLine());
                                                                                        switch (chek)
                                                                                        {
                                                                                            // chek olsa
                                                                                            case 1:
                                                                                                {
                                                                                                    Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                    return;
                                                                                                }
                                                                                                break;
                                                                                            // chek olmasa
                                                                                            case 2:
                                                                                                {
                                                                                                    Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                    return;
                                                                                                }
                                                                                                break;
                                                                                        }

                                                                                    }
                                                                                    break;
                                                                                // asosiy menyuga qaytsa 
                                                                                case 3:
                                                                                    {
                                                                                        goto metkabalansortga;
                                                                                    }
                                                                                    break;
                                                                            }

                                                                        }

                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        // ortga qaytmoqchi bols
                                                        case 5:
                                                            {
                                                                goto metkatolov;
                                                            }
                                                            break;
                                                    }
                                                }
                                                break;
                                            // mobilga tolov qilsa
                                            case 4:
                                                {
                                                    Console.WriteLine(" Mobil tolov tizimiga hush kelibsiz ");
                                                metkatarmoq:
                                                    Console.WriteLine(" Tarmoqni tanlang :");
                                                    Console.WriteLine(" 1 - Ucell\n 2 - Beeline\n 3 - Humans\n 4 - Uzmobile\n 5 - ortga\n");
                                                    tarmoq = Convert.ToInt32(Console.ReadLine());
                                                    switch (tarmoq)
                                                    {
                                                        // ucell
                                                        case 1:
                                                            {
                                                            qaytaraqam:
                                                                Console.WriteLine(" raqamingzini kiriting : ");
                                                                number = Convert.ToInt32(Console.ReadLine());
                                                                if (number > 930000000 && number < 959999999)
                                                                {
                                                                    Console.WriteLine(" siz hato raqam kiritdingiz qaytadan kiriting ");
                                                                    goto qaytaraqam;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($" sizning raqamingiz : {number} ");
                                                                    Console.WriteLine("  qancha pul otqazmoqchisiz ? ");
                                                                    enumber = Convert.ToInt32(Console.ReadLine());
                                                                    if (enumber <= balans)
                                                                    {
                                                                        balans = balans - enumber;
                                                                        Console.WriteLine($"  hisobingiznga {enumber} som tushdi");
                                                                        Console.WriteLine($" hisobingzida {balans} som qoldi");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }


                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }



                                                                }

                                                            }
                                                            break;
                                                        // beeline
                                                        case 2:
                                                            {
                                                            qaytaraqam:
                                                                Console.WriteLine(" raqamingzini kiriting : ");
                                                                number = Convert.ToInt32(Console.ReadLine());
                                                                if (number < 900000000 || number > 919999999)
                                                                {
                                                                    Console.WriteLine(" siz hato raqam kiritdingiz qaytadan kiriting ");
                                                                    goto qaytaraqam;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($" sizning raqamingiz : {number} ");
                                                                    Console.WriteLine("  qancha pul otqazmoqchisiz ? ");
                                                                    enumber = Convert.ToInt32(Console.ReadLine());
                                                                    if (enumber <= balans)
                                                                    {
                                                                        balans = balans - enumber;
                                                                        Console.WriteLine($"  hisobingiznga {enumber} som tushdi");
                                                                        Console.WriteLine($" hisobingzida {balans} som qoldi");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }


                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }



                                                                }
                                                            }
                                                            break;
                                                        // humans
                                                        case 3:
                                                            {
                                                            qaytaraqam:
                                                                Console.WriteLine(" raqamingzini kiriting : ");
                                                                number = Convert.ToInt32(Console.ReadLine());
                                                                if (number < 330000000 || number > 339999999)
                                                                {
                                                                    Console.WriteLine(" siz hato raqam kiritdingiz qaytadan kiriting ");
                                                                    goto qaytaraqam;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($" sizning raqamingiz : {number} ");
                                                                    Console.WriteLine("  qancha pul otqazmoqchisiz ? ");
                                                                    enumber = Convert.ToInt32(Console.ReadLine());
                                                                    if (enumber <= balans)
                                                                    {
                                                                        balans = balans - enumber;
                                                                        Console.WriteLine($"  hisobingiznga {enumber} som tushdi");
                                                                        Console.WriteLine($" hisobingzida {balans} som qoldi");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }


                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }



                                                                }
                                                            }
                                                            break;
                                                        // uzmobile
                                                        case 4:
                                                            {
                                                            qaytaraqam:
                                                                Console.WriteLine(" raqamingzini kiriting : ");
                                                                number = Convert.ToInt32(Console.ReadLine());
                                                                if ((number < 880000000 || number > 889999999) || (number > 999999999 || number < 990000000))
                                                                {
                                                                    Console.WriteLine(" siz hato raqam kiritdingiz qaytadan kiriting ");
                                                                    goto qaytaraqam;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine($" sizning raqamingiz : {number} ");
                                                                    Console.WriteLine("  qancha pul otqazmoqchisiz ? ");
                                                                    enumber = Convert.ToInt32(Console.ReadLine());
                                                                    if (enumber <= balans)
                                                                    {
                                                                        balans = balans - enumber;
                                                                        Console.WriteLine($"  hisobingiznga {enumber} som tushdi");
                                                                        Console.WriteLine($" hisobingzida {balans} som qoldi");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }


                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkatarmoq;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }



                                                                }
                                                            }
                                                            break;
                                                        // ortga
                                                        case 5:
                                                            {
                                                                goto metkatolov;
                                                            }
                                                            break;
                                                    }
                                                }
                                                break;
                                            // internetga tolov qilsa
                                            case 5:
                                                {
                                                    Console.WriteLine("  Internet tolovlariga xush kelibsiz");
                                                    Console.WriteLine(" Tarifingizni tanlang : ");
                                                metkainternet:
                                                    Console.WriteLine(" 1 - Uz online\n 2- Sarkor\n 3 - Turon\n 4 - Comnet\n 5 - ortga\n");
                                                    internet = Convert.ToInt32(Console.ReadLine());
                                                    switch (internet)
                                                    {
                                                        // uz online tolov
                                                        case 1:
                                                            {
                                                                Console.WriteLine(" uz online tarifiga tolov qiling :");
                                                                Console.WriteLine(" qancha tolov qilmoqchisiz  : ");
                                                                einternet = Convert.ToInt32(Console.ReadLine());
                                                                if (einternet <= balans)
                                                                {
                                                                    balans = balans - einternet;
                                                                    Console.WriteLine($" Siz {einternet}somlik tolov qildiz va hisobingzida {balans} som qoldi ");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                                    switch (xizmat)
                                                                    {
                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkainternet;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }

                                                                else
                                                                {
                                                                    Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                    notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                    switch (notenoughcash)
                                                                    {

                                                                        // ortga qaytmoqchi bolsa
                                                                        case 1:
                                                                            {
                                                                                goto metkainternet;
                                                                            }
                                                                            break;
                                                                        // amalni yakunlasa
                                                                        case 2:
                                                                            {
                                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                                switch (chek)
                                                                                {
                                                                                    // chek olsa
                                                                                    case 1:
                                                                                        {
                                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                    // chek olmasa
                                                                                    case 2:
                                                                                        {
                                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                            return;
                                                                                        }
                                                                                        break;
                                                                                }

                                                                            }
                                                                            break;
                                                                        // asosiy menyuga qaytsa 
                                                                        case 3:
                                                                            {
                                                                                goto metkabalansortga;
                                                                            }
                                                                            break;
                                                                    }

                                                                }
                                                            }
                                                            break;
                                                        // sarkor tolov
                                                        case 2:
                                                            {
                                                                {
                                                                    Console.WriteLine(" Sarkor tarifiga tolov qiling :");
                                                                    Console.WriteLine(" qancha tolov qilmoqchisiz  : ");
                                                                    einternet = Convert.ToInt32(Console.ReadLine());
                                                                    if (einternet <= balans)
                                                                    {
                                                                        balans = balans - einternet;
                                                                        Console.WriteLine($" Siz {einternet}somlik tolov qildiz va hisobingzida {balans} som qoldi ");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkainternet;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkainternet;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        // turon tolov
                                                        case 3:
                                                            {
                                                                {
                                                                    Console.WriteLine(" Turon tarifiga tolov qiling :");
                                                                    Console.WriteLine(" qancha tolov qilmoqchisiz  : ");
                                                                    einternet = Convert.ToInt32(Console.ReadLine());
                                                                    if (einternet <= balans)
                                                                    {
                                                                        balans = balans - einternet;
                                                                        Console.WriteLine($" Siz {einternet}somlik tolov qildiz va hisobingzida {balans} som qoldi ");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkainternet;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkainternet;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        // comnet tolov
                                                        case 4:
                                                            {
                                                                {
                                                                    Console.WriteLine(" Comnet tarifiga tolov qiling :");
                                                                    Console.WriteLine(" qancha tolov qilmoqchisiz  : ");
                                                                    einternet = Convert.ToInt32(Console.ReadLine());
                                                                    if (einternet <= balans)
                                                                    {
                                                                        balans = balans - einternet;
                                                                        Console.WriteLine($" Siz {einternet}somlik tolov qildiz va hisobingzida {balans} som qoldi ");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                                        xizmat = Convert.ToInt32(Console.ReadLine());
                                                                        switch (xizmat)
                                                                        {
                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkainternet;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }

                                                                    else
                                                                    {
                                                                        Console.WriteLine(" Sizning hisobingizdagi mablag yetarli emas");
                                                                        Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n amalni yakunlash uchun 2 ni bosing\n asosiy menyuga qaytish uchun 3 ni bosing\n");
                                                                        notenoughcash = Convert.ToInt32(Console.ReadLine());
                                                                        switch (notenoughcash)
                                                                        {

                                                                            // ortga qaytmoqchi bolsa
                                                                            case 1:
                                                                                {
                                                                                    goto metkainternet;
                                                                                }
                                                                                break;
                                                                            // amalni yakunlasa
                                                                            case 2:
                                                                                {
                                                                                    Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                                    chek = Convert.ToInt32(Console.ReadLine());
                                                                                    switch (chek)
                                                                                    {
                                                                                        // chek olsa
                                                                                        case 1:
                                                                                            {
                                                                                                Console.WriteLine(" marhamat chekingizni oling ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                        // chek olmasa
                                                                                        case 2:
                                                                                            {
                                                                                                Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                                                return;
                                                                                            }
                                                                                            break;
                                                                                    }

                                                                                }
                                                                                break;
                                                                            // asosiy menyuga qaytsa 
                                                                            case 3:
                                                                                {
                                                                                    goto metkabalansortga;
                                                                                }
                                                                                break;
                                                                        }

                                                                    }
                                                                }
                                                            }
                                                            break;
                                                        // ortga
                                                        case 5:
                                                            {
                                                                goto metkatolov;
                                                            }
                                                            break;
                                                    }
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                // sms xabarnoma uchun
                                case 4:
                                    {
                                    metkatel:
                                        Console.WriteLine(" Sms xabarnomani ulash uchun telefon raqamingizni kiriting : (90 000 00 00)");
                                        number = Convert.ToInt32(Console.ReadLine());
                                        if (number < 100000000 || number > 999999999)
                                        {
                                            Console.WriteLine(" siz hato telefon raqam kiritdingiz iltimos qaytadan kiriting :");
                                            goto metkatel;
                                        }
                                        else
                                        {
                                        metkacard:
                                            Console.WriteLine(" karta raqamini kiriting :  ");
                                            card = Convert.ToInt32(Console.ReadLine());
                                            if (card > 9999999999999999 && card < 1000000000000000)
                                            {
                                                Console.WriteLine(" siz karta raqamini notogri kiritdingiz qaytadan kiriting : ");
                                                goto metkacard;
                                            }
                                            else
                                            {
                                                Console.WriteLine(" ");
                                            metkaparoll:
                                                Console.WriteLine(" Telefon raqamingizga kelgan 4 xonali parolni kiriting :");
                                                cardpassword = Convert.ToInt32(Console.ReadLine());
                                                if (cardpassword > 999 && cardpassword < 1001)
                                                {
                                                    Console.WriteLine("  Tabriklaymiz kartangiz telefon raqamingizga muvaffaqiyatli ulandi :");
                                                    Console.WriteLine(" ortga qaytish uchun 1 ni bosing\n xizmatni yakunlash uchun 2 ni bosing\n asosiy menyuni tanlash uchun 3 ni bosing\n ");
                                                    xizmat = Convert.ToInt32(Console.ReadLine());
                                                    switch (xizmat)
                                                    {
                                                        // ortga qaytmoqchi bolsa
                                                        case 1:
                                                            {
                                                                goto metkaparoll;
                                                            }
                                                            break;
                                                        // amalni yakunlasa
                                                        case 2:
                                                            {
                                                                Console.WriteLine(" chek olish uchun  1 ni bosing\n kerak bolmasa 2 ni bosing\n");
                                                                chek = Convert.ToInt32(Console.ReadLine());
                                                                switch (chek)
                                                                {
                                                                    // chek olsa
                                                                    case 1:
                                                                        {
                                                                            Console.WriteLine(" marhamat chekingizni oling ");
                                                                            return;
                                                                        }
                                                                        break;
                                                                    // chek olmasa
                                                                    case 2:
                                                                        {
                                                                            Console.WriteLine(" Foydalanganingiz uchun rahmat ");
                                                                            return;
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        // asosiy menyuga qaytsa 
                                                        case 3:
                                                            {
                                                                goto metkabalansortga;
                                                            }
                                                            break;
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine(" siz parolni notogri kiritdingiz qaytadan kiriting :");
                                                    goto metkaparoll;
                                                }
                                            }
                                        }
                                    }
                                    break;
                            }
                        }
                        // hato parol kiritilsa
                        else
                        {
                            tries--;
                            Console.WriteLine($" siz parolni notogri kiritdingiz va sizda {tries} ta imkoniyatingiz qoldi");
                            if (tries == 0)
                            {
                                Console.WriteLine(" siz barcha imkoniyatlardan foydalandingiz va kartangiz bloklandi ");
                                return;
                            }
                            goto metkaparol;
                        }
                        break;
                    }
            }
        }
    }
}