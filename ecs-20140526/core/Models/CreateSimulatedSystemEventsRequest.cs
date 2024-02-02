// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class CreateSimulatedSystemEventsRequest : TeaModel {
        /// <summary>
        /// The type of the system event. Valid values:
        /// 
        /// *   SystemMaintenance.Reboot: The instance is restarted due to system maintenance.
        /// *   SystemFailure.Reboot: The instance is restarted due to a system error.
        /// *   InstanceFailure.Reboot: The instance is restarted due to an instance error.
        /// *   SystemMaintenance.Stop: The instance is stopped due to system maintenance.
        /// *   SystemMaintenance.Redeploy: The instance is redeployed due to system maintenance.
        /// *   SystemFailure.Redeploy: The instance is redeployed due to a system error.
        /// *   SystemFailure.Stop: The instance is stopped due to a system error.
        /// </summary>
        [NameInMap("EventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// The IDs of the instances. You can specify up to 100 instance IDs.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        /// <summary>
        /// The scheduled start time of the event. Specify the time in the [ISO 8601](~~25696~~) standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// 
        /// > For events that occur due to system errors or instance errors, the simulated events of such events enter the `Executing` state when the simulated events are created. The value of `NotBefore` is the time when the simulated events enter the `Executed` state.
        /// </summary>
        [NameInMap("NotBefore")]
        [Validation(Required=false)]
        public string NotBefore { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
