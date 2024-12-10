// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mssp20161228.Models
{
    public class GetVulSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>Interface response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Data returned by the interface.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetVulSummaryResponseBodyData Data { get; set; }
        public class GetVulSummaryResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Number of completed items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("CompletedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            /// <summary>
            /// <para>Risk convergence rate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("DealRate")]
            [Validation(Required=false)]
            public string DealRate { get; set; }

            /// <summary>
            /// <para>Collection of vulnerability trend nodes.</para>
            /// </summary>
            [NameInMap("TrendList")]
            [Validation(Required=false)]
            public List<GetVulSummaryResponseBodyDataTrendList> TrendList { get; set; }
            public class GetVulSummaryResponseBodyDataTrendList : TeaModel {
                /// <summary>
                /// <para>Time point.</para>
                /// 
                /// <b>Example:</b>
                /// <para>202407或者20240701</para>
                /// </summary>
                [NameInMap("Date")]
                [Validation(Required=false)]
                public string Date { get; set; }

                /// <summary>
                /// <para>Number of handled items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("DealCount")]
                [Validation(Required=false)]
                public long? DealCount { get; set; }

                /// <summary>
                /// <para>Number of discovered items.</para>
                /// 
                /// <b>Example:</b>
                /// <para>15</para>
                /// </summary>
                [NameInMap("FindCount")]
                [Validation(Required=false)]
                public long? FindCount { get; set; }

            }

            /// <summary>
            /// <para>Number of unhandled items.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("WaitHandleCount")]
            [Validation(Required=false)]
            public long? WaitHandleCount { get; set; }

        }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Prompt message for the response result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>system error</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EF801DD1-D934-51B3-92D4-776CE17B184F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Whether the call was successful. - <b>true</b>: The call was successful. - <b>false</b>: The call failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
