// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AiContent20240611.Models
{
    public class AITeacherExpansionPracticeTaskGenerateResponseBody : TeaModel {
        [NameInMap("data")]
        [Validation(Required=false)]
        public AITeacherExpansionPracticeTaskGenerateResponseBodyData Data { get; set; }
        public class AITeacherExpansionPracticeTaskGenerateResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>In a career counseling session, we are going to discuss our dream jobs and the responsibilities associated with them. Alex, who dreams of becoming a professional travel blogger, will share the tasks and skills required for this role, while Jamie, aspiring to be a wildlife photographer, will outline the responsibilities and challenges of capturing nature\&quot;s moments. Both will explore how their interests align with the practical aspects of their chosen careers, discussing the potential for travel, creativity, and the impact of their work on society and the environment.</para>
            /// </summary>
            [NameInMap("backgroundDescription")]
            [Validation(Required=false)]
            public string BackgroundDescription { get; set; }

            [NameInMap("roleSet")]
            [Validation(Required=false)]
            public AITeacherExpansionPracticeTaskGenerateResponseBodyDataRoleSet RoleSet { get; set; }
            public class AITeacherExpansionPracticeTaskGenerateResponseBodyDataRoleSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>Alex</para>
                /// </summary>
                [NameInMap("assistant")]
                [Validation(Required=false)]
                public string Assistant { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Jamie</para>
                /// </summary>
                [NameInMap("user")]
                [Validation(Required=false)]
                public string User { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Hey Jamie, do you know what a travel blogger does?</para>
            /// </summary>
            [NameInMap("startSentence")]
            [Validation(Required=false)]
            public string StartSentence { get; set; }

            [NameInMap("taskContent")]
            [Validation(Required=false)]
            public List<AITeacherExpansionPracticeTaskGenerateResponseBodyDataTaskContent> TaskContent { get; set; }
            public class AITeacherExpansionPracticeTaskGenerateResponseBodyDataTaskContent : TeaModel {
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
            /// <para>textbook_dialogue</para>
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
