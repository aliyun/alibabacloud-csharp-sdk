// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// The array of cluster prices. If you query the prices of multiple nodes in the cluster, the sequence of the prices in the returned value of PriceInfo is the same as that of the nodes in the request parameters. For example, the first price in the value of PriceInfo is the price of the first node specified in the request parameters.
        /// </summary>
        [NameInMap("Prices")]
        [Validation(Required=false)]
        public DescribePriceResponseBodyPrices Prices { get; set; }
        public class DescribePriceResponseBodyPrices : TeaModel {
            [NameInMap("PriceInfo")]
            [Validation(Required=false)]
            public List<DescribePriceResponseBodyPricesPriceInfo> PriceInfo { get; set; }
            public class DescribePriceResponseBodyPricesPriceInfo : TeaModel {
                /// <summary>
                /// The currency that is used to measure the price. Valid values:
                /// 
                /// USD
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// The type of the node. Valid values:
                /// 
                /// *   Manager: management node
                /// *   Login: logon node
                /// *   Compute: compute node
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// The original price of the image.
                /// 
                /// Unit: USD
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// The final price.
                /// 
                /// Unit: USD
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total price.
        /// 
        /// Unit: USD
        /// </summary>
        [NameInMap("TotalTradePrice")]
        [Validation(Required=false)]
        public float? TotalTradePrice { get; set; }

    }

}
