// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataphin_public20230630.Models
{
    public class GetAdHocTaskLogResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code. A value of OK indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned by the backend.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The log details.</para>
        /// </summary>
        [NameInMap("LogInfo")]
        [Validation(Required=false)]
        public GetAdHocTaskLogResponseBodyLogInfo LogInfo { get; set; }
        public class GetAdHocTaskLogResponseBodyLogInfo : TeaModel {
            /// <summary>
            /// <para>The runtime log content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>Indicates whether the next log entry exists.</para>
            /// </summary>
            [NameInMap("HasNext")]
            [Validation(Required=false)]
            public bool? HasNext { get; set; }

            /// <summary>
            /// <para>Indicates whether the current query produces a result.</para>
            /// </summary>
            [NameInMap("HasResult")]
            [Validation(Required=false)]
            public bool? HasResult { get; set; }

            /// <summary>
            /// <para>The start position of the next log entry.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021</para>
            /// </summary>
            [NameInMap("NextOffset")]
            [Validation(Required=false)]
            public int? NextOffset { get; set; }

            /// <summary>
            /// <para>The subtask ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SubTaskId")]
            [Validation(Required=false)]
            public int? SubTaskId { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MaxCompute_SQL_300000843_1611548758327</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task running status. Example: WAIT_RESOURCE indicates that the task is waiting for resources.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAIT_RESOURCE</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>75DD06F8-1661-5A6E-B0A6-7E23133BDC60</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
