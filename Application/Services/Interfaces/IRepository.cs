﻿namespace Application.Services.Interfaces;

public class IRepository<T>
{
    int Create(T entity);
    int Update(T entity);
    int Delete(T entity);
    IEnumerable<T> GetAll();
    T GetById(int id);
}
