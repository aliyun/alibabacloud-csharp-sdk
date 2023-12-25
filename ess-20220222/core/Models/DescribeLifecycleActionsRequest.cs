// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleActionsRequest : TeaModel {
        /// <summary>
        /// The status of the lifecycle action. Valid values:
        /// 
        /// *   If a lifecycle action is in the Pending state, Elastic Compute Service (ECS) instances are waiting to be added to a scaling group or waiting to be removed from a scaling group.
        /// *   If a lifecycle action is in the Timeout state, the lifecycle hook that triggers the lifecycle action ends, and ECS instances are added to or removed from the scaling group.
        /// *   If a lifecycle action is in the Completed state, you manually end the lifecycle hook that triggers the lifecycle action ahead of schedule.
        /// </summary>
        [NameInMap("LifecycleActionStatus")]
        [Validation(Required=false)]
        public string LifecycleActionStatus { get; set; }

        /// <summary>
        /// The maximum number of entries to return on each page. Valid values: 1 to 50.
        /// 
        /// Default value: 10.
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// The token that is used to specify the lifecycle action from which the query starts.
        /// 
        /// For example, after the first 10 lifecycle actions are queried, the query starts from the 11th lifecycle action. Set this parameter to the NextToken value that is returned in the previous API call. If you do not specify this parameter, the query starts from the beginning.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

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
        /// The ID of the scaling activity.
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
