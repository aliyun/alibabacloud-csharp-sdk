// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class UntagResourcesRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to remove all tags from resources. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false (default)</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when you specify an empty tag key.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("All")]
        [Validation(Required=false)]
        public bool? All { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/601478.html">DescribeRegions</a> operation to query the most recent region list.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The IDs of the resources from which you want to remove tags. You can enter up to 50 resource IDs.</para>
        /// <para>Enter multiple resource IDs in the <c>[&quot;ResourceId.1&quot;,&quot;ResourceId.2&quot;,...]</c> format.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ResourceId")]
        [Validation(Required=false)]
        public List<string> ResourceId { get; set; }

        /// <summary>
        /// <para>The type of the resource from which you want to remove tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>key</description></item>
        /// <item><description>secret</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The keys of the tags that you want to remove. You can enter up to 20 tag keys.</para>
        /// <para>Enter multiple tag keys in the <c>[&quot;key.1&quot;,&quot;key.2&quot;,...]</c> format.</para>
        /// <remarks>
        /// <para> The tag key cannot start with aliyun or acs:.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TagKey")]
        [Validation(Required=false)]
        public List<string> TagKey { get; set; }

    }

}
