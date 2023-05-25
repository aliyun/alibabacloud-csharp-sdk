// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesRequest : TeaModel {
        /// <summary>
        /// Specifies the batch operation mode. Valid values:
        /// 
        /// *   AllTogether: In this mode, a success message is returned if all specified instances are stopped. If one or more of the specified instances fail the check when you set the DryRun parameter to false, none of the specified instances can be stopped and an error message is returned.
        /// *   SuccessFirst: In this mode, each instance is separately stopped. The response contains the operation results for each instance.
        /// 
        /// Default value: AllTogether.
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid Values:
        /// 
        /// *   true: performs a dry run, but the request is not made. The system checks the request for potential issues, including required parameters, request syntax, and instance status. If the request passes the dry run, `DRYRUN.SUCCESS` is returned. Otherwise, an error message is returned.
        /// 
        /// > If you set `BatchOptimization` to `SuccessFirst` and `DryRun` to true, only `DRYRUN.SUCCESS` is returned regardless of whether the request passes the dry run.
        /// 
        /// *   false: performs a dry run and sends the request. If the request passes the dry run, the operation is performed.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to forcibly stop the instance. Valid values:
        /// 
        /// *   true: forcibly stops the instance. This operation is equivalent to the power-off operation in common scenarios. Cache data that is not written to storage devices on the instance is lost.
        /// *   false: normally stops the instance.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// The IDs of instances.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public List<string> InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The region ID of the instance. You can call the [DescribeRegions](~~25609~~) operation to query the most recent region list.
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

        /// <summary>
        /// The stop mode of the pay-as-you-go instance. Valid values:
        /// 
        /// *   StopCharging: economical mode. For information about the conditions on which `StopCharging` takes effect, see the "Conditions for enabling economical mode" section in [Economical mode](~~63353~~).
        /// *   KeepCharging: standard mode. You continue to be charged for instances that are stopped in standard mode.
        /// 
        /// Default value: If the conditions for enabling the economical mode are met and you have enabled this mode in the ECS console, the default value is [StopCharging](~~63353#default~~). For more information, see the "Enable economical mode" section in `Economical mode`. Otherwise, the default value is `KeepCharging`.
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
