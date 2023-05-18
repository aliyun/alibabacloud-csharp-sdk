// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class DeleteResourceGroupResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The information of the resource group.
        /// </summary>
        [NameInMap("ResourceGroup")]
        [Validation(Required=false)]
        public DeleteResourceGroupResponseBodyResourceGroup ResourceGroup { get; set; }
        public class DeleteResourceGroupResponseBodyResourceGroup : TeaModel {
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
            /// The unique identifier of the resource group.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The status of the resource group in all regions.
            /// </summary>
            [NameInMap("RegionStatuses")]
            [Validation(Required=false)]
            public DeleteResourceGroupResponseBodyResourceGroupRegionStatuses RegionStatuses { get; set; }
            public class DeleteResourceGroupResponseBodyResourceGroupRegionStatuses : TeaModel {
                [NameInMap("RegionStatus")]
                [Validation(Required=false)]
                public List<DeleteResourceGroupResponseBodyResourceGroupRegionStatusesRegionStatus> RegionStatus { get; set; }
                public class DeleteResourceGroupResponseBodyResourceGroupRegionStatusesRegionStatus : TeaModel {
                    /// <summary>
                    /// The region ID.
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// The status of the resource group. Valid values:
                    /// 
                    /// *   Creating: The resource group is being created.
                    /// *   OK: The resource group is created.
                    /// *   PendingDelete: The resource group is waiting to be deleted.
                    /// *   Deleting: The resource group is being deleted.
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                }

            }

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

        }

    }

}
