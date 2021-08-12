// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeLifecycleHooksResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("LifecycleHooks")]
        [Validation(Required=false)]
        public DescribeLifecycleHooksResponseBodyLifecycleHooks LifecycleHooks { get; set; }
        public class DescribeLifecycleHooksResponseBodyLifecycleHooks : TeaModel {
            [NameInMap("LifecycleHook")]
            [Validation(Required=false)]
            public List<DescribeLifecycleHooksResponseBodyLifecycleHooksLifecycleHook> LifecycleHook { get; set; }
            public class DescribeLifecycleHooksResponseBodyLifecycleHooksLifecycleHook : TeaModel {
                public string DefaultResult { get; set; }
                public string LifecycleHookId { get; set; }
                public string LifecycleHookName { get; set; }
                public string LifecycleTransition { get; set; }
                public string NotificationMetadata { get; set; }
                public string NotificationArn { get; set; }
                public int? HeartbeatTimeout { get; set; }
                public string ScalingGroupId { get; set; }
            }
        };

    }

}
