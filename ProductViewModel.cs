using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
	public class ProductViewModel
	{
		[Required]
		[Display(Name = "Product Id")]
		public int Product_Id { get; set; }

		[Required]
		[Display(Name = "Product Name")]
		public string Product_Name { get; set; }

		[Required]
		[Display(Name = "Description")]
		public string Description { get; set; }

		[Required]
		[Display(Name = "Minimum Bid Amount")]
		public double? Minimum_Bid_Amount { get; set; }

		[Required]
		[Display(Name = "Auction Time")]
		public DateTime? Auction_Time { get; set; }

		[Required]
		[Display(Name = "Select Category")]
		public string Select_Category { get; set; }



		[Display(Name = "Added_on")]
		public DateTime? Added_on { get; set; }

		[Display(Name = "Added_by")]
		public string Added_by { get; set; }
		//[Required]
		//[Display(Name = "Upload Image")]
		//public Image TrendPictureURL { get; set; }
	}
}