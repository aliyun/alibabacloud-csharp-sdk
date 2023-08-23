// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeLifecycleActionsResponseBody : TeaModel {
        [NameInMap("LifecycleActions")]
        [Validation(Required=false)]
        public List<DescribeLifecycleActionsResponseBodyLifecycleActions> LifecycleActions { get; set; }
        public class DescribeLifecycleActionsResponseBodyLifecycleActions : TeaModel {
            [NameInMap("InstanceIds")]
            [Validation(Required=false)]
            public List<string> InstanceIds { get; set; }

            [NameInMap("LifecycleActionResult")]
            [Validation(Required=false)]
            public string LifecycleActionResult { get; set; }

            [NameInMap("LifecycleActionStatus")]
            [Validation(Required=false)]
            public string LifecycleActionStatus { get; set; }

            [NameInMap("LifecycleActionToken")]
            [Validation(Required=false)]
            public string LifecycleActionToken { get; set; }

            [NameInMap("LifecycleHookId")]
            [Validation(Required=false)]
            public string LifecycleHookId { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
