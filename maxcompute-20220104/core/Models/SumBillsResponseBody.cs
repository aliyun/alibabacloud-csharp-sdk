// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumBillsResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public SumBillsResponseBodyData Data { get; set; }
        public class SumBillsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>CNY</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            [NameInMap("itemBills")]
            [Validation(Required=false)]
            public List<SumBillsResponseBodyDataItemBills> ItemBills { get; set; }
            public class SumBillsResponseBodyDataItemBills : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123.56</para>
                /// </summary>
                [NameInMap("cost")]
                [Validation(Required=false)]
                public string Cost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CNY</para>
                /// </summary>
                [NameInMap("currency")]
                [Validation(Required=false)]
                public string Currency { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>projectName</para>
                /// </summary>
                [NameInMap("itemName")]
                [Validation(Required=false)]
                public string ItemName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>56.12</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123.56</para>
            /// </summary>
            [NameInMap("totalCost")]
            [Validation(Required=false)]
            public string TotalCost { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>BB66A390-4EF7-557E-9489-7F98D6F44002</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
