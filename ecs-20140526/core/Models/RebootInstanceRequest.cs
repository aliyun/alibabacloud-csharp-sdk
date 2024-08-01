// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class RebootInstanceRequest : TeaModel {
        /// <summary>
        /// Specifies whether to perform only a dry run. Valid values:
        /// 
        /// *   true: performs only a dry run. The system checks the required parameters, the request format, service limits, and available ECS resources. If the request fails the dry run, the corresponding error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false: performs a dry run and sends the request. If the request passes the dry run, the instance is restarted.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to forcefully stop the instance before you restart the instance. Valid values:
        /// 
        /// *   true: stops the instance in a forceful manner. This operation is equivalent to the power-off operation. Cache data that is not written to storage devices on the instance is lost.
        /// *   false (default): normally stops the instance.
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// The instance ID.
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

    }

}
