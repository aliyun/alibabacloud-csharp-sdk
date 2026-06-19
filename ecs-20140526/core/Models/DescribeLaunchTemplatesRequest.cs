// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>An array of one or more launch template IDs.</para>
        /// <list type="bullet">
        /// <item><description><para>You can query up to 100 launch templates at a time.</para>
        /// </description></item>
        /// <item><description><para>You must specify LaunchTemplateId or LaunchTemplateName to determine the templates.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7q****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public List<string> LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>An array of one or more launch template names.</para>
        /// <list type="bullet">
        /// <item><description><para>You can query up to 100 launch templates at a time.</para>
        /// </description></item>
        /// <item><description><para>You must specify LaunchTemplateId or LaunchTemplateName to determine the templates.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>wd-152630748****</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public List<string> LaunchTemplateName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number of the launch template list. Minimum value: 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page for a paginated query.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the launch template belongs. When you use this parameter to filter resources, the number of resources cannot exceed 1000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4p****</para>
        /// </summary>
        [NameInMap("TemplateResourceGroupId")]
        [Validation(Required=false)]
        public string TemplateResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of tag key-value pairs of the launch template.</para>
        /// <remarks>
        /// <para>Currently, you can create and query launch template tags only by calling API operations. The console does not support creating or viewing launch template tags.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public List<DescribeLaunchTemplatesRequestTemplateTag> TemplateTag { get; set; }
        public class DescribeLaunchTemplatesRequestTemplateTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the launch template. Valid values of N: 1 to 20.</para>
            /// <para>If you use a single tag to filter resources, the number of resources with the specified tag cannot exceed 1000. If you use multiple tags to filter resources, the number of resources that are bound with all the specified tags cannot exceed 1000. If the number of resources exceeds 1000, call the <a href="https://help.aliyun.com/document_detail/110425.html">ListTagResources</a> operation to query them.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the launch template. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
