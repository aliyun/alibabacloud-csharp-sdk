// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribePolarClawAgentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of agents.</para>
        /// </summary>
        [NameInMap("Agents")]
        [Validation(Required=false)]
        public List<DescribePolarClawAgentsResponseBodyAgents> Agents { get; set; }
        public class DescribePolarClawAgentsResponseBodyAgents : TeaModel {
            /// <summary>
            /// <para>The agent ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The agent\&quot;s identity.</para>
            /// </summary>
            [NameInMap("Identity")]
            [Validation(Required=false)]
            public DescribePolarClawAgentsResponseBodyAgentsIdentity Identity { get; set; }
            public class DescribePolarClawAgentsResponseBodyAgentsIdentity : TeaModel {
                /// <summary>
                /// <para>The path or content of the avatar.</para>
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
                /// <para>The emoji for the identity. This can be a Unicode code point (e.g., <c>U+1F99E</c>) or an emoji character.</para>
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
                /// <para>The identity theme.</para>
                /// 
                /// <b>Example:</b>
                /// <para>space lobster</para>
                /// </summary>
                [NameInMap("Theme")]
                [Validation(Required=false)]
                public string Theme { get; set; }

            }

            /// <summary>
            /// <para>The agent display name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>main</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
        /// <para>The status code.</para>
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
        /// <para>The main agent key name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("MainKey")]
        [Validation(Required=false)]
        public string MainKey { get; set; }

        /// <summary>
        /// <para>The message.</para>
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
