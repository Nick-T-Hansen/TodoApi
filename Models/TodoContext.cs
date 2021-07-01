using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoItemContext : DbContext
    {
        public TodoItemContext()
        {

        }

        public TodoItemContext(DbContextOptions<TodoItemContext> options)
            : base(options)
        {
        }
        public DbSet<TodoItem> TodoItem { get; set; }
    }
}

