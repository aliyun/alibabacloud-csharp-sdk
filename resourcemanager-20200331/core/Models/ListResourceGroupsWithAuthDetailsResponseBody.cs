// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsWithAuthDetailsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of authorization details for resource groups.</para>
        /// </summary>
        [NameInMap("AuthDetails")]
        [Validation(Required=false)]
        public List<ListResourceGroupsWithAuthDetailsResponseBodyAuthDetails> AuthDetails { get; set; }
        public class ListResourceGroupsWithAuthDetailsResponseBodyAuthDetails : TeaModel {
            /// <summary>
            /// <para>Indicates whether the user has account-level authorization for the resource type.</para>
            /// </summary>
            [NameInMap("AccountScopeAuth")]
            [Validation(Required=false)]
            public bool? AccountScopeAuth { get; set; }

            /// <summary>
            /// <para>The permissions of resource groups on the resource type.</para>
            /// </summary>
            [NameInMap("AuthOfResourceGroups")]
            [Validation(Required=false)]
            public List<ListResourceGroupsWithAuthDetailsResponseBodyAuthDetailsAuthOfResourceGroups> AuthOfResourceGroups { get; set; }
            public class ListResourceGroupsWithAuthDetailsResponseBodyAuthDetailsAuthOfResourceGroups : TeaModel {
                /// <summary>
                /// <para>Indicates whether the resource group has permissions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("HasPermission")]
                [Validation(Required=false)]
                public bool? HasPermission { get; set; }

                /// <summary>
                /// <para>The resource group ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-aekzscexx6w3u2y</para>
                /// </summary>
                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

            }

            /// <summary>
            /// <para>The resource type.</para>
            /// <para>You can obtain the resource type from the <b>Resource Type</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The cloud service ID.</para>
            /// <para>You can obtain the cloud service ID from the <b>Cloud Service Code</b> column in <a href="https://help.aliyun.com/document_detail/94479.html">Cloud services that support resource groups</a>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4141780B-4E3D-5D2A-A8F4-44D6D34F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public List<ListResourceGroupsWithAuthDetailsResponseBodyResourceGroups> ResourceGroups { get; set; }
        public class ListResourceGroupsWithAuthDetailsResponseBodyResourceGroups : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID to which the resource group belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456789****</para>
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// <para>The time when the resource group was created (UTC).</para>
            /// 
            /// <b>Example:</b>
            /// <para>2015-01-23T12:33:18Z</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The display name of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-9gLOoK****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The unique identifier of the resource group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>my-project</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the resource group. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: Being created.</description></item>
            /// <item><description>OK: Created.</description></item>
            /// <item><description>PendingDelete: Pending deletion.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>OK</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListResourceGroupsWithAuthDetailsResponseBodyResourceGroupsTags> Tags { get; set; }
            public class ListResourceGroupsWithAuthDetailsResponseBodyResourceGroupsTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k1</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v1</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

        }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
