// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class DescribeInstanceStatsInfoResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatsInfoResponseBodyData> Data { get; set; }
        public class DescribeInstanceStatsInfoResponseBodyData : TeaModel {
            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            [NameInMap("InstanceType")]
            [Validation(Required=false)]
            public string InstanceType { get; set; }

            [NameInMap("OperatingInstanceCount")]
            [Validation(Required=false)]
            public int? OperatingInstanceCount { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ReleasingInstanceCount")]
            [Validation(Required=false)]
            public int? ReleasingInstanceCount { get; set; }

            [NameInMap("ReservingInstanceCount")]
            [Validation(Required=false)]
            public int? ReservingInstanceCount { get; set; }

            [NameInMap("RunningInstanceCount")]
            [Validation(Required=false)]
            public int? RunningInstanceCount { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
