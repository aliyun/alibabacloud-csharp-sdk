// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The agent list.</para>
        /// </summary>
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public List<DescribePolarClawAgentsResponseBodyAgents> Agents { get; set; }
        public class DescribePolarClawAgentsResponseBodyAgents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Default")]
            [Validation(Required=false)]
            public bool? Default { get; set; }

            [NameInMap("Files")]
            [Validation(Required=false)]
            public List<DescribePolarClawAgentsResponseBodyAgentsFiles> Files { get; set; }
            public class DescribePolarClawAgentsResponseBodyAgentsFiles : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Missing")]
                [Validation(Required=false)]
                public bool? Missing { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>SOUL.md</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>/home/node/.openclaw/workspace-work/SOUL.md</para>
                /// </summary>
                [NameInMap("Path")]
                [Validation(Required=false)]
                public string Path { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1024</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public long? Size { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1716000000000</para>
                /// </summary>
                [NameInMap("UpdatedAtMs")]
                [Validation(Required=false)]
                public long? UpdatedAtMs { get; set; }

            }

            /// <summary>
            /// <para>Agent ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The identity information.</para>
            /// </summary>
            [NameInMap("Identity")]
            [Validation(Required=false)]
            public DescribePolarClawAgentsResponseBodyAgentsIdentity Identity { get; set; }
            public class DescribePolarClawAgentsResponseBodyAgentsIdentity : TeaModel {
                /// <summary>
                /// <para>The avatar path or content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Avatar")]
                [Validation(Required=false)]
                public string Avatar { get; set; }

                /// <summary>
                /// <para>The avatar URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("AvatarUrl")]
                [Validation(Required=false)]
                public string AvatarUrl { get; set; }

                /// <summary>
                /// <para>The emoji identifier in Unicode encoding format such as U+1F99E, or a direct emoji character.</para>
                /// 
                /// <b>Example:</b>
                /// <para>U+1F99E</para>
                /// </summary>
                [NameInMap("Emoji")]
                [Validation(Required=false)]
                public string Emoji { get; set; }

                /// <summary>
                /// <para>The identity name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>PolarClaw</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The theme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>space lobster</para>
                /// </summary>
                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            [NameInMap("Model")]
            [Validation(Required=false)]
            public DescribePolarClawAgentsResponseBodyAgentsModel Model { get; set; }
            public class DescribePolarClawAgentsResponseBodyAgentsModel : TeaModel {
                [NameInMap("Fallbacks")]
                [Validation(Required=false)]
                public List<string> Fallbacks { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>claude-sonnet-4-5</para>
                /// </summary>
                [NameInMap("Primary")]
                [Validation(Required=false)]
                public string Primary { get; set; }

            }

            /// <summary>
            /// <para>The display name of the agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<string> Skills { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/home/node/.openclaw/workspace-work</para>
            /// </summary>
            [NameInMap("Workspace")]
            [Validation(Required=false)]
            public string Workspace { get; set; }

        }

        /// <summary>
        /// <para>The application ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pa-**************</para>
        /// </summary>
        [NameInMap("ApplicationId")]
        [Validation(Required=false)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The default agent ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("DefaultId")]
        [Validation(Required=false)]
        public string DefaultId { get; set; }

        /// <summary>
        /// <para>The primary agent key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("MainKey")]
        [Validation(Required=false)]
        public string MainKey { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>24A1990B-4F6E-482B-B8CB-75C612******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The routing scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>per-sender</para>
        /// </summary>
        [NameInMap("Scope")]
        [Validation(Required=false)]
        public string Scope { get; set; }

    }

}
