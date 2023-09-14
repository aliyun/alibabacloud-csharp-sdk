// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseClusterResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseClusterResponseBodyData Data { get; set; }
        public class GetDoctorHBaseClusterResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorHBaseClusterResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorHBaseClusterResponseBodyDataAnalysis : TeaModel {
                [NameInMap("HbaseScore")]
                [Validation(Required=false)]
                public int? HbaseScore { get; set; }

            }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHBaseClusterResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHBaseClusterResponseBodyDataMetrics : TeaModel {
                [NameInMap("AvgLoad")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsAvgLoad AvgLoad { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsAvgLoad : TeaModel {
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
                public GetDoctorHBaseClusterResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsDailyReadRequest : TeaModel {
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

                [NameInMap("DailyWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsDailyWriteRequest : TeaModel {
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

                [NameInMap("MemHeap")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsMemHeap MemHeap { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsMemHeap : TeaModel {
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

                [NameInMap("NormalAvgLoad")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsNormalAvgLoad NormalAvgLoad { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsNormalAvgLoad : TeaModel {
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

                [NameInMap("RegionBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsRegionBalance RegionBalance { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsRegionBalance : TeaModel {
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
                public GetDoctorHBaseClusterResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsRegionCount : TeaModel {
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

                [NameInMap("RegionServerCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsRegionServerCount RegionServerCount { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsRegionServerCount : TeaModel {
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

                [NameInMap("StoreFileCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsStoreFileCount : TeaModel {
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

                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsTableCount TableCount { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsTableCount : TeaModel {
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

                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseClusterResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsTotalDataSize : TeaModel {
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
                public GetDoctorHBaseClusterResponseBodyDataMetricsTotalReadRequest TotalReadRequest { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsTotalReadRequest : TeaModel {
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
                public GetDoctorHBaseClusterResponseBodyDataMetricsTotalRequest TotalRequest { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsTotalRequest : TeaModel {
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
                public GetDoctorHBaseClusterResponseBodyDataMetricsTotalWriteRequest TotalWriteRequest { get; set; }
                public class GetDoctorHBaseClusterResponseBodyDataMetricsTotalWriteRequest : TeaModel {
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
