// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDefenseCountStatisticsResponseBody : TeaModel {
        [NameInMap("DefenseCountStatistics")]
        [Validation(Required=false)]
        public DescribeDefenseCountStatisticsResponseBodyDefenseCountStatistics DefenseCountStatistics { get; set; }
        public class DescribeDefenseCountStatisticsResponseBodyDefenseCountStatistics : TeaModel {
            [NameInMap("DefenseCountTotalUsageOfCurrentMonth")]
            [Validation(Required=false)]
            public int? DefenseCountTotalUsageOfCurrentMonth { get; set; }
            [NameInMap("FlowPackCountRemain")]
            [Validation(Required=false)]
            public int? FlowPackCountRemain { get; set; }
            [NameInMap("MaxUsableDefenseCountCurrentMonth")]
            [Validation(Required=false)]
            public int? MaxUsableDefenseCountCurrentMonth { get; set; }
            [NameInMap("SecHighSpeedCountRemain")]
            [Validation(Required=false)]
            public int? SecHighSpeedCountRemain { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
