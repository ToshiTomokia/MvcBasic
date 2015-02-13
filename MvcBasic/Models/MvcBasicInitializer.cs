using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace MvcBasic.Models
{
    public class MvcBasicInitializer : DropCreateDatabaseAlways<MvcBasicContext>
    {
        protected override void Seed(MvcBasicContext context)
        {
            var members = new List<Member> {
                new Member {
                    Name = "yamada rio",
                    Email = "rio@email.co.jp",
                    Birth = DateTime.Parse("1980-06-25"),
                    Married = false,
                    Memo = "liked piano"
                },
                new Member {
                    Name = "hio naohiro",
                    Email = "naohiro@email.co.jp",
                    Birth = DateTime.Parse("1975-07-19"),
                    Married = false,
                    Memo = "I am Doctor"
                }
            };
            members.ForEach(m => context.Members.Add(m));
            context.SaveChanges();
        }
    }
}