// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The list of resource IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;space-a&quot;,&quot;space-b&quot;]</para>
        /// </summary>
        [NameInMap("resourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

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
        /// <para>The list of tags. Up to 20 tag key-value pairs are supported at a time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{
        ///     &quot;key&quot;: &quot;key1&quot;,
        ///     &quot;value&quot;: &quot;value1&quot;
        /// }]</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Format requirements:</para>
            /// <list type="bullet">
            /// <item><description>The length must be 1 to 128 characters.</description></item>
            /// <item><description>The key cannot contain &quot;http://&quot; or &quot;https://&quot;.</description></item>
            /// <item><description>The key cannot start with &quot;acs:&quot; or &quot;aliyun&quot;.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>key1</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Format requirements:</para>
            /// <list type="bullet">
            /// <item><description>The length must be 1 to 128 characters.</description></item>
            /// <item><description>The value cannot contain &quot;http://&quot; or &quot;https://&quot;.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>value1</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
