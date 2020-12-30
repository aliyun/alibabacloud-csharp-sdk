// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeAutomaticTraceabilitySlsLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Statistic")]
        [Validation(Required=false)]
        public List<DescribeAutomaticTraceabilitySlsLogResponseBodyStatistic> Statistic { get; set; }
        public class DescribeAutomaticTraceabilitySlsLogResponseBodyStatistic : TeaModel {
            [NameInMap("SourceIp")]
            [Validation(Required=false)]
            public string SourceIp { get; set; }

            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            [NameInMap("Token")]
            [Validation(Required=false)]
            public string Token { get; set; }

            [NameInMap("Point")]
            [Validation(Required=false)]
            public string Point { get; set; }

            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            [NameInMap("SourceIpLocation")]
            [Validation(Required=false)]
            public string SourceIpLocation { get; set; }

        }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
