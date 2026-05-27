// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class SumBillsByDateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<SumBillsByDateResponseBodyData> Data { get; set; }
        public class SumBillsByDateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("cost")]
            [Validation(Required=false)]
            public string Cost { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RMB</para>
            /// </summary>
            [NameInMap("currency")]
            [Validation(Required=false)]
            public string Currency { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20250719</para>
            /// </summary>
            [NameInMap("dateTime")]
            [Validation(Required=false)]
            public string DateTime { get; set; }

            [NameInMap("itemBills")]
            [Validation(Required=false)]
            public List<SumBillsByDateResponseBodyDataItemBills> ItemBills { get; set; }
            public class SumBillsByDateResponseBodyDataItemBills : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("cost")]
                [Validation(Required=false)]
                public string Cost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>RMB</para>
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
                /// <para>50</para>
                /// </summary>
                [NameInMap("percentage")]
                [Validation(Required=false)]
                public double? Percentage { get; set; }

            }

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
