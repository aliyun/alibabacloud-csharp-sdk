// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListStackInstancesResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("StackInstances")]
        [Validation(Required=false)]
        public List<ListStackInstancesResponseBodyStackInstances> StackInstances { get; set; }
        public class ListStackInstancesResponseBodyStackInstances : TeaModel {
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StackGroupId")]
            [Validation(Required=false)]
            public string StackGroupId { get; set; }

            [NameInMap("StackId")]
            [Validation(Required=false)]
            public string StackId { get; set; }

            [NameInMap("DriftDetectionTime")]
            [Validation(Required=false)]
            public string DriftDetectionTime { get; set; }

            [NameInMap("StackDriftStatus")]
            [Validation(Required=false)]
            public string StackDriftStatus { get; set; }

            [NameInMap("StatusReason")]
            [Validation(Required=false)]
            public string StatusReason { get; set; }

            [NameInMap("StackGroupName")]
            [Validation(Required=false)]
            public string StackGroupName { get; set; }

            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RdFolderId")]
            [Validation(Required=false)]
            public string RdFolderId { get; set; }

        }

    }

}
