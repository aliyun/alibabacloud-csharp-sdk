// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDefenseCountStatisticsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DefenseCountStatistics")]
        [Validation(Required=true)]
        public DescribeDefenseCountStatisticsResponseDefenseCountStatistics DefenseCountStatistics { get; set; }
        public class DescribeDefenseCountStatisticsResponseDefenseCountStatistics : TeaModel {
            [NameInMap("DefenseCountTotalUsageOfCurrentMonth")]
            [Validation(Required=true)]
            public int? DefenseCountTotalUsageOfCurrentMonth { get; set; }
            [NameInMap("FlowPackCountRemain")]
            [Validation(Required=true)]
            public int? FlowPackCountRemain { get; set; }
            [NameInMap("MaxUsableDefenseCountCurrentMonth")]
            [Validation(Required=true)]
            public int? MaxUsableDefenseCountCurrentMonth { get; set; }
        };

    }

}
