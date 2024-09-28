using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FrontEnd.Models;

namespace FrontEnd.Services
{
    public class SalaryService
    {

        private int BasicHour = 8;

        private int BasicPay = 210;

        public SalaryModel TodayPayment(int hour)
        {
            double pay = hour * BasicPay;
            if (hour > 12)
            {
                return new SalaryModel()
                {
                    Message = "hour is over 8 hours"
                };
            }

            if (hour > BasicHour)
            {
                pay += WorkOvertime(hour - BasicHour);
            }

            return new SalaryModel()
            {
                Pay = pay
            };
        }

        private double WorkOvertime(int hour)
        {
            switch (hour)
            {
                case 1:
                    return hour * 300;

                case 2:
                    return hour * 400;

                case 3:
                    return hour * 400;

                case 4:
                default:
                    return hour * 450;
            }
        }
    }
}