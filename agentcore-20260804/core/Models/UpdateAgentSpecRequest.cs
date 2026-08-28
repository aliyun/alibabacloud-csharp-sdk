// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentCore20260804.Models
{
    public class UpdateAgentSpecRequest : TeaModel {
        /// <summary>
        /// <para>The request body.</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public UpdateAgentSpecRequestBody Body { get; set; }
        public class UpdateAgentSpecRequestBody : TeaModel {
            /// <summary>
            /// <para>The business tags as a JSON-formatted string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;ai&quot;,&quot;agent&quot;]</para>
            /// </summary>
            [NameInMap("bizTags")]
            [Validation(Required=false)]
            public string BizTags { get; set; }

            /// <summary>
            /// <para>The label mapping as a JSON-formatted string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;latest&quot;:&quot;0.0.1&quot;}</para>
            /// </summary>
            [NameInMap("labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>The visibility scope. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC</description></item>
            /// <item><description>PRIVATE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("scope")]
            [Validation(Required=false)]
            public string Scope { get; set; }

        }

    }

}
