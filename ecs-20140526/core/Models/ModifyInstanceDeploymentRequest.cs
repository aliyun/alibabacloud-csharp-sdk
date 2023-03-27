// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class ModifyInstanceDeploymentRequest : TeaModel {
        /// <summary>
        /// Specifies whether to associate the instance with a dedicated host. Valid values:
        /// 
        /// *   host: associates the instance with a dedicated host. When you start a stopped instance in economical mode, the instance remains on its original dedicated host.
        /// *   default: does not associate the instance with a dedicated host. When you start a stopped instance in economical mode, the instance can be automatically deployed to another dedicated host in the automatic deployment resource pool if the resources of the original dedicated host are insufficient.
        /// 
        /// If you want to migrate the instance from a shared host to a dedicated host, use the default value. Default value: default.
        /// </summary>
        [NameInMap("Affinity")]
        [Validation(Required=false)]
        public string Affinity { get; set; }

        /// <summary>
        /// The ID of the dedicated host cluster.
        /// </summary>
        [NameInMap("DedicatedHostClusterId")]
        [Validation(Required=false)]
        public string DedicatedHostClusterId { get; set; }

        /// <summary>
        /// The ID of the destination dedicated host. You can call the [DescribeDedicatedHosts](~~134242~~) operation to query the most recent list of dedicated hosts.
        /// 
        /// When you migrate an instance from a shared host to a dedicated host or between dedicated hosts, take note of the following items:
        /// 
        /// *   To migrate the instance to a specific dedicated host, specify this parameter.
        /// *   To migrate the instance to a dedicated host that the system automatically selects, leave this parameter empty and set `Tenancy` to host.
        /// 
        /// For information about the automatic deployment feature, see [Features of dedicated hosts](~~118938~~).
        /// </summary>
        [NameInMap("DedicatedHostId")]
        [Validation(Required=false)]
        public string DedicatedHostId { get; set; }

        /// <summary>
        /// The number of the deployment set group in which to deploy the instance in the destination deployment set. This parameter takes effect only when the destination deployment set uses the high availability group strategy (AvailabilityGroup). Valid values: 1 to 7.
        /// 
        /// > If you call this operation to deploy an instance to a deployment set that uses the high availability group strategy (`AvailablilityGroup`) and leave this parameter empty, the system evenly distributes instances among the deployment set groups in the deployment set. If you specify the current deployment set of the instance as the destination deployment set in the request, the system evenly distributes instances again among the deployment set groups in the deployment set.
        /// </summary>
        [NameInMap("DeploymentSetGroupNo")]
        [Validation(Required=false)]
        public int? DeploymentSetGroupNo { get; set; }

        /// <summary>
        /// The ID of the destination deployment set.
        /// 
        /// This parameter is required when you add an instance to a deployment set or change the deployment set of an instance.
        /// 
        /// > You cannot change the deployment set when you modify dedicated host configurations, including the `Tenancy`, `Affinity`, and `DedicatedHostId` parameters.
        /// </summary>
        [NameInMap("DeploymentSetId")]
        [Validation(Required=false)]
        public string DeploymentSetId { get; set; }

        /// <summary>
        /// Specifies whether to forcefully change the host of the instance when the deployment set of the instance is changed. Valid values:
        /// 
        /// *   true: forcefully changes the host of the instance when the deployment set of the instance is changed. Hosts can be forcefully changed only for instances in the Running or Stopped state. The instances that are in the Stopped state do not include pay-as-you-go instances that are stopped in economical mode.
        /// 
        ///     **
        /// 
        ///     **Note**If the specified instance has local disks attached, the local disks are forcefully changed when the host of the instance is forcefully changed. This may cause data loss in the local disks. Proceed with caution.
        /// 
        /// *   false: does not forcefully change the host of the instance when the deployment set of the instance is changed. You can add the instance to a deployment set only when the instance remains on the current host. When the Force parameter is set to false, the deployment set may fail to be changed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the instance
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The instance type to which the instance is changed. You can call the [DescribeInstanceTypes](~~25620~~) operation to query the most recent list of instance types.
        /// 
        /// You can change the instance type of an instance when you migrate the instance to a dedicated host. The new instance type must match the type of the specified dedicated host. For more information, see [Dedicated host types](~~68564~~).
        /// 
        /// *   If you specify this parameter, you must also specify the `DedicatedHostId` parameter.
        /// *   You cannot change the instance type of an instance if you use the automatic deployment feature to migrate the instance.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Specifies whether to stop the instance before it is migrated to the destination dedicated host. Valid values:
        /// 
        /// *   reboot: stops the instance before it is migrated.
        /// *   live: migrates the instance without stopping it. If you set the MigrationType parameter to live, you must specify the DedicatedHostId parameter. In this case, you cannot change the instance type of the instance when the instance is migrated.
        /// 
        /// Default value: reboot.
        /// </summary>
        [NameInMap("MigrationType")]
        [Validation(Required=false)]
        public string MigrationType { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent list of regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// Specifies whether to remove the specified instance from the specified deployment set. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// 
        /// > If you set this parameter to true, you must specify the InstanceId and DeploymentSetId parameters and make sure that the specified instance belongs to the specified deployment set.
        /// </summary>
        [NameInMap("RemoveFromDeploymentSet")]
        [Validation(Required=false)]
        public bool? RemoveFromDeploymentSet { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to deploy the instance on a dedicated host. Set the value to host.
        /// </summary>
        [NameInMap("Tenancy")]
        [Validation(Required=false)]
        public string Tenancy { get; set; }

    }

}
