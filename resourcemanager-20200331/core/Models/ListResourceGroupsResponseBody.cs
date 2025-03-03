// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4B450CA1-36E8-4AA2-8461-86B42BF4CC4E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The information of the resource groups.</para>
        /// </summary>
        [NameInMap("ResourceGroups")]
        [Validation(Required=false)]
        public ListResourceGroupsResponseBodyResourceGroups ResourceGroups { get; set; }
        public class ListResourceGroupsResponseBodyResourceGroups : TeaModel {
            [NameInMap("ResourceGroup")]
            [Validation(Required=false)]
            public List<ListResourceGroupsResponseBodyResourceGroupsResourceGroup> ResourceGroup { get; set; }
            public class ListResourceGroupsResponseBodyResourceGroupsResourceGroup : TeaModel {
                /// <summary>
                /// <para>The ID of the Alibaba Cloud account to which the resource group belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123456789****</para>
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// <para>The time when the resource group was created. The time is displayed in UTC.</para>
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
                /// <para>The ID of the resource group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>rg-9gLOoK****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The identifier of the resource group.</para>
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
                /// <para>The tags that are added to the resource group.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public ListResourceGroupsResponseBodyResourceGroupsResourceGroupTags Tags { get; set; }
                public class ListResourceGroupsResponseBodyResourceGroupsResourceGroupTags : TeaModel {
                    [NameInMap("Tag")]
                    [Validation(Required=false)]
                    public List<ListResourceGroupsResponseBodyResourceGroupsResourceGroupTagsTag> Tag { get; set; }
                    public class ListResourceGroupsResponseBodyResourceGroupsResourceGroupTagsTag : TeaModel {
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

            }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
