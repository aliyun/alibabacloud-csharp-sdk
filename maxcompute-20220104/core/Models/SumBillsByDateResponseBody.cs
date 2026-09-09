// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumBillsByDateResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumBillsByDateResponseBodyData> Data { get; set; }
        public class SumBillsByDateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The total cost for the specified <c>dateTime</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            /// <summary>
            /// <para>The currency. This is a fixed value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RMB</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <para>The date of the statistics, in <c>yyyyMMdd</c> format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20250719</para>
            /// </summary>
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            /// <summary>
            /// <para>A list of billable items.</para>
            /// </summary>
            [NameInMap("itemBills")]
            [Validation(Required=false)]
            public List<SumBillsByDateResponseBodyDataItemBills> ItemBills { get; set; }
            public class SumBillsByDateResponseBodyDataItemBills : TeaModel {
                /// <summary>
                /// <para>The cost.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("cost")]
                [Validation(Required=false)]
                public string Cost { get; set; }

                /// <summary>
                /// <para>The currency. This is a fixed value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>RMB</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <para>The name of the item. The value of this parameter depends on the <c>statsType</c> parameter in the request. If <c>statsType</c> is <c>PROJECT</c>, this parameter indicates the instance name. If <c>statsType</c> is <c>FEE_ITEM</c>, this parameter can be a value such as <c>DRStorage</c>, <c>ComputationSql</c>, or <c>Storage</c>.</para>
                /// 
                /// <b>Example:</b>
                /// <para>projectName</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <para>The item\&quot;s cost as a percentage of the total daily cost. This value does not include a percent sign (%).</para>
                /// 
                /// <b>Example:</b>
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

            }

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
