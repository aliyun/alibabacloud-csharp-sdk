// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulSummaryResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVulSummaryResponseBodyData Data { get; set; }
        public class GetVulSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CompletedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DealRate")]
            [Validation(Required=false)]
            public string DealRate { get; set; }

            [NameInMap("TrendList")]
            [Validation(Required=false)]
            public List<GetVulSummaryResponseBodyDataTrendList> TrendList { get; set; }
            public class GetVulSummaryResponseBodyDataTrendList : TeaModel {
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DealCount")]
                [Validation(Required=false)]
                public long? DealCount { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("FindCount")]
                [Validation(Required=false)]
                public long? FindCount { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("WaitHandleCount")]
            [Validation(Required=false)]
            public long? WaitHandleCount { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>system error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF801DD1-D934-51B3-92D4-776CE17B184F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
