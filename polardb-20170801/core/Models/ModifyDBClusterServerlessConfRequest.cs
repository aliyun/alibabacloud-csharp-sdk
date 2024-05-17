// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ModifyDBClusterServerlessConfRequest : TeaModel {
        /// <summary>
        /// Specifies whether to enable No-activity Suspension. Default value: false. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("AllowShutDown")]
        [Validation(Required=false)]
        public string AllowShutDown { get; set; }

        /// <summary>
        /// The ID of the serverless cluster.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// Specifies an immediate or scheduled task to modify parameters and restart the cluster. Valid values:
        /// 
        /// *   false: scheduled task
        /// *   true: immediate task
        /// </summary>
        [NameInMap("FromTimeService")]
        [Validation(Required=false)]
        public bool? FromTimeService { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The latest start time for upgrading the specifications within the scheduled time period. Specify the time in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
        /// > * The value of this parameter must be at least 30 minutes later than the value of PlannedStartTime.
        /// >*   If you specify PlannedStartTime but do not specify PlannedEndTime, the latest start time of the task is set to a value that is calculated by using the following formula: `PlannedEndTime value + 30 minutes`. For example, if you set PlannedStartTime to `2021-01-14T09:00:00Z` and you do not specify PlannedEndTime, the latest start time of the task is set to `2021-01-14T09:30:00Z`.
        /// </summary>
        [NameInMap("PlannedEndTime")]
        [Validation(Required=false)]
        public string PlannedEndTime { get; set; }

        /// <summary>
        /// The earliest start time of the scheduled task for adding the read-only node. The scheduled task specifies that the task is run in the required period. Specify the time in the YYYY-MM-DDThh:mm:ssZ format. The time must be in UTC.
        /// 
        /// > *   The earliest start time of the scheduled task can be a point in time within the next 24 hours. For example, if the current time is `2021-01-14T09:00:00Z`, you can specify a point in time between `2021-01-14T09:00:00Z` and `2021-01-15T09:00:00Z`.
        /// >*   If you leave this parameter empty, the task for adding the read-only node is immediately run by default.
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
        /// The maximum number of stable AP read-only nodes. Valid values: 0 to 7.
        /// </summary>
        [NameInMap("ScaleApRoNumMax")]
        [Validation(Required=false)]
        public string ScaleApRoNumMax { get; set; }

        /// <summary>
        /// The minimum number of stable AP read-only nodes. Valid values: 0 to 7.
        /// </summary>
        [NameInMap("ScaleApRoNumMin")]
        [Validation(Required=false)]
        public string ScaleApRoNumMin { get; set; }

        /// <summary>
        /// The maximum number of PCUs per node for scaling. Valid values: 1 PCU to 32 PCUs.
        /// </summary>
        [NameInMap("ScaleMax")]
        [Validation(Required=false)]
        public string ScaleMax { get; set; }

        /// <summary>
        /// The minimum number of PCUs per node for scaling. Valid values: 1 PCU to 31 PCUs.
        /// </summary>
        [NameInMap("ScaleMin")]
        [Validation(Required=false)]
        public string ScaleMin { get; set; }

        /// <summary>
        /// The maximum number of read-only nodes for scaling. Valid values: 0 to 15.
        /// </summary>
        [NameInMap("ScaleRoNumMax")]
        [Validation(Required=false)]
        public string ScaleRoNumMax { get; set; }

        /// <summary>
        /// The minimum number of read-only nodes for scaling. Valid values: 0 to 15.
        /// </summary>
        [NameInMap("ScaleRoNumMin")]
        [Validation(Required=false)]
        public string ScaleRoNumMin { get; set; }

        /// <summary>
        /// The detection period for No-activity Suspension. Valid values: 5 to 1440. Unit: minutes. The detection duration must be a multiple of 5 minutes.
        /// </summary>
        [NameInMap("SecondsUntilAutoPause")]
        [Validation(Required=false)]
        public string SecondsUntilAutoPause { get; set; }

        [NameInMap("ServerlessRuleCpuEnlargeThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuEnlargeThreshold { get; set; }

        [NameInMap("ServerlessRuleCpuShrinkThreshold")]
        [Validation(Required=false)]
        public string ServerlessRuleCpuShrinkThreshold { get; set; }

        [NameInMap("ServerlessRuleMode")]
        [Validation(Required=false)]
        public string ServerlessRuleMode { get; set; }

    }

}
