// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDefenseRecordsResponseBody : TeaModel {
        [NameInMap("DefenseRecords")]
        [Validation(Required=false)]
        public List<DescribeDefenseRecordsResponseBodyDefenseRecords> DefenseRecords { get; set; }
        public class DescribeDefenseRecordsResponseBodyDefenseRecords : TeaModel {
            [NameInMap("AttackPeak")]
            [Validation(Required=false)]
            public long? AttackPeak { get; set; }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public long? EndTime { get; set; }

            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
