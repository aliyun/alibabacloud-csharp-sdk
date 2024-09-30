// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Tag20180828.Models
{
    public class TagResourcesRequest : TeaModel {
        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <list type="bullet">
        /// <item><description>If the resources belong to a service that is centrally deployed, set the value to <c>cn-hangzhou</c> or to the region ID of the resources by referring to <a href="https://help.aliyun.com/document_detail/2579691.html">Regions supported by tag-related operations on resources of centrally deployed Alibaba Cloud services</a>.</description></item>
        /// <item><description>If the resources belong to a service that is not centrally deployed, set the value to the region ID of the resources.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud Resource Name (ARN) of a resource.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>arn:acs:vpc:cn-hangzhou:123456789****:vpc/vpc-bp19dd90tkt6tz7wu****</para>
        /// </summary>
        [NameInMap("ResourceARN")]
        [Validation(Required=false)]
        public List<string> ResourceARN { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The key-value pairs of tags. You can specify 1 to 10 key-value pairs.</para>
        /// <para>If you specify multiple tags, the system adds all the tags to the specified resources.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>A tag key must be 1 to 128 characters in length.</description></item>
        /// <item><description>A tag value must be 1 to 128 characters in length.</description></item>
        /// <item><description>Tag keys and tag values are case-sensitive.</description></item>
        /// <item><description>Each tag key on a resource can have only one tag value. If you create a tag that has the same key as an existing tag, the value of the existing tag is overwritten.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v1&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

    }

}
