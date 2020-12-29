// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeInstanceStatusResponseBody : TeaModel {
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

        [NameInMap("InstanceStatuses")]
        [Validation(Required=false)]
        public DescribeInstanceStatusResponseBodyInstanceStatuses InstanceStatuses { get; set; }
        public class DescribeInstanceStatusResponseBodyInstanceStatuses : TeaModel {
            [NameInMap("InstanceStatus")]
            [Validation(Required=false)]
            public List<DescribeInstanceStatusResponseBodyInstanceStatusesInstanceStatus> InstanceStatus { get; set; }
            public class DescribeInstanceStatusResponseBodyInstanceStatusesInstanceStatus : TeaModel {
                public string Status { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
