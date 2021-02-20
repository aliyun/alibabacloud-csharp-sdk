// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceStatisticsResponseBody : TeaModel {
        [NameInMap("InstanceStatistics")]
        [Validation(Required=false)]
        public List<DescribeInstanceStatisticsResponseBodyInstanceStatistics> InstanceStatistics { get; set; }
        public class DescribeInstanceStatisticsResponseBodyInstanceStatistics : TeaModel {
            [NameInMap("DomainUsage")]
            [Validation(Required=false)]
            public int? DomainUsage { get; set; }

            [NameInMap("DefenseCountUsage")]
            [Validation(Required=false)]
            public int? DefenseCountUsage { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("SiteUsage")]
            [Validation(Required=false)]
            public int? SiteUsage { get; set; }

            [NameInMap("PortUsage")]
            [Validation(Required=false)]
            public int? PortUsage { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
