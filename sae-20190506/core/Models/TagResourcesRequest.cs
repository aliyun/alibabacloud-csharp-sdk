// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class TagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource IDs. You can specify up to 50 resource IDs in a JSON array. This parameter is required unless you specify the <b>Tags</b> parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;d42921c4-5433-4abd-8075-0e536f8b****&quot;]</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource type. Only <c>application</c> is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>application</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The key-value pairs of the tags. This parameter is required unless you specify the <b>ResourceIds</b> parameter. The following rules apply:</para>
        /// <list type="bullet">
        /// <item><description><para><b>key</b>: The tag key. The key must be 1 to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The tag value. The value must be 1 to 128 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>Tags are case-sensitive. If you specify multiple tags, they are created and bound to the specified resources. For a single resource, each tag key must be unique. If you specify a tag key that already exists for a resource, the operation updates the existing tag value.</para>
        /// <para>A tag key cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;key&quot;:&quot;k1&quot;,&quot;value&quot;:&quot;v1&quot;}]</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
