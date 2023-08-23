// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleHooksResponseBody : TeaModel {
        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public List<DescribeLifecycleHooksResponseBodyLifecycleHooks> LifecycleHooks { get; set; }
        public class DescribeLifecycleHooksResponseBodyLifecycleHooks : TeaModel {
            [NameInMap("DefaultResult")]
            [Validation(Required=false)]
            public string DefaultResult { get; set; }

            [NameInMap("HeartbeatTimeout")]
            [Validation(Required=false)]
            public int? HeartbeatTimeout { get; set; }

            [NameInMap("LifecycleHookId")]
            [Validation(Required=false)]
            public string LifecycleHookId { get; set; }

            [NameInMap("LifecycleHookName")]
            [Validation(Required=false)]
            public string LifecycleHookName { get; set; }

            [NameInMap("LifecycleHookStatus")]
            [Validation(Required=false)]
            public string LifecycleHookStatus { get; set; }

            [NameInMap("LifecycleTransition")]
            [Validation(Required=false)]
            public string LifecycleTransition { get; set; }

            [NameInMap("NotificationArn")]
            [Validation(Required=false)]
            public string NotificationArn { get; set; }

            [NameInMap("NotificationMetadata")]
            [Validation(Required=false)]
            public string NotificationMetadata { get; set; }

            [NameInMap("ScalingGroupId")]
            [Validation(Required=false)]
            public string ScalingGroupId { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
