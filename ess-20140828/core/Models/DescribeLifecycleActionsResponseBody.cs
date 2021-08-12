// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20140828.Models
{
    public class DescribeLifecycleActionsResponseBody : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("LifecycleActions")]
        [Validation(Required=false)]
        public DescribeLifecycleActionsResponseBodyLifecycleActions LifecycleActions { get; set; }
        public class DescribeLifecycleActionsResponseBodyLifecycleActions : TeaModel {
            [NameInMap("LifecycleAction")]
            [Validation(Required=false)]
            public List<DescribeLifecycleActionsResponseBodyLifecycleActionsLifecycleAction> LifecycleAction { get; set; }
            public class DescribeLifecycleActionsResponseBodyLifecycleActionsLifecycleAction : TeaModel {
                public string LifecycleHookId { get; set; }
                public string LifecycleActionToken { get; set; }
                public string LifecycleActionStatus { get; set; }
                public string LifecycleActionResult { get; set; }
                public DescribeLifecycleActionsResponseBodyLifecycleActionsLifecycleActionInstanceIds InstanceIds { get; set; }
                public class DescribeLifecycleActionsResponseBodyLifecycleActionsLifecycleActionInstanceIds : TeaModel {
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public List<string> InstanceId { get; set; }

                }
            }
        };

    }

}
