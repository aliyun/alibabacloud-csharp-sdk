// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class CreateEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The business result code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SUCCESS</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The operation result.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public CreateEventsResponseBodyData Data { get; set; }
        public class CreateEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The write results for each item. A successful outer response does not indicate that every item was written successfully.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<CreateEventsResponseBodyDataResults> Results { get; set; }
            public class CreateEventsResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The error information for the failed item.</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public CreateEventsResponseBodyDataResultsError Error { get; set; }
                public class CreateEventsResponseBodyDataResultsError : TeaModel {
                    /// <summary>
                    /// <para>The error code.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>InvalidParameter</para>
                    /// </summary>
                    [NameInMap("code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The format of the event content is incorrect</para>
                    /// </summary>
                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

                /// <summary>
                /// <para>The event ID generated after the event is successfully saved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>evt-2f5f9c5a8d0e4c3b</para>
                /// </summary>
                [NameInMap("eventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>The time when the event reached the server after being successfully saved. The value is a Unix timestamp in milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1758614401000</para>
                /// </summary>
                [NameInMap("receivedAt")]
                [Validation(Required=false)]
                public long? ReceivedAt { get; set; }

                /// <summary>
                /// <para>STORED or FAILED.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>STORED</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The message about the request processing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID, which is used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A00000-0000-0000-0000-000000000001</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. For batch operations, you must still check the result of each item.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
