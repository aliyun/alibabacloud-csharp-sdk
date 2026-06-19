// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeImageComponentsRequest : TeaModel {
        /// <summary>
        /// <para>The component type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Build</description></item>
        /// <item><description>Test.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Build</para>
        /// </summary>
        [NameInMap("ComponentType")]
        [Validation(Required=false)]
        public string ComponentType { get; set; }

        /// <summary>
        /// <para>The component version number in the format of major.minor.patch. All values are non-negative integers. You can also use the wildcard character (*) to replace one of the values for fuzzy matching.</para>
        /// <remarks>
        /// <para>This parameter takes effect only when Name is specified.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1.0.*</para>
        /// </summary>
        [NameInMap("ComponentVersion")]
        [Validation(Required=false)]
        public string ComponentVersion { get; set; }

        /// <summary>
        /// <para>The ID of the image component to query. Valid values of N: 1 to 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ic-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ImageComponentId")]
        [Validation(Required=false)]
        public List<string> ImageComponentId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for paging. Valid values: 1 to 500.</para>
        /// <para>Default value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The image component name. Only exact match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testComponent</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this parameter to the value of <c>NextToken</c> returned in the previous call. You do not need to set this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The image component type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SELF: custom image components that you created.</description></item>
        /// <item><description>ALIYUN: system components provided by Alibaba Cloud.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SELF</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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

        /// <summary>
        /// <para>The resource group ID. If you use this parameter to filter resources, the resource count cannot exceed 1000.</para>
        /// <remarks>
        /// <para>Filtering by the default resource group is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-bp67acfmxazb4p****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The operating system supported by the component.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Linux</description></item>
        /// <item><description>Windows.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Linux</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public string SystemType { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeImageComponentsRequestTag> Tag { get; set; }
        public class DescribeImageComponentsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. Valid values of N: 1 to 20.</para>
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
