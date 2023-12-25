// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class SuspendProcessesRequest : TeaModel {
        /// <summary>
        /// The client token that is used to ensure the idempotence of the request. You can use the client to generate the value, but you must ensure that the value is unique among different requests.
        /// 
        /// The token can only contain ASCII characters and cannot exceed 64 characters in length. For more information, see [How to ensure idempotence](~~25965~~).
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The types of the processes that you want to suspend. Valid values:
        /// 
        /// *   scalein
        /// *   scaleout
        /// *   healthcheck
        /// *   alarmnotification
        /// *   scheduledaction
        /// 
        /// You can suspend five processes of the preceding types at the same time. If you try to suspend more than five processes at the same time, Auto Scaling automatically removes duplicate processes.
        /// </summary>
        [NameInMap("Processes")]
        [Validation(Required=false)]
        public List<string> Processes { get; set; }

        /// <summary>
        /// The region ID of the scaling group.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// The ID of the scaling group.
        /// </summary>
        [NameInMap("ScalingGroupId")]
        [Validation(Required=false)]
        public string ScalingGroupId { get; set; }

    }

}
