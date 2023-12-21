class Teacher
{
    string fullName;
    string subject;
    int experience;

    public Teacher() 
    {

    }
    public Teacher(string name, string subjec)
    {
        fullName = name;

        subject = subjec;
    }
    public Teacher(string name, string subjec, int experience)
    {
        fullName = name;

        subject = subjec;

        this.experience = experience;
    }
    public string Teach()
    {
        return $"{fullName} is teaching {subject}";
    }
    public void SetExperience(int years)
    {
        experience = years;
    }
    public int GetExperience()
    {
        return experience;
    }
}