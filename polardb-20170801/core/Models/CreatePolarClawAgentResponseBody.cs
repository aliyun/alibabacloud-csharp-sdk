// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class CreatePolarClawAgentResponseBody : TeaModel {
        [NameInMap("Agent")]
        [Validation(Required=false)]
        public CreatePolarClawAgentResponseBodyAgent Agent { get; set; }
        public class CreatePolarClawAgentResponseBodyAgent : TeaModel {
            /// <summary>
            /// <para>Agent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>work</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public CreatePolarClawAgentResponseBodyAgentIdentity Identity { get; set; }
            public class CreatePolarClawAgentResponseBodyAgentIdentity : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>U+1F99E</para>
                /// </summary>
                [NameInMap("Emoji")]
                [Validation(Required=false)]
                public string Emoji { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>work</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>work</para>
                /// </summary>
                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>work</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/workspace-work</para>
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>Agent ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("AgentId")]
        [Validation(Required=false)]
        public string AgentId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>work</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>3E5CD764-FCCA-5C9C-838E-20E0DE84B2AF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/home/node/.openclaw/workspace-work</para>
        /// </summary>
        [NameInMap("Workspace")]
        [Validation(Required=false)]
        public string Workspace { get; set; }

    }

}
