function myFunction()
{
    var s = document.getElementById("myList");
    var str = s.options[s.selectedIndex].value;
    if (str == 1)
    {
        customers = Model.Customers.OrderBy(c => c.Name).ToList();
        for (var i = 0; i < Model.Customers.length; i++)
        {
            document.getElementById("cust").innerHTML = Model.Customers[0].Name;
        }
    }
    else if (str == 2)
    {
        alert(2);
    }
    else if (str == 3)
    {
        alert("3");
    }
}