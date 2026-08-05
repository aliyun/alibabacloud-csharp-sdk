// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListAppConfigHistoryResponseBody : TeaModel {
        /// <summary>
        /// <para>The historical versions.</para>
        /// </summary>
        [NameInMap("History")]
        [Validation(Required=false)]
        public List<ListAppConfigHistoryResponseBodyHistory> History { get; set; }
        public class ListAppConfigHistoryResponseBodyHistory : TeaModel {
            /// <summary>
            /// <para>App ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt_check_agent_01</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The categorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guard-scene</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The configuration details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentItemConfigs&quot;: &quot;[{\&quot;agentId\&quot;:\&quot;ag.abcxxx\&quot;,\&quot;enable\&quot;:true,\&quot;name\&quot;:\&quot;Agent 1\&quot;}]&quot;}</para>
            /// </summary>
            [NameInMap("CustomConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomConfig { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The publish status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editing</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-29 10:05:27</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom text moderation</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The preset options.</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public Dictionary<string, object> Option { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_text</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plus</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785888163</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The published versions.</para>
        /// </summary>
        [NameInMap("Publish")]
        [Validation(Required=false)]
        public List<ListAppConfigHistoryResponseBodyPublish> Publish { get; set; }
        public class ListAppConfigHistoryResponseBodyPublish : TeaModel {
            /// <summary>
            /// <para>App ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt_check_agent_01</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The categorization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guard-scene</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The configuration details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentItemConfigs&quot;: &quot;[{\&quot;agentId\&quot;:\&quot;ag.abcxxx\&quot;,\&quot;enable\&quot;:true,\&quot;name\&quot;:\&quot;Agent 1\&quot;}]&quot;}</para>
            /// </summary>
            [NameInMap("CustomConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomConfig { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The publish status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editing</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-25 09:52:12</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom text moderation</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The preset options.</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public Dictionary<string, object> Option { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_text</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para><b>[Deprecated]</b> The type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>plus</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1785898163</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public long? Version { get; set; }

        }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. It can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
