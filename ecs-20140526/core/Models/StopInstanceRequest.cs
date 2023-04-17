// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class StopInstanceRequest : TeaModel {
        /// <summary>
        /// This parameter will be removed in the future and is retained only to ensure compatibility. We recommend that you ignore this parameter.
        /// </summary>
        [NameInMap("ConfirmStop")]
        [Validation(Required=false)]
        public bool? ConfirmStop { get; set; }

        /// <summary>
        /// Specifies whether to perform a dry run. Valid values:
        /// 
        /// *   true: performs a dry run. The system checks the required parameters, the request format, service limits, and available ECS resources. If the request fails the dry run, an error message is returned. If the request passes the dry run, the `DryRunOperation` error code is returned.
        /// *   false: performs a dry run and the request is made if the request passes the dry run.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Specifies whether to forcefully stop the instance. Valid values:
        /// 
        /// *   true: forcefully stops the instance.
        /// *   false: normally stops the instance.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("ForceStop")]
        [Validation(Required=false)]
        public bool? ForceStop { get; set; }

        /// <summary>
        /// >  This parameter is in invitational preview and is not available for public use.
        /// </summary>
        [NameInMap("Hibernate")]
        [Validation(Required=false)]
        public bool? Hibernate { get; set; }

        /// <summary>
        /// The ID of the instance.
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
        /// The stop mode of the pay-as-you-go instance. Default value: Disabled. Valid values:
        /// 
        /// *   StopCharging: economical mode. For information about how `StopCharging` takes effect, see the "Prerequisites" section in [Economical mode](~~63353~~).
        /// *   KeepCharging: standard mode. After the instance is stopped in standard mode, you continue to be charged for it.
        /// 
        /// Default value: If the prerequisites required for enabling economical mode are met and you have enabled this mode in the ECS console, the default value is `StopCharging`. For more information, see the "Enable economical mode" section in [Economical mode](~~63353#default~~). Otherwise, the default value is `KeepCharging`.
        /// </summary>
        [NameInMap("StoppedMode")]
        [Validation(Required=false)]
        public string StoppedMode { get; set; }

    }

}
