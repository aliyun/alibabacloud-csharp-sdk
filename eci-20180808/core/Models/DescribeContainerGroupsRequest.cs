// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eci20180808.Models
{
    public class DescribeContainerGroupsRequest : TeaModel {
        /// <summary>
        /// The computing power type of the elastic container instance. A value of economy specifies economic elastic container instances.
        /// </summary>
        [NameInMap("ComputeCategory")]
        [Validation(Required=false)]
        public string ComputeCategory { get; set; }

        /// <summary>
        /// The IDs of the elastic container instances in JSON format. You can specify up to 20 IDs.
        /// </summary>
        [NameInMap("ContainerGroupIds")]
        [Validation(Required=false)]
        public string ContainerGroupIds { get; set; }

        /// <summary>
        /// The name of the elastic container instance.
        /// </summary>
        [NameInMap("ContainerGroupName")]
        [Validation(Required=false)]
        public string ContainerGroupName { get; set; }

        /// <summary>
        /// The maximum number of resources to return. Default value: 20. Maximum value: 20.
        /// 
        /// >  The number of returned resources is less than or equal to the specified number.
        /// </summary>
        [NameInMap("Limit")]
        [Validation(Required=false)]
        public int? Limit { get; set; }

        /// <summary>
        /// The token that determines the start point of the query. If this parameter is left empty, all results have been returned.
        /// 
        /// > You do not need to specify this parameter in the first request. Starting from the second request, you can obtain the token from the result returned by the previous request.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group to which the instance belongs.
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
        /// The ID of the security group to which the instance belongs.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The status of the elastic container instance. Valid values:
        /// 
        /// *   Pending: The instance is being started.
        /// *   Running: The instance is running.
        /// *   Succeeded: The instance runs successfully.
        /// *   Failed: The instance fails to run.
        /// *   Scheduling: The instance is being created.
        /// *   ScheduleFailed: The instance fails to be created.
        /// *   Restarting: The instance is being restarted.
        /// *   Updating: The instance is being updated.
        /// *   Terminating: The instance is being terminated.
        /// *   Expired: The instance expires.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The tag of the instances.
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<DescribeContainerGroupsRequestTag> Tag { get; set; }
        public class DescribeContainerGroupsRequestTag : TeaModel {
            /// <summary>
            /// The tag key of the instances.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The tag value of the instances.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The ID of the vSwitch to which the elastic container instances are connected.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// Specify whether to return event information.
        /// </summary>
        [NameInMap("WithEvent")]
        [Validation(Required=false)]
        public bool? WithEvent { get; set; }

        /// <summary>
        /// The ID of the zone in which the elastic container instances are deployed. If you do not specify this parameter, the system selects a zone.
        /// 
        /// This parameter is empty by default.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
