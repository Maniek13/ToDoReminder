﻿using System;
using ToDoList.DbControler;
using ToDoList.Helper;
using ToDoList.Models;

namespace ToDoList.ViewModels
{
    public sealed class AddTaskUserControlViewModel
    {
        TaskDbControler taskDbControler = new();
        internal void AddTask(Task task, Reminder reminder = new Reminder())
        {
            try
            {
                if(task.HasReminder)
                {
                    TaskShulder taskShulder = new();
                    taskShulder.CreateTaskShulder(ConversionHelper.ConvertToDbReminder(reminder));
                }

                taskDbControler.AddTask(ConversionHelper.ConvertToDbTask(task));

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

    }
}
