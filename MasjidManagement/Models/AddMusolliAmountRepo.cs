﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasjidManagement.Models
{
    public class AddMusolliAmountRepo
    {
        private readonly List<AddMusolliAmount>[] _addamount= new List<AddMusolliAmount>[50];
        
        public AddMusolliAmountRepo()
        {
            _addamount[1] = new List<AddMusolliAmount>(){

                 new AddMusolliAmount(){Id=1,Date="01 Nov 2019",Amount=50},
                 new AddMusolliAmount(){Id=2,Date="10 Dec 2019",Amount=100},
                 new AddMusolliAmount(){Id=3,Date="03 Jan 2020",Amount=200},
                 new AddMusolliAmount(){Id=4,Date="15 Feb 2020",Amount=300}
              };

            _addamount[2] = new List<AddMusolliAmount>(){

                 new AddMusolliAmount(){Id=1,Date="05 Nov 2019",Amount=500},
                 new AddMusolliAmount(){Id=2,Date="11 Dec 2019",Amount=550},
                 new AddMusolliAmount(){Id=3,Date="25 Jan 2020",Amount=600},
                 new AddMusolliAmount(){Id=4,Date="20 Feb 2020",Amount=650}
              };

            _addamount[3] = new List<AddMusolliAmount>(){

                 new AddMusolliAmount(){Id=1,Date="30 Nov 2019",Amount=700},
                 new AddMusolliAmount(){Id=2,Date="03 Dec 2019",Amount=750},
                 new AddMusolliAmount(){Id=3,Date="09 Jan 2020",Amount=800},
                 new AddMusolliAmount(){Id=4,Date="19 Feb 2020",Amount=850}
              };

            _addamount[4] = new List<AddMusolliAmount>(){

                 new AddMusolliAmount(){Id=1,Date="08 Nov 2019",Amount=900},
                 new AddMusolliAmount(){Id=2,Date="18 Dec 2019",Amount=950},
                 new AddMusolliAmount(){Id=3,Date="28 Jan 2020",Amount=1000},
                 new AddMusolliAmount(){Id=4,Date="13 Feb 2020",Amount=1050}
              };
        }
   
        public AddMusolliAmount AddAmount(AddMusolliAmount addMusolliAmount, int id)
        {
            _addamount[id].Add(addMusolliAmount);
            return addMusolliAmount;
        }

         public AddMusolliAmount GetAmount(int index , int id)
         {
            return _addamount[index][id];
        }

        public IEnumerable<AddMusolliAmount> GetAllAmount(int id)
        {
            return _addamount[id];
        }

        public AddMusolliAmount Update(AddMusolliAmount amountChanges, int index, int id)
        {
            AddMusolliAmount addMusolliAmount = _addamount[index][id];

            if (addMusolliAmount != null)
            {
                addMusolliAmount.Date = amountChanges.Date;
                addMusolliAmount.Amount = amountChanges.Amount;
            }
            return addMusolliAmount;
        }
    }
}