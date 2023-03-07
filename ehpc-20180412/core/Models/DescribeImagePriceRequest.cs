// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeImagePriceRequest : TeaModel {
        /// <summary>
        /// The number of images that you want to purchase. Valid values: 1 to 1000.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("Amount")]
        [Validation(Required=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// The ID of the image.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The type of the order. The order can be set only as a purchase order. Valid value: INSTANCE-BUY.
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// The subscription duration. Valid values:
        /// 
        /// *   If PriceUnit is set to Day, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, and 30.
        /// *   If PriceUnit is set to Month, the valid values of the Period parameter are 1, 2, 3, 4, 5, 6, 7, 8, and 9.
        /// *   If PriceUnit is set to Year, the valid values of the Period parameter are 1, 2, and 3.
        /// 
        /// Default value: 1
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// The unit of the subscription duration. Valid values:
        /// 
        /// *   Day
        /// *   Month
        /// *   Year
        /// 
        /// Default value: Day
        /// </summary>
        [NameInMap("PriceUnit")]
        [Validation(Required=false)]
        public string PriceUnit { get; set; }

        /// <summary>
        /// The stock keeping unit (SKU) of the image. Valid value: package.
        /// </summary>
        [NameInMap("SkuCode")]
        [Validation(Required=false)]
        public string SkuCode { get; set; }

    }

}
