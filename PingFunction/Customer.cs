using System;

public class Customer
{
    private Repository repository;

    public Customer(Repository repository)
    {
        this.repository = repository;

        if(this.repository == null)
            throw new NullReferenceException("repository");
    }
}