// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstancesRequest : TeaModel {
        /// <summary>
        /// The batch operation mode. Valid values:
        /// 
        /// *   AllTogether: In this mode, if all instances are stopped, a success message is returned. If an instance fails the verification, all instances fail to stop and an error message is returned.
        /// *   SuccessFirst: In this mode, each instance is separately stopped. The response contains the operation results for each instance.
        /// 
        /// Default value: AllTogether.
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and instance status. If the request fails the dry run, an error message is returned. If the request passes the dry run, `DRYRUN.SUCCESS` is returned.
        /// 
        /// >  If you set `BatchOptimization` to `SuccessFirst` and `DryRun` to true, only `DRYRUN.SUCCESS` is returned, regardless of whether the request passes the dry run.
        /// 
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, instances are stopped.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to forcefully stop instances. Valid values:
        /// 
        /// *   true. This operation is equivalent to the typical power-off operation. Cache data that is not written to storage devices on instances is lost.
        /// *   false.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// The IDs of instances.
        /// 
        /// This parameter is required.
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
        /// The region ID of the instance. You can call the [DescribeRegions](https://help.aliyun.com/document_detail/25609.html) operation to query the most recent region list.
        /// 
        /// This parameter is required.
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
        /// *   StopCharging: economical mode. For information about how `StopCharging` takes effect, see the "Prerequisites" section in [Economical mode](https://help.aliyun.com/document_detail/63353.html).
        /// *   KeepCharging: standard mode. After the instance is stopped in standard mode, you continue to be charged for it.
        /// 
        /// Default value: If the prerequisites required for enabling economical mode are met and you have enabled the mode in the ECS console, the default value is [StopCharging](~~63353#default~~). For more information, see the "Enable economical mode" section in `Economical mode`. Otherwise, the default value is `KeepCharging`.
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
