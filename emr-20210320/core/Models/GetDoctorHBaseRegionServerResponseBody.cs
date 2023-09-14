// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseRegionServerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseRegionServerResponseBodyData Data { get; set; }
        public class GetDoctorHBaseRegionServerResponseBodyData : TeaModel {
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHBaseRegionServerResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHBaseRegionServerResponseBodyDataMetrics : TeaModel {
                [NameInMap("AvgGc")]
                [Validation(Required=false)]
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsAvgGc AvgGc { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsAvgGc : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsCacheRatio CacheRatio { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsCacheRatio : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyReadRequest : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyReadRequestDayGrowthRatio DailyReadRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyReadRequestDayGrowthRatio : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyWriteRequest : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio DailyWriteRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsRegionCount : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsTotalReadRequest TotalReadRequest { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsTotalReadRequest : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsTotalRequest TotalRequest { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsTotalRequest : TeaModel {
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
                public GetDoctorHBaseRegionServerResponseBodyDataMetricsTotalWriteRequest TotalWriteRequest { get; set; }
                public class GetDoctorHBaseRegionServerResponseBodyDataMetricsTotalWriteRequest : TeaModel {
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

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
