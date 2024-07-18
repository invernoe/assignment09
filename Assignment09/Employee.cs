class Employee : ICloneable, IComparable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public Department Department { get; set; }

    public Employee()
    {
        
    }

    public Employee(Employee employee)
    {
        this.Id = employee.Id;
        this.Name = employee.Name;
        this.Salary = employee.Salary;
        this.Department = (Department) employee.Department.Clone();
    }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }

    public object Clone()
    {
        return new Employee(this);
    }

    public int CompareTo(object? obj)
    {
        Employee passedEmployee = (Employee) obj;
        if (this.Salary < passedEmployee.Salary)
            return -1;
        else if (this.Salary > passedEmployee.Salary)
            return 1;
        else
            return 0;
    }
}

class Department : ICloneable
{
    public int Id { get; set; }
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Id: {Id}, Name: {Name}";
    }

    public object Clone()
    {
        return new Department()
        {
            Id = this.Id,
            Name = this.Name
        };
    }
}