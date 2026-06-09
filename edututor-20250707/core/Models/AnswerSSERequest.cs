// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EduTutor20250707.Models
{
    public class AnswerSSERequest : TeaModel {
        [NameInMap("messages")]
        [Validation(Required=false)]
        public List<AnswerSSERequestMessages> Messages { get; set; }
        public class AnswerSSERequestMessages : TeaModel {
            [NameInMap("content")]
            [Validation(Required=false)]
            public List<Dictionary<string, string>> Content { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

        [NameInMap("parameters")]
        [Validation(Required=false)]
        public AnswerSSERequestParameters Parameters { get; set; }
        public class AnswerSSERequestParameters : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>6</para>
            /// </summary>
            [NameInMap("grade")]
            [Validation(Required=false)]
            public int? Grade { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>other</para>
            /// </summary>
            [NameInMap("stage")]
            [Validation(Required=false)]
            public string Stage { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>other</para>
            /// </summary>
            [NameInMap("subject")]
            [Validation(Required=false)]
            public string Subject { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>llm-1ijrzuv3v0ivvls7</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
