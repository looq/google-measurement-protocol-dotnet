﻿using System;
using GoogleMeasurementProtocol.Validators;

namespace GoogleMeasurementProtocol.Parameters.EnhancedECommerce
{
    /// <summary>
    /// The price of a product. For analytics.js the Enhanced Ecommerce plugin must be installed before using this field.
    /// </summary>
    public class ProductPrice : Parameter
    {
        public byte ProductIndex { get; set; }

        public ProductPrice(string value, byte productIndex = 1)
            : base(value)
        {
            ProductIndex = productIndex;
        }

        public override string Name
        {
            get
            {
                IndexValidator.ValidateProductIndex(ProductIndex);

                return string.Format("pr{0}pr", ProductIndex);
            }
        }

        public override Type ValueType
        {
            get { return typeof(decimal); }
        }
    }
}
