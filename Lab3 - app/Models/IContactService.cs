﻿namespace Lab3___app.Models
{
    public interface IContactService
    {
        void add(Contact contact);
        void RemoveByID(int id);
        List<Contact> FindAll();
        void Update(Contact contact);
        Contact? FindByID(int id);
    }
}

