// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeInstanceStatisticsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("InstanceStatistics")]
        [Validation(Required=true)]
        public List<DescribeInstanceStatisticsResponseInstanceStatistics> InstanceStatistics { get; set; }
        public class DescribeInstanceStatisticsResponseInstanceStatistics : TeaModel {
            [NameInMap("InstanceId")]
            [Validation(Required=true)]
            public string InstanceId { get; set; }

            [NameInMap("PortUsage")]
            [Validation(Required=true)]
            public int? PortUsage { get; set; }

            [NameInMap("DomainUsage")]
            [Validation(Required=true)]
            public int? DomainUsage { get; set; }

            [NameInMap("SiteUsage")]
            [Validation(Required=true)]
            public int? SiteUsage { get; set; }

            [NameInMap("DefenseCountUsage")]
            [Validation(Required=true)]
            public int? DefenseCountUsage { get; set; }

        }

    }

}
