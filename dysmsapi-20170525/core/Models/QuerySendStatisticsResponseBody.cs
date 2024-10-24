// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// <list type="bullet">
        /// <item><description>If OK is returned, the request is successful.</description></item>
        /// <item><description>Other values indicate that the request fails. For more information, see <a href="https://help.aliyun.com/document_detail/101346.html">Error codes</a>.</description></item>
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
            /// <para>The details of the data returned.</para>
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<QuerySendStatisticsResponseBodyDataTargetList> TargetList { get; set; }
            public class QuerySendStatisticsResponseBodyDataTargetList : TeaModel {
                /// <summary>
                /// <para>The number of messages without a delivery receipt.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("NoRespondedCount")]
                [Validation(Required=false)]
                public long? NoRespondedCount { get; set; }

                /// <summary>
                /// <para>The number of messages with a delivery receipt that indicates a failure.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("RespondedFailCount")]
                [Validation(Required=false)]
                public long? RespondedFailCount { get; set; }

                /// <summary>
                /// <para>The number of messages with a delivery receipt that indicates a success.</para>
                /// 
                /// <b>Example:</b>
                /// <para>17</para>
                /// </summary>
                [NameInMap("RespondedSuccessCount")]
                [Validation(Required=false)]
                public long? RespondedSuccessCount { get; set; }

                /// <summary>
                /// <para>The date when the message is sent. Format: yyyyMMdd. Example: 20181225.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20201010</para>
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// <para>The number of delivered messages.</para>
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
        /// <para>The returned message.</para>
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
        /// <para>819BE656-D2E0-4858-8B21-B2E47708****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
