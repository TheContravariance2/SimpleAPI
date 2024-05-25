namespace SimpleAPI.Tests;

using Moq;
using SimpleAPI;

public class UnitTest1
{
    ValuesController valuesController=new ValuesController();

    [Fact]
    public void Test1()
    {
         

    }

    [Fact]
    public void ValueControllerTest() {

        var myvalue = valuesController.Get(1);
        Assert.NotNull(myvalue);
        Assert.Equal("Hi There, executed successfully",myvalue);


    }
}