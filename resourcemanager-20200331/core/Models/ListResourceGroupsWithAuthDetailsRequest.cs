// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsWithAuthDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the resource group, which is used as a filter condition for the query. Fuzzy match is supported.</para>
        /// <para>The name can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRG-BVT1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return tag information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false: does not return tag information. This is the default value.</para>
        /// </description></item>
        /// <item><description><para>true: returns tag information.</para>
        /// <remarks>
        /// <para>When you specify a tag filter condition, tag information is returned regardless of the value of <c>IncludeTags</c>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// <para>The unique identifier of the resource group, which is used as a filter condition for the query. Fuzzy match is supported.</para>
        /// <para>The identifier can be up to 50 characters in length, and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-rg</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of the resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The region ID of the resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen</para>
        /// </summary>
        [NameInMap("ResourceRegionId")]
        [Validation(Required=false)]
        public string ResourceRegionId { get; set; }

        /// <summary>
        /// <para>The resource types.</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public List<ListResourceGroupsWithAuthDetailsRequestResourceTypes> ResourceTypes { get; set; }
        public class ListResourceGroupsWithAuthDetailsRequestResourceTypes : TeaModel {
            /// <summary>
            /// <para>The resource type.</para>
            /// <para>You can obtain the value from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The code of the cloud service.</para>
            /// <para>You can obtain the value from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <para>The status of the resource group, which is used as a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The resource group is being created.</description></item>
        /// <item><description>OK: The resource group is created.</description></item>
        /// <item><description>PendingDelete: The resource group is pending deletion.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListResourceGroupsWithAuthDetailsRequestTag> Tag { get; set; }
        public class ListResourceGroupsWithAuthDetailsRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k1</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v1</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
