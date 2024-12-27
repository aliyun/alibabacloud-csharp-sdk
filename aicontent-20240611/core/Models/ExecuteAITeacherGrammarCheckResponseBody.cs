// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class ExecuteAITeacherGrammarCheckResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ExecuteAITeacherGrammarCheckResponseBodyData Data { get; set; }
        public class ExecuteAITeacherGrammarCheckResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>主语 &quot;I&quot; 对应的动词应该是 &quot;am&quot; 而不是 &quot;is&quot;。</para>
            /// </summary>
            [NameInMap("analysis")]
            [Validation(Required=false)]
            public string Analysis { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>I am good.</para>
            /// </summary>
            [NameInMap("correction")]
            [Validation(Required=false)]
            public string Correction { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Has_Error</para>
            /// </summary>
            [NameInMap("correctionStatus")]
            [Validation(Required=false)]
            public string CorrectionStatus { get; set; }

            [NameInMap("errorReason")]
            [Validation(Required=false)]
            public string ErrorReason { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>未知错误</para>
        /// </summary>
        [NameInMap("errMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
