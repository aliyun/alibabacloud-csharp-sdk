// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsRequest : TeaModel {
        /// <summary>
        /// <para>The display name of the resource group. This parameter specifies a filter condition for the query. Fuzzy match is supported.</para>
        /// <para>The display name can be a maximum of 50 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("DisplayName")]
        [Validation(Required=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the information of tags. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false (default value)</description></item>
        /// <item><description>true</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you configure the Tag parameter, the system returns the information of tags regardless of the setting of the <c>IncludeTags</c> parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IncludeTags")]
        [Validation(Required=false)]
        public bool? IncludeTags { get; set; }

        /// <summary>
        /// <para>The identifier of the resource group. This parameter specifies a filter condition for the query. Fuzzy match is supported.</para>
        /// <para>The identifier can be a maximum of 50 characters in length and can contain letters, digits, and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-project</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1. Default value: 1.</para>
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
        /// <para>The ID of the resource group. This parameter specifies a filter condition for the query.</para>
        /// <para>The ID can be a maximum of 18 characters in length and must start with <c>rg-</c>.</para>
        /// <remarks>
        /// <para> This parameter is incorporated into the <c>ResourceGroupIds</c> parameter. If you configure both the <c>ResourceGroupId</c> and <c>ResourceGroupIds</c> parameters, the value of the <c>ResourceGroupIds</c> parameter prevails.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>rg-9gLOoK****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the resource groups. This parameter specifies a filter condition for the query.</para>
        /// <para>You can specify a maximum of 100 resource group IDs.</para>
        /// <remarks>
        /// <para> If you configure both the <c>ResourceGroupId</c> and <c>ResourceGroupIds</c> parameters, the value of the <c>ResourceGroupIds</c> parameter prevails.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("ResourceGroupIds")]
        [Validation(Required=false)]
        public List<string> ResourceGroupIds { get; set; }

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
        /// <para>The tag. This parameter specifies a filter condition for the query.</para>
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
