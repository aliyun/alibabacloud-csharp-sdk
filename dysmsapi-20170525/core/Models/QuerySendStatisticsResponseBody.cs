// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>OK: The request was successful.</para>
        /// </description></item>
        /// <item><description><para>For other values, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySendStatisticsResponseBodyData Data { get; set; }
        public class QuerySendStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of delivery statistics.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<QuerySendStatisticsResponseBodyDataTargetList> TargetList { get; set; }
            public class QuerySendStatisticsResponseBodyDataTargetList : TeaModel {
                /// <summary>
                /// <para>The number of messages with no delivery receipts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoRespondedCount")]
                [Validation(Required=false)]
                public long? NoRespondedCount { get; set; }

                /// <summary>
                /// <para>The number of messages with failed delivery receipts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RespondedFailCount")]
                [Validation(Required=false)]
                public long? RespondedFailCount { get; set; }

                /// <summary>
                /// <para>The number of messages with successful delivery receipts.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("RespondedSuccessCount")]
                [Validation(Required=false)]
                public long? RespondedSuccessCount { get; set; }

                /// <summary>
                /// <para>The date the messages were sent. Format: yyyyMMdd.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201010</para>
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// <para>The number of successfully sent messages (billable message count).</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F655A8D5-B967-440B-8683-DAD6FF8DE990</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
