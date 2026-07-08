// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiMiaoBi20230801.Models
{
    public class GetAuditNotePostProcessingStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DataNotExists</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned data.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAuditNotePostProcessingStatusResponseBodyData Data { get; set; }
        public class GetAuditNotePostProcessingStatusResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the post-processing task was completed. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01 23:34:45</para>
            /// </summary>
            [NameInMap("CompletionTime")]
            [Validation(Required=false)]
            public string CompletionTime { get; set; }

            /// <summary>
            /// <para>The time when the post-processing task was created. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1970-01-01 12:34:56</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error message. This is returned only when the post-processing task fails.</para>
            /// 
            /// <b>Example:</b>
            /// <para>error</para>
            /// </summary>
            [NameInMap("ErrorMessage")]
            [Validation(Required=false)]
            public string ErrorMessage { get; set; }

            /// <summary>
            /// <para>The ID of the rule library. The default value in the current version is &quot;Default&quot;.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Default</para>
            /// </summary>
            [NameInMap("NoteId")]
            [Validation(Required=false)]
            public string NoteId { get; set; }

            /// <summary>
            /// <para>The number of lines that have been post-processed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>233</para>
            /// </summary>
            [NameInMap("ProcessedLines")]
            [Validation(Required=false)]
            public int? ProcessedLines { get; set; }

            /// <summary>
            /// <para>The status of the post-processing task. Valid values: PENDING, RUNNING, SUCCEEDED, and FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The total number of lines in the structured rule library.</para>
            /// 
            /// <b>Example:</b>
            /// <para>666</para>
            /// </summary>
            [NameInMap("TotalLines")]
            [Validation(Required=false)]
            public int? TotalLines { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error details.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F2F366D6-E9FE-1006-BB70-2C650896AAB5</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
