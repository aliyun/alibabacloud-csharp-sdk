// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class ListTagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The pagination token. An empty value indicates that no additional pages exist.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eyJuZXh0IjoiNDAifQ==</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of resource IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;space-a&quot;,&quot;space-b&quot;]</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public string ResourceIdShrink { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to agentspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>agentspace</para>
        /// </summary>
        [NameInMap("resourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tag filter conditions. Multiple conditions are combined with the AND operator. At least one of resourceId and tag must be specified.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string TagShrink { get; set; }

    }

}
