using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using comp229_mvc_lesson_12.Models;

namespace comp229_mvc_lesson_12.ViewModels {
    public class ShoppingCartViewModel {

        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}