// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListTagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>A query can return a maximum of 50 results. If the number of results exceeds this limit, the response includes a NextToken. To retrieve the next page of results, pass this token in your next request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2RN</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource IDs, specified as a JSON array of strings. This parameter is required if the <b>Tags</b> parameter is not specified.</para>
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
        /// <para>The tags used to filter resources. This parameter is required if the <b>ResourceIds</b> parameter is not specified. A tag is a key-value pair.</para>
        /// <list type="bullet">
        /// <item><description><para><b>key</b>: The tag key. The key can be 1 to 128 characters in length.</para>
        /// </description></item>
        /// <item><description><para><b>value</b>: The tag value. The value can be 1 to 128 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <para>Tag keys and tag values are case-sensitive. If you specify multiple tags, the operation returns only resources that have all the specified tags.</para>
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
