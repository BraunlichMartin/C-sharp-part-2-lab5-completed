using System;

public class Customer
{
    //Constructors-MWB_2/16/2019
    public CustomerContactInfo() { }
    public CustomerContactInfo(string firstName, string lastName, string email)
    {
        if(this.FirstName.Length>30)
        {
            throw new System.ArgumentException("length is greater than 30", "FirstName);
        }
        else
        {
            this.FirstName = firstName;
        }
        if(this.LastName.Length>30)
        {
            throw new System.ArgumentException("length is greater than 30", "LastName");
        }
        else
        {
            this.LastName = lastName;
        }
        //this.FirstName = firstName;
        if(this.Email.Length>30)
        {
            throw new System.ArgumentException("length is greater than 30", "Email");
        }
        else
        {
            this.Email = email;
        }
        
    }
    //Properties-MWB_2/16/2019
    public string FirstName
    {
        get
        {
            return firstName;
        }
        set
        {
            firstName = value;
        }
	}
    public string LastName
    {
        get
        {
            return lastName;
        }
        set
        {
            lastName = value;
        }
    }
    public string Email
    {
        get
        {
            return email;
        }
        set
        {
            email = value;
        }
    }
    //Methods-MWB_2/16/2019
    public string GetDisplayText() => firstName + lastName + ", " + email;
    
}
