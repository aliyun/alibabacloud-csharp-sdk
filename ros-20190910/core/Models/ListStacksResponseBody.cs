// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStacksResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Stacks")]
        [Validation(Required=false)]
        public List<ListStacksResponseBodyStacks> Stacks { get; set; }
        public class ListStacksResponseBodyStacks : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("DisableRollback")]
            [Validation(Required=false)]
            public bool? DisableRollback { get; set; }

            [NameInMap("StackName")]
            [Validation(Required=false)]
            public string StackName { get; set; }

            [NameInMap("TimeoutInMinutes")]
            [Validation(Required=false)]
            public int? TimeoutInMinutes { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("ParentStackId")]
            [Validation(Required=false)]
            public string ParentStackId { get; set; }

            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }

            [NameInMap("StackType")]
            [Validation(Required=false)]
            public string StackType { get; set; }

        }

    }

}
