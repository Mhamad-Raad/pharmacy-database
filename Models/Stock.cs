///////////////////////////////////////////////////////////
//  Stock.cs
//  Implementation of the Class Stock
//  Generated by Enterprise Architect
//  Created on:      29-Dec-2021 6:31:41 PM
//  Original author: hamar
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;



public class Stock {

	private string medicineName;
	public String name { get{return medicineName;}
						set{medicineName = value;}
						}

	private double medicinePrice;

	public double price { 
	get { return medicinePrice; }
	set { medicinePrice = value; }
	}
	private int medicineQuantity;
	public int quantity
    {
		get { return medicineQuantity; }
		set { medicineQuantity = value; }
    }

	private String 	medicineDescription;

	public String description {
		get { return medicineDescription; }
		set { medicineDescription = value; } 
	}

	private int medicineId;
	public int id { get { return medicineId; }	
	set { medicineId = value; }
	}

	public Stock(){

	}

	~Stock(){

	}

}//end Stock