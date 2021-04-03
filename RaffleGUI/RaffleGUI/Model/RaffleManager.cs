using System;
using System.Collections.Generic;
using System.Data;

namespace RaffleGUI.Model
{
    public class RaffleManager
    {
        private readonly Random ranNumGen;
        private readonly DataTable playNums;

        public RaffleManager()
        {
            ranNumGen = new Random();
            playNums = new DataTable();
            playNums.Columns.Add(new DataColumn("Numeros Jugando"));
        }

        public bool AddNumber(int num)
        {
            DataRow preRow = playNums.Rows.Find(num);

            DataRowCollection rows = playNums.Rows;
            int rowsLength = rows.Count;
            if (preRow == null)
            {
                int index = BinarySearchTravelDataRowCollection(rows, num, 0, rowsLength, rowsLength / 2);

                DataRow newRow = playNums.NewRow();
                newRow["Numeros Jugando"] = num;

                playNums.Rows.InsertAt(newRow, index);

                return true;
            }
            else
            {
                return false;
            }

        }

        public int AddNumber(int from, int to)
        {
            DataRowCollection rows = playNums.Rows;
            int rowsLength = rows.Count;
            int collectionIndex = BinarySearchTravelDataRowCollection(rows, from, 0, rowsLength, rowsLength / 2);
            int currentNumber;
            int addedNumbersCount = to - from;

            for (currentNumber = from; currentNumber <= to && currentNumber < rowsLength; currentNumber++)
            {
                DataRow newRow = playNums.NewRow();
                newRow["Numeros Jugando"] = currentNumber;

                if ((int)rows[collectionIndex][0] == currentNumber)
                {
                    addedNumbersCount--;
                }
                else
                {
                    rows.InsertAt(newRow, collectionIndex);
                }
                collectionIndex++;
            }

            while (currentNumber <= to)
            {
                playNums.Rows.Add(currentNumber);
                currentNumber++;
            }

            return addedNumbersCount;
        }

        public bool DeleteNumber(int num)
        {
            DataRow numRow = playNums.Rows.Find(num);

            if (numRow != null)
            {
                playNums.Rows.Remove(numRow);
                return true;
            }
            else
            {
                return false;
            }

        }

        public int DeleteNumber(int from, int to)
        {
            int deletedNumbersCount = 0;

            for (int i = from; i <= to; i++)
            {
                DataRow numRow = playNums.Rows.Find(i);

                if (numRow != null)
                {
                    playNums.Rows.Remove(numRow);
                    deletedNumbersCount++;
                }
            }

            return deletedNumbersCount;
        }

        public List<int> ThrowWinners(int numWin)
        {
            List<int> winners = new List<int>();

            for (int i = 0; i < numWin; i++)
            {
                DataRowCollection rows = playNums.Rows;
                int rowsLength = rows.Count;

                int winner = (int)rows[ranNumGen.Next(0, rowsLength + 1)][0];

                while (winners.Contains(winner))
                {
                    winner = (int)rows[ranNumGen.Next(0, rowsLength + 1)][0];
                }

                winners.Add(winner);
            }

            return winners;
        }

        //Adapted from: https://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1
        //This adaptation returns the last visited index
        //Only datarows with int values and 1 column
        public int BinarySearchTravelDataRowCollection(DataRowCollection dRCollection, int key, int min, int max, int prevMid)
        {
            if (min > max)
            {
                return prevMid;
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == (int)dRCollection[mid][0])
                {
                    return mid;
                }
                else if (key < (int)dRCollection[mid][0])
                {
                    return BinarySearchTravelDataRowCollection(dRCollection, key, min, mid - 1, mid);
                }
                else
                {
                    return BinarySearchTravelDataRowCollection(dRCollection, key, mid + 1, max, mid);
                }
            }
        }

    }
}
