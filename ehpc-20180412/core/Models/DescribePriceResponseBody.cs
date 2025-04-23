// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribePriceResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of cluster prices. If you query the prices of multiple nodes in the cluster, the sequence of the prices in the returned value of PriceInfo is the same as the sequence of the nodes in the request parameters. For example, the first price in the value of PriceInfo is the price of the first node specified in the request parameters.</para>
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
                /// <para>The currency that is used to measure the price. Valid values:</para>
                /// <para>USD</para>
                /// 
                /// <b>Example:</b>
                /// <para>USD</para>
                /// </summary>
                [NameInMap("Currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The node type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Manager: management node</description></item>
                /// <item><description>Login: logon node</description></item>
                /// <item><description>Compute: compute node</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Compute</para>
                /// </summary>
                [NameInMap("NodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>The original price.</para>
                /// <para>Unit: USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1258</para>
                /// </summary>
                [NameInMap("OriginalPrice")]
                [Validation(Required=false)]
                public float? OriginalPrice { get; set; }

                /// <summary>
                /// <para>The final price.</para>
                /// <para>Unit: USD.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1258</para>
                /// </summary>
                [NameInMap("TradePrice")]
                [Validation(Required=false)]
                public float? TradePrice { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>54FF9025-2C2F-42EB-870D-0DF5B0ACF24E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total price.</para>
        /// <para>Unit: USD.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1258</para>
        /// </summary>
        [NameInMap("TotalTradePrice")]
        [Validation(Required=false)]
        public float? TotalTradePrice { get; set; }

    }

}
