// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeQuickSaleConfigResponseBody : TeaModel {
        /// <summary>
        /// The product code. Valid values:
        /// 
        /// *   rds: The instance is a subscription instance.
        /// *   bards: The instance is a pay-as-you-go instance.
        /// </summary>
        [NameInMap("Commodity")]
        [Validation(Required=false)]
        public string Commodity { get; set; }

        /// <summary>
        /// The configuration details of the product.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public Dictionary<string, object> Items { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
