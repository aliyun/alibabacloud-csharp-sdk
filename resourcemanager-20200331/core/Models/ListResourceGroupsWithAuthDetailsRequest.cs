// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsWithAuthDetailsRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the resource group. This parameter specifies a filter condition for the query. Fuzzy search is supported.</para>
        /// <para>The display name can be a maximum of 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRG-BVT1</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the information of tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default)</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set a tag filter condition, the tag information is returned regardless of the <c>IncludeTags</c> value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// <para>The identifier of the resource group. This parameter specifies a filter condition for the query. Fuzzy search is supported.</para>
        /// <para>The identifier can be a maximum of 50 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-rg</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The IDs of the resource groups that you want to query.</para>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The ID of the region where the resource resides.</para>
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
            /// <para>You can obtain the resource type from the <b>Resource type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceTypeCode")]
            [Validation(Required=false)]
            public string ResourceTypeCode { get; set; }

            /// <summary>
            /// <para>The service code.</para>
            /// <para>You can obtain the code from the <b>Service code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Services that work with Resource Group</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <para>The status of the resource group. This parameter specifies a filter condition for the query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Creating: The resource group is being created.</description></item>
        /// <item><description>OK: The resource group is created.</description></item>
        /// <item><description>PendingDelete: The resource group is waiting to be deleted.</description></item>
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
