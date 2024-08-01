// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DeleteInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform only a dry run, without performing the actual request. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, service limits, and unavailable ECS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false (default): performs a dry run and performs the actual request. If the request passes the dry run, the instance is released.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to forcefully release the instance in the **Running** (`Running`) state. Valid values:
        /// 
        /// *   true: forcefully releases the instance in the **Running** (`Running`) state. This operation is equivalent to the power-off operation. Cache data that is not written to persistent storage will be lost.
        /// *   false: normally releases the instance. This value take effects only if the instance is in the **Stopped** (`Stopped`) state.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Force")]
        [Validation(Required=false)]
        public bool? Force { get; set; }

        /// <summary>
        /// The ID of the instance.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// Specifies whether to release the expired subscription instance. Valid values:
        /// 
        /// *   true
        /// *   false
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("TerminateSubscription")]
        [Validation(Required=false)]
        public bool? TerminateSubscription { get; set; }

    }

}
