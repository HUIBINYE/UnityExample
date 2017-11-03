/****************************************************************************
 * Copyright (c) 2017 yuanhuibin@putao.com
 ****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentInfo
{
      ///不支持这样写
//    public int ID { get; private set; }
//    public string Name { get; private set; }
//    public int Age { get; private set; }


    public int ID;
    public string Name;
    public int Age;

    public StudentInfo(int ID,string name,int age)
    {
        this.ID = ID;
        this.Name = name;
        this.Age = age;
    }
}
