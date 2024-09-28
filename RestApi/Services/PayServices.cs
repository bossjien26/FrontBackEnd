using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApi.Model;

namespace RestApi.Services
{
    public class PayServices
    {
        private int BasicHour = 8;

        private int BasicPay = 210;

        public Salary TodayPayment(int hour)
        {
            double pay = hour * BasicPay;
            if (hour > 12)
            {
                return new Salary()
                {
                    Message = "hour is over 8 hours"
                };
            }

            if (hour > BasicHour)
            {
                pay += WorkOvertime(hour - BasicHour);
            }

            return new Salary()
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