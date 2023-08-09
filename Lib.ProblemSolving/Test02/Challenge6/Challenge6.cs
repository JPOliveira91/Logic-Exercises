using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Lib.ProblemSolving.Test02.Challenge6;

public class Challenge6
{
    public Challenge6()
    {

    }

    public List<LinkedItem> LinkedItens
    {
        get
        {
            var linkedItens = new List<LinkedItem>();
            var tempLinkedItem = FirstLinkedItem;

            while (tempLinkedItem != null)
            {
                linkedItens.Add(tempLinkedItem);
                tempLinkedItem = tempLinkedItem.Behind;
            }

            return linkedItens;
        }
    }

    public void PopulateList(List<int> listToAdd)
    {
        foreach (var number in listToAdd)
        {
            var newLinkedItem = new LinkedItem();
            newLinkedItem.Value = number;

            if (FirstLinkedItem == null)
            {
                FirstLinkedItem = newLinkedItem;
            }
            else
            {
                var lastLinkedItem = GetLastLinkedItem();
                lastLinkedItem.Behind = newLinkedItem;
            }
        }
    }

    public void Remove(int number)
    {
        var tempLinkedItem = FirstLinkedItem;

        if (FirstLinkedItem?.Value == number)
        {
            FirstLinkedItem = FirstLinkedItem.Behind;
        }
        else
        {
            while (tempLinkedItem != null)
            {
                if (number == tempLinkedItem.Behind?.Value)
                {
                    tempLinkedItem.Behind = tempLinkedItem.Behind.Behind;
                    return;
                }
                tempLinkedItem = tempLinkedItem.Behind;
            }
        }

    }

    #region Private
    private LinkedItem? FirstLinkedItem { get; set; }

    private LinkedItem? GetLastLinkedItem()
    {
        var tempLinkedItem = FirstLinkedItem;
        while (tempLinkedItem?.Behind != null)
        {
            tempLinkedItem = tempLinkedItem.Behind;
        }
        return tempLinkedItem;
    }
    #endregion
}

public class LinkedItem
{
    public int Value { get; set; }
    public LinkedItem? Behind { get; set; }
}