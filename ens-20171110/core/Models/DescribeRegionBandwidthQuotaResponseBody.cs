// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeRegionBandwidthQuotaResponseBody : TeaModel {
        [NameInMap("BandwidthQuota")]
        [Validation(Required=false)]
        public List<DescribeRegionBandwidthQuotaResponseBodyBandwidthQuota> BandwidthQuota { get; set; }
        public class DescribeRegionBandwidthQuotaResponseBodyBandwidthQuota : TeaModel {
            [NameInMap("BandwidthInfo")]
            [Validation(Required=false)]
            public List<DescribeRegionBandwidthQuotaResponseBodyBandwidthQuotaBandwidthInfo> BandwidthInfo { get; set; }
            public class DescribeRegionBandwidthQuotaResponseBodyBandwidthQuotaBandwidthInfo : TeaModel {
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public string Isp { get; set; }

                [NameInMap("MonthAverageQuota")]
                [Validation(Required=false)]
                public long? MonthAverageQuota { get; set; }

                [NameInMap("MonthMax")]
                [Validation(Required=false)]
                public long? MonthMax { get; set; }

                [NameInMap("WeekAverageQuota")]
                [Validation(Required=false)]
                public long? WeekAverageQuota { get; set; }

                [NameInMap("WeekMax")]
                [Validation(Required=false)]
                public long? WeekMax { get; set; }

            }

            [NameInMap("Date")]
            [Validation(Required=false)]
            public string Date { get; set; }

            [NameInMap("InstanceInfo")]
            [Validation(Required=false)]
            public List<DescribeRegionBandwidthQuotaResponseBodyBandwidthQuotaInstanceInfo> InstanceInfo { get; set; }
            public class DescribeRegionBandwidthQuotaResponseBodyBandwidthQuotaInstanceInfo : TeaModel {
                [NameInMap("InstanceNumber")]
                [Validation(Required=false)]
                public long? InstanceNumber { get; set; }

                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

            }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
