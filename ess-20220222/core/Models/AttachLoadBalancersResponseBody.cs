// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class AttachLoadBalancersResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the scaling activity.
        /// 
        /// The value of this parameter is returned only after you set the Async parameter to true. You can call the DescribeScalingActivities operation to query all scaling activity IDs and use the scaling activity IDs to check the status of the scaling activities.
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
