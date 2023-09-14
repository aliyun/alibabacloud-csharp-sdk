// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHBaseRegionServersResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHBaseRegionServersResponseBodyData> Data { get; set; }
        public class ListDoctorHBaseRegionServersResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHBaseRegionServersResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHBaseRegionServersResponseBodyDataMetrics : TeaModel {
                [NameInMap("AvgGc")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsAvgGc AvgGc { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsAvgGc : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("CacheRatio")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsCacheRatio CacheRatio { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsCacheRatio : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("DailyReadRequest")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyReadRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("DailyReadRequestDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyReadRequestDayGrowthRatio DailyReadRequestDayGrowthRatio { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyReadRequestDayGrowthRatio : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("DailyWriteRequest")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyWriteRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("DailyWriteRequestDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio DailyWriteRequestDayGrowthRatio { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("RegionCount")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsRegionCount : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalReadRequest")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsTotalReadRequest TotalReadRequest { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsTotalReadRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalRequest")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsTotalRequest TotalRequest { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsTotalRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalWriteRequest")]
                [Validation(Required=false)]
                public ListDoctorHBaseRegionServersResponseBodyDataMetricsTotalWriteRequest TotalWriteRequest { get; set; }
                public class ListDoctorHBaseRegionServersResponseBodyDataMetricsTotalWriteRequest : TeaModel {
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

            }

            [NameInMap("RegionServerHost")]
            [Validation(Required=false)]
            public string RegionServerHost { get; set; }

        }

        /// <summary>
        /// 本次请求所返回的最大记录条数。
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// 返回读取到的数据位置，空代表数据已经读取完毕。
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 本次请求条件下的数据总量。
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
