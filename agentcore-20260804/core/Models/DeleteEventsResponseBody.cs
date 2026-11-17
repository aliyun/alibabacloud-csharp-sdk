// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class DeleteEventsResponseBody : TeaModel {
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
        /// <para>The operation results.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public DeleteEventsResponseBodyData Data { get; set; }
        public class DeleteEventsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The itemized deletion results.</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("results")]
            [Validation(Required=false)]
            public List<DeleteEventsResponseBodyDataResults> Results { get; set; }
            public class DeleteEventsResponseBodyDataResults : TeaModel {
                /// <summary>
                /// <para>The error details for failed items.</para>
                /// </summary>
                [NameInMap("error")]
                [Validation(Required=false)]
                public DeleteEventsResponseBodyDataResultsError Error { get; set; }
                public class DeleteEventsResponseBodyDataResultsError : TeaModel {
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
                    /// <para>The error description.</para>
                    /// <para>This parameter is required.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The event content format is incorrect</para>
                    /// </summary>
                    [NameInMap("message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

                /// <summary>
                /// <para>The ID of the event requested to be deleted.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>evt-2f5f9c5a8d0e4c3b</para>
                /// </summary>
                [NameInMap("eventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

                /// <summary>
                /// <para>Valid values: DELETED, NOT_FOUND, and FAILED.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>DELETED</para>
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
        /// <para>The description of the request processing result.</para>
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
        /// <para>Indicates whether the request was successful. For batch API operations, you must still check the results of individual items.</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
