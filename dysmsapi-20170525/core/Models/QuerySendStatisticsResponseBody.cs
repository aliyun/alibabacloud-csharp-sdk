// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dysmsapi20170525.Models
{
    public class QuerySendStatisticsResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// 
        /// *   If OK is returned, the request is successful.
        /// *   Other values indicate that the request fails. For more information, see [Error codes](https://help.aliyun.com/document_detail/101346.html).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySendStatisticsResponseBodyData Data { get; set; }
        public class QuerySendStatisticsResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the data returned.
            /// </summary>
            [NameInMap("TargetList")]
            [Validation(Required=false)]
            public List<QuerySendStatisticsResponseBodyDataTargetList> TargetList { get; set; }
            public class QuerySendStatisticsResponseBodyDataTargetList : TeaModel {
                /// <summary>
                /// The number of messages without a delivery receipt.
                /// </summary>
                [NameInMap("NoRespondedCount")]
                [Validation(Required=false)]
                public long? NoRespondedCount { get; set; }

                /// <summary>
                /// The number of messages with a delivery receipt that indicates a failure.
                /// </summary>
                [NameInMap("RespondedFailCount")]
                [Validation(Required=false)]
                public long? RespondedFailCount { get; set; }

                /// <summary>
                /// The number of messages with a delivery receipt that indicates a success.
                /// </summary>
                [NameInMap("RespondedSuccessCount")]
                [Validation(Required=false)]
                public long? RespondedSuccessCount { get; set; }

                /// <summary>
                /// The date when the message is sent. Format: yyyyMMdd. Example: 20181225.
                /// </summary>
                [NameInMap("SendDate")]
                [Validation(Required=false)]
                public string SendDate { get; set; }

                /// <summary>
                /// The number of delivered messages.
                /// </summary>
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalSize")]
            [Validation(Required=false)]
            public long? TotalSize { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
