// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RebootInstancesRequest : TeaModel {
        /// <summary>
        /// The batch operation mode. Valid values:
        /// 
        /// *   AllTogether: In this mode, if all instances are restarted, a success message is returned. If one or more instance fails the verification, all instances fail to restart and an error message is returned.
        /// *   SuccessFirst: In this mode, each instance is restarted separately. The response contains the operation results of each instance.
        /// 
        /// Default value: AllTogether.
        /// </summary>
        [NameInMap("BatchOptimization")]
        [Validation(Required=false)]
        public string BatchOptimization { get; set; }

        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid Values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including required parameters, request syntax, and instance status. If the request passes the dry run, `DRYRUN.SUCCESS` is returned. Otherwise, an error message is returned.
        /// 
        /// > If you set `BatchOptimization` to `SuccessFirst` and `DryRun` to \"true\", only `DRYRUN.SUCCESS` is returned regardless of whether the request passes the dry run.
        /// 
        /// *   false: performs a dry run and performs the actual request. If the request passes the dry run, the instance is restarted.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to forcibly restart the instance. Valid values:
        /// 
        /// *   true: restarts the instance in a forceful manner. This operation is equivalent to the typical power-off operation. Cache data that is not written to storage in the instance is lost.
        /// *   false: restarts the instance in a normal manner.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceReboot")]
        [Validation(Required=false)]
        public bool? ForceReboot { get; set; }

        /// <summary>
        /// The IDs of instances. You can specify up to 100 instance IDs.
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

    }

}
