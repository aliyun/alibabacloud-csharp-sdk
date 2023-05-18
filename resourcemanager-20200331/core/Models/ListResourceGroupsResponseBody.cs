// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListResourceGroupsResponseBody : TeaModel {
        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resource groups.
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
                /// The ID of the Alibaba Cloud account to which the resource group belongs.
                /// </summary>
                [NameInMap("AccountId")]
                [Validation(Required=false)]
                public string AccountId { get; set; }

                /// <summary>
                /// The time when the resource group was created. The time is displayed in UTC.
                /// </summary>
                [NameInMap("CreateDate")]
                [Validation(Required=false)]
                public string CreateDate { get; set; }

                /// <summary>
                /// The display name of the resource group.
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// The ID of the resource group.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// The identifier of the resource group.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The status of the resource group. Valid values:
                /// 
                /// *   Creating: The resource group is being created.
                /// *   OK: The resource group is created.
                /// *   PendingDelete: The resource group is waiting to be deleted.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// The tags that are added to the resource group.
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
                        /// The tag key.
                        /// </summary>
                        [NameInMap("TagKey")]
                        [Validation(Required=false)]
                        public string TagKey { get; set; }

                        /// <summary>
                        /// The tag value.
                        /// </summary>
                        [NameInMap("TagValue")]
                        [Validation(Required=false)]
                        public string TagValue { get; set; }

                    }

                }

            }

        }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
