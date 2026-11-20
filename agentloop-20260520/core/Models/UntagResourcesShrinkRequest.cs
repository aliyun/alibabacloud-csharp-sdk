// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class UntagResourcesShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all custom tags. Valid values: true, false, and an empty string. If this parameter is not specified or is set to an empty string, the value is treated as false. The value true takes effect only when the tagKey parameter is not specified or is an empty array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("all")]
        [Validation(Required=false)]
        public string All { get; set; }

        /// <summary>
        /// <para>The list of resource IDs.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>The list of tag keys to remove. You can specify up to 20 tag keys. The tag keys must be unique. If this parameter is not empty, it takes precedence over the all parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;key1&quot;, &quot;key2&quot;, &quot;key3&quot;]</para>
        /// </summary>
        [NameInMap("tagKey")]
        [Validation(Required=false)]
        public string TagKeyShrink { get; set; }

    }

}
