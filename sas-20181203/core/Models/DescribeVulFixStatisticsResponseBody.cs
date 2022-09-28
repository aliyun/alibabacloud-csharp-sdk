// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeVulFixStatisticsResponseBody : TeaModel {
        [NameInMap("FixStat")]
        [Validation(Required=false)]
        public List<DescribeVulFixStatisticsResponseBodyFixStat> FixStat { get; set; }
        public class DescribeVulFixStatisticsResponseBodyFixStat : TeaModel {
            [NameInMap("FixedTodayNum")]
            [Validation(Required=false)]
            public int? FixedTodayNum { get; set; }

            [NameInMap("FixedTotalNum")]
            [Validation(Required=false)]
            public int? FixedTotalNum { get; set; }

            [NameInMap("FixingNum")]
            [Validation(Required=false)]
            public int? FixingNum { get; set; }

            [NameInMap("NeedFixNum")]
            [Validation(Required=false)]
            public int? NeedFixNum { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("FixTotal")]
        [Validation(Required=false)]
        public DescribeVulFixStatisticsResponseBodyFixTotal FixTotal { get; set; }
        public class DescribeVulFixStatisticsResponseBodyFixTotal : TeaModel {
            [NameInMap("FixedTodayNum")]
            [Validation(Required=false)]
            public int? FixedTodayNum { get; set; }

            [NameInMap("FixedTotalNum")]
            [Validation(Required=false)]
            public int? FixedTotalNum { get; set; }

            [NameInMap("FixingNum")]
            [Validation(Required=false)]
            public int? FixingNum { get; set; }

            [NameInMap("NeedFixNum")]
            [Validation(Required=false)]
            public int? NeedFixNum { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
