using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionProject
{
    public interface DBConnectionInterface
    {
        void insertData();
        void updateData();
        void DeleteData();
        void DisplayData();

        void SearchData();


    }
}
