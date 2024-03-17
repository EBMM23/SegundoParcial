using Application;
using TestData;
using TestData.Models;

InputFormat inputFormat = TestDataSource.TestCase0();// .TestCase1() - .TestCase2() - .TestCase3()

int result = ActivityNotifications.getExpenditureNotifications(inputFormat.Expenditure, inputFormat.Days);

if (inputFormat.Result == result)
{
    Console.WriteLine("The notifications are correct.");
}
else
{
    Console.WriteLine("The notifications are not equal.");
}