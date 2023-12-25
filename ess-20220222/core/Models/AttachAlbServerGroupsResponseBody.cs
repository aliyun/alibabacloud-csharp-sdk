// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachAlbServerGroupsResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the scaling activity in which Auto Scaling associates the ALB server group with the scaling group and adds ECS instances in the scaling group to the ALB server group. This parameter is returned only if you set the `ForceAttach` parameter to `true`.
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
