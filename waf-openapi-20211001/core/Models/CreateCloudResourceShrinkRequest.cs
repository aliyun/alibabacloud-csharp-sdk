// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateCloudResourceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the WAF instance.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/433756.html">DescribeInstance</a> operation to query the ID of the WAF instance.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>waf_v3prepaid_public_cn-***</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The configurations of the listeners.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Listen")]
        [Validation(Required=false)]
        public string ListenShrink { get; set; }

        /// <summary>
        /// <para>The ID of the Alibaba Cloud account to which the resource belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("OwnerUserId")]
        [Validation(Required=false)]
        public string OwnerUserId { get; set; }

        /// <summary>
        /// <para>The configurations of the forwarding rule.</para>
        /// </summary>
        [NameInMap("Redirect")]
        [Validation(Required=false)]
        public string RedirectShrink { get; set; }

        /// <summary>
        /// <para>The region in which the WAF instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>cn-hangzhou</b>: the Chinese mainland.</description></item>
        /// <item><description><b>ap-southeast-1</b>: outside the Chinese mainland.</description></item>
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
        /// <para>The ID of the Alibaba Cloud resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm***q</para>
        /// </summary>
        [NameInMap("ResourceManagerResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceManagerResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags to add to the resource.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCloudResourceShrinkRequestTag> Tag { get; set; }
        public class CreateCloudResourceShrinkRequestTag : TeaModel {
            /// <summary>
            /// <para>The key of tag N to add to the resource. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagKey1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of tag N to add to the resource. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TagValue1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
