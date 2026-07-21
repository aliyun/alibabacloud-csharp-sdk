// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AITeacherSyncPracticeTaskGenerateResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object that contains the generated content.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AITeacherSyncPracticeTaskGenerateResponseBodyData Data { get; set; }
        public class AITeacherSyncPracticeTaskGenerateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>An array of Q\&amp;A pairs representing the dialogue task.</para>
            /// </summary>
            [NameInMap("taskContent")]
            [Validation(Required=false)]
            public List<AITeacherSyncPracticeTaskGenerateResponseBodyDataTaskContent> TaskContent { get; set; }
            public class AITeacherSyncPracticeTaskGenerateResponseBodyDataTaskContent : TeaModel {
                /// <summary>
                /// <para>The AI assistant\&quot;s question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Why might some people think dog walking is a great job?</para>
                /// </summary>
                [NameInMap("assistant")]
                [Validation(Required=false)]
                public string Assistant { get; set; }

                /// <summary>
                /// <para>The expected user answer to the assistant\&quot;s question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>They think it\&quot;s great because they won\&quot;t be stuck in an office.</para>
                /// </summary>
                [NameInMap("user")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>textbook_question_answering</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message returned if the request fails.</para>
        /// 
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

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
        /// <para>The unique request ID, used for troubleshooting.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
