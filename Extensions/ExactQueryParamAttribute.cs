﻿using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace lonefire.Extensions
{
    //Function Overloading Helper
    public class ExactQueryParamAttribute : Attribute, IActionConstraint
    {
        private readonly string[] keys;

        public ExactQueryParamAttribute(params string[] keys)
        {
            this.keys = keys;
        }

        public int Order => 0;

        public bool Accept(ActionConstraintContext context)
        {
            var query = context.RouteContext.HttpContext.Request.Query;
            return query.Count == keys.Length && keys.All(query.ContainsKey);
        }
    }
}
