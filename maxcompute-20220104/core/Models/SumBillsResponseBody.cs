// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumBillsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public SumBillsResponseBodyData Data { get; set; }
        public class SumBillsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The currency used for all cost values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>A list of billable items.</para>
            /// </summary>
            [NameInMap("itemBills")]
            [Validation(Required=false)]
            public List<SumBillsResponseBodyDataItemBills> ItemBills { get; set; }
            public class SumBillsResponseBodyDataItemBills : TeaModel {
                /// <summary>
                /// <para>The cost.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123.56</para>
                /// </summary>
                [NameInMap("cost")]
                [Validation(Required=false)]
                public string Cost { get; set; }

                /// <summary>
                /// <para>The currency.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The item name. When the request\&quot;s <c>statsType</c> is <c>PROJECT</c>, this is the instance name. When <c>statsType</c> is <c>FEE_ITEM</c>, this is the billable item type (for example, <c>DRStorage</c>, <c>ComputationSql</c>, or <c>Storage</c>).</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectName</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The percentage of the total cost that this item represents. The value does not include a percent sign (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>56.12</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

            }

            /// <summary>
            /// <para>The total cost of all returned billable items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123.56</para>
            /// </summary>
            [NameInMap("totalCost")]
            [Validation(Required=false)]
            public string TotalCost { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BB66A390-4EF7-557E-9489-7F98D6F44002</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
