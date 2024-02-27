// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterPrimaryZoneRequest : TeaModel {
        /// <summary>
        /// The ID of the cluster.
        /// 
        /// > You can call the [DescribeDBClusters](~~173433~~) operation to query information about all clusters that are deployed in a specified region, such as the cluster ID.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies an immediate or scheduled task to switch the primary zone. Valid values:
        /// 
        /// *   false: scheduled task
        /// *   true: immediate task
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        /// <summary>
        /// Specifies whether to switch back over to the original primary zone. Valid values: true: Switch over back to the original primary zone. false: Do not switch back over to the original primary zone. If this parameter is set to false, the primary zone of the cluster is changed to the specified destination zone.
        /// </summary>
        [NameInMap("IsSwitchOverForDisaster")]
        [Validation(Required=false)]
        public string IsSwitchOverForDisaster { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The latest start time to switch the primary zone within the scheduled time period. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   The latest start time must be at least 30 minutes later than the earliest start time.
        /// 
        /// *   If you specify the `PlannedStartTime` parameter but do not specify the PlannedEndTime parameter, the latest start time of the task is set to a value that is calculated by `the value of the PlannedEndTime parameter + 30 minutes` by default. For example, if you set the `PlannedStartTime` parameter to `2021-01-14T09:00:00Z` and you do not specify the PlannedEndTime parameter, the latest start time of the task is set to `2021-01-14T09:30:00Z`.
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// The earliest start time to switch the primary zone within the scheduled time period. Specify the time in the ISO 8601 standard in the `YYYY-MM-DDThh:mm:ssZ` format. The time must be in UTC.
        /// 
        /// > 
        /// 
        /// *   The earliest start time of the task can be a point in time within the next 24 hours. For example, if the current time is `2021-01-14T09:00:00Z`, you can specify a point in time that ranges from `2021-01-14T09:00:00Z` to `2021-01-15T09:00:00Z`.
        /// 
        /// *   If you left this parameter empty, the primary zone is immediately switched.
        /// </summary>
        [NameInMap("PlannedStartTime")]
        [Validation(Required=false)]
        public string PlannedStartTime { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// The virtual private cloud (VPC) ID of the destination primary zone.
        /// </summary>
        [NameInMap("VPCId")]
        [Validation(Required=false)]
        public string VPCId { get; set; }

        /// <summary>
        /// The ID of vSwitch in the destination primary zone.
        /// 
        /// > 
        /// 
        /// *   For a PolarDB for Oracle or PolarDB for PostgreSQL cluster, this parameter is required.
        /// 
        /// *   For a PolarDB for MySQL cluster: - This parameter is optional if no vSwitches have been created in the destination zone. The default vSwitch is used. - This parameter is required if a vSwitch has been created in the destination zone.
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// The ID of the destination primary zone.
        /// 
        /// > You can call the [DescribeRegions](~~98041~~) operation to query available zones.
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

        [NameInMap("ZoneType")]
        [Validation(Required=false)]
        public string ZoneType { get; set; }

    }

}
