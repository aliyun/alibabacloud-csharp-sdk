// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIRegistry20260317.Models
{
    public class GetNamespaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The namespace information.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetNamespaceResponseBodyData Data { get; set; }
        public class GetNamespaceResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The time when the namespace was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-11-17T09:57:38+08:00</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            /// <summary>
            /// <para>The description of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>secret for bbtadmin</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IpWhitelist")]
            [Validation(Required=false)]
            public string IpWhitelist { get; set; }

            /// <summary>
            /// <para>The namespace name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>magic:magic-cn-1us4sed5d01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The namespace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>a2a9310a-9d91-4283-b4e2-844f6d45fe64</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The number of prompts in the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PromptCount")]
            [Validation(Required=false)]
            public int? PromptCount { get; set; }

            [NameInMap("PublicAccessEnabled")]
            [Validation(Required=false)]
            public bool? PublicAccessEnabled { get; set; }

            [NameInMap("PublicDomain")]
            [Validation(Required=false)]
            public string PublicDomain { get; set; }

            /// <summary>
            /// <para>The scan policy.</para>
            /// <para>The policy contains two configuration items:</para>
            /// <list type="bullet">
            /// <item><description>minBlockRiskLevel: the risk level for blocking.<list type="bullet">
            /// <item><description>high: blocks high-risk items.</description></item>
            /// <item><description>medium: blocks medium- and high-risk items.</description></item>
            /// <item><description>low: blocks all risk levels including high, medium, and low.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description>maxSkipRatio: the maximum skip ratio. If the scan skip ratio exceeds this value, the scan is considered as failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;minBlockRiskLevel&quot;:&quot;medium&quot;,&quot;maxSkipRatio&quot;:0.2}</para>
            /// </summary>
            [NameInMap("ScanPolicy")]
            [Validation(Required=false)]
            public string ScanPolicy { get; set; }

            /// <summary>
            /// <para>The number of skills in the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SkillCount")]
            [Validation(Required=false)]
            public int? SkillCount { get; set; }

            /// <summary>
            /// <para>The source of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>magic:magic-cn-1us4sed5d01</para>
            /// </summary>
            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The source ordinal number of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("SourceIndex")]
            [Validation(Required=false)]
            public int? SourceIndex { get; set; }

            /// <summary>
            /// <para>The tags of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public string Tags { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9E87E66-9EF0-5C10-A5E6-924020A0C9B7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
