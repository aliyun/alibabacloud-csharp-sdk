// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID of the Service Mesh (ASM) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the ASM instances.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The resource type. Set the value to <c>servicemesh</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>servicemesh</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<TagResourcesRequestTag> Tag { get; set; }
        public class TagResourcesRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag keys.</para>
            /// <para>The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description>The key of tag N cannot be an empty string.</description></item>
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>The tag key can be up to 128 characters in length.</description></item>
            /// <item><description>The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</description></item>
            /// <item><description>The tag key cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag values.</para>
            /// <para>The following limits apply:</para>
            /// <list type="bullet">
            /// <item><description>The value of tag N cannot be an empty string.</description></item>
            /// <item><description>Valid values of N: 1 to 20.</description></item>
            /// <item><description>The tag value can be up to 128 characters in length.</description></item>
            /// <item><description>The tag value cannot contain <c>http://</c> or <c>https://</c>.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>yahaha</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
