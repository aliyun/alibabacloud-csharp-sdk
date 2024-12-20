// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AITeacherSyncPracticeTaskGenerateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public AITeacherSyncPracticeTaskGenerateResponseBodyData Data { get; set; }
        public class AITeacherSyncPracticeTaskGenerateResponseBodyData : TeaModel {
            [NameInMap("taskContent")]
            [Validation(Required=false)]
            public List<AITeacherSyncPracticeTaskGenerateResponseBodyDataTaskContent> TaskContent { get; set; }
            public class AITeacherSyncPracticeTaskGenerateResponseBodyDataTaskContent : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Why might some people think dog walking is a great job?</para>
                /// </summary>
                [NameInMap("assistant")]
                [Validation(Required=false)]
                public string Assistant { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>They think it\&quot;s great because they won\&quot;t be stuck in an office.</para>
                /// </summary>
                [NameInMap("user")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>textbook_question_answering</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

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
