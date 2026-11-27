// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the resource group, used as a filter condition for the query. Fuzzy match is supported.</para>
        /// <para>The value can be up to 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return tag information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Tag information is not returned.</para>
        /// </description></item>
        /// <item><description><para>true: Tag information is returned.</para>
        /// <remarks>
        /// <para>If you specify a tag filter condition, tag information is returned regardless of the value of IncludeTags.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// <para>The unique identifier of the resource group, used as a filter condition for the query. Fuzzy match is supported.</para>
        /// <para>The value can be up to 50 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Starting value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the resource group, used as a filter condition for the query.</para>
        /// <para>The value can be up to 18 characters in length and must start with rg-.</para>
        /// <remarks>
        /// <para>This parameter is incorporated into the ResourceGroupIds parameter. If you specify both ResourceGroupId and ResourceGroupIds, ResourceGroupIds takes precedence.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-9gLOoK****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The list of resource group IDs, used as filter conditions for the query.</para>
        /// <para>You can specify up to 100 resource group IDs.</para>
        /// <remarks>
        /// <para>If you specify both ResourceGroupId and ResourceGroupIds, ResourceGroupIds takes precedence.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

        /// <summary>
        /// <para>The status of the resource group, used as a filter condition for the query. Valid values:</para>
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
        /// <para>The tags, used as filter conditions for the query.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<ListResourceGroupsRequestTag> Tag { get; set; }
        public class ListResourceGroupsRequestTag : TeaModel {
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
