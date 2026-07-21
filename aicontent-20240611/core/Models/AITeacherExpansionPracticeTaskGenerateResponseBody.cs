// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AITeacherExpansionPracticeTaskGenerateResponseBody : TeaModel {
        /// <summary>
        /// <para>The data object.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public AITeacherExpansionPracticeTaskGenerateResponseBodyData Data { get; set; }
        public class AITeacherExpansionPracticeTaskGenerateResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The background of the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>In a career counseling session, we are going to discuss our dream jobs and the responsibilities associated with them. Alex, who dreams of becoming a professional travel blogger, will share the tasks and skills required for this role, while Jamie, aspiring to be a wildlife photographer, will outline the responsibilities and challenges of capturing nature\&quot;s moments. Both will explore how their interests align with the practical aspects of their chosen careers, discussing the potential for travel, creativity, and the impact of their work on society and the environment.</para>
            /// </summary>
            [NameInMap("backgroundDescription")]
            [Validation(Required=false)]
            public string BackgroundDescription { get; set; }

            /// <summary>
            /// <para>The role settings.</para>
            /// </summary>
            [NameInMap("roleSet")]
            [Validation(Required=false)]
            public AITeacherExpansionPracticeTaskGenerateResponseBodyDataRoleSet RoleSet { get; set; }
            public class AITeacherExpansionPracticeTaskGenerateResponseBodyDataRoleSet : TeaModel {
                /// <summary>
                /// <para>The name of the AI teacher.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Alex</para>
                /// </summary>
                [NameInMap("assistant")]
                [Validation(Required=false)]
                public string Assistant { get; set; }

                /// <summary>
                /// <para>The name of the student.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Jamie</para>
                /// </summary>
                [NameInMap("user")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <para>The opening sentence of the conversation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hey Jamie, do you know what a travel blogger does?</para>
            /// </summary>
            [NameInMap("startSentence")]
            [Validation(Required=false)]
            public string StartSentence { get; set; }

            /// <summary>
            /// <para>A list of Q\&amp;A pairs.</para>
            /// </summary>
            [NameInMap("taskContent")]
            [Validation(Required=false)]
            public List<AITeacherExpansionPracticeTaskGenerateResponseBodyDataTaskContent> TaskContent { get; set; }
            public class AITeacherExpansionPracticeTaskGenerateResponseBodyDataTaskContent : TeaModel {
                /// <summary>
                /// <para>The AI teacher\&quot;s question.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Why might some people think dog walking is a great job?</para>
                /// </summary>
                [NameInMap("assistant")]
                [Validation(Required=false)]
                public string Assistant { get; set; }

                /// <summary>
                /// <para>The student\&quot;s answer.</para>
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
            /// <para>textbook_dialogue</para>
            /// </summary>
            [NameInMap("taskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>UNKNOWN_ERROR</para>
        /// </summary>
        [NameInMap("errCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxxx-xxxx-xxxxxxxx</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates if the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
