

using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using TechApp.Interfaces;

namespace TechApp.Extensions
{
    public static class ConvertExtensions
    {
        public static List<SelectListItem> ConvertToSelectList<T>(this IEnumerable<T> collection, int selectValue) where T : IPrimaryProperties
        {
            return (from item in collection
                    select new SelectListItem
                    {
                        Text = item.Title,
                        Value = item.Id.ToString(), // Corrected the assignment operator
                        Selected = (item.Id == selectValue)
                    }).ToList(); // Added ToList() to return a List<SelectListItem>
        }
    }
}

