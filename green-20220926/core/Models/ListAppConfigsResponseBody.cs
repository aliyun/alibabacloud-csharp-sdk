// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class ListAppConfigsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAppConfigsResponseBodyData> Data { get; set; }
        public class ListAppConfigsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>App ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>txt_check_pro_agent_01</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The classification.</para>
            /// 
            /// <b>Example:</b>
            /// <para>guard-scene</para>
            /// </summary>
            [NameInMap("Classify")]
            [Validation(Required=false)]
            public string Classify { get; set; }

            /// <summary>
            /// <para>The configuration details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;agentItemConfigs&quot;: &quot;[{\&quot;agentId\&quot;:\&quot;ag.abcxxx\&quot;,\&quot;enable\&quot;:true,\&quot;name\&quot;:\&quot;Agent 1\&quot;}]&quot;}</para>
            /// </summary>
            [NameInMap("CustomConfig")]
            [Validation(Required=false)]
            public Dictionary<string, object> CustomConfig { get; set; }

            /// <summary>
            /// <para>The publish status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>editing</para>
            /// </summary>
            [NameInMap("DeployStatus")]
            [Validation(Required=false)]
            public string DeployStatus { get; set; }

            /// <summary>
            /// <para>The last modification time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-06-15 10:17:49</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Custom text moderation</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The preset options.</para>
            /// </summary>
            [NameInMap("Option")]
            [Validation(Required=false)]
            public Dictionary<string, object> Option { get; set; }

            /// <summary>
            /// <para>The resource type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_text</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The type.</para>
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
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
