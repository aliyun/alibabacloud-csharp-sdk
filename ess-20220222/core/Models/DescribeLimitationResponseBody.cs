// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLimitationResponseBody : TeaModel {
        [NameInMap("MaxNumberOfAlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfAlbServerGroup { get; set; }

        [NameInMap("MaxNumberOfDBInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfDBInstances { get; set; }

        [NameInMap("MaxNumberOfLifecycleHooks")]
        [Validation(Required=false)]
        public int? MaxNumberOfLifecycleHooks { get; set; }

        [NameInMap("MaxNumberOfLoadBalancers")]
        [Validation(Required=false)]
        public int? MaxNumberOfLoadBalancers { get; set; }

        [NameInMap("MaxNumberOfMaxSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMaxSize { get; set; }

        [NameInMap("MaxNumberOfMinSize")]
        [Validation(Required=false)]
        public int? MaxNumberOfMinSize { get; set; }

        [NameInMap("MaxNumberOfNlbServerGroup")]
        [Validation(Required=false)]
        public int? MaxNumberOfNlbServerGroup { get; set; }

        [NameInMap("MaxNumberOfNotificationConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfNotificationConfigurations { get; set; }

        [NameInMap("MaxNumberOfScalingConfigurations")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingConfigurations { get; set; }

        [NameInMap("MaxNumberOfScalingGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingGroups { get; set; }

        [NameInMap("MaxNumberOfScalingInstances")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingInstances { get; set; }

        [NameInMap("MaxNumberOfScalingRules")]
        [Validation(Required=false)]
        public int? MaxNumberOfScalingRules { get; set; }

        [NameInMap("MaxNumberOfScheduledTasks")]
        [Validation(Required=false)]
        public int? MaxNumberOfScheduledTasks { get; set; }

        [NameInMap("MaxNumberOfVServerGroups")]
        [Validation(Required=false)]
        public int? MaxNumberOfVServerGroups { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
