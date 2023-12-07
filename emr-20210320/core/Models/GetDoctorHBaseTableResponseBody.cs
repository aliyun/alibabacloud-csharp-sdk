// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseTableResponseBody : TeaModel {
        /// <summary>
        /// The returned data.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseTableResponseBodyData Data { get; set; }
        public class GetDoctorHBaseTableResponseBodyData : TeaModel {
            /// <summary>
            /// The diagnosis result.
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorHBaseTableResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorHBaseTableResponseBodyDataAnalysis : TeaModel {
                [NameInMap("ReadRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> ReadRequestHotspotRegionList { get; set; }

                /// <summary>
                /// The description of read imbalance.
                /// </summary>
                [NameInMap("ReadRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string ReadRequestUnbalanceSuggestion { get; set; }

                [NameInMap("RequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> RequestHotspotRegionList { get; set; }

                /// <summary>
                /// The description of read/write imbalance.
                /// </summary>
                [NameInMap("RequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string RequestUnbalanceSuggestion { get; set; }

                [NameInMap("TableScore")]
                [Validation(Required=false)]
                public int? TableScore { get; set; }

                [NameInMap("WriteRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> WriteRequestHotspotRegionList { get; set; }

                /// <summary>
                /// The description of write imbalance.
                /// </summary>
                [NameInMap("WriteRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string WriteRequestUnbalanceSuggestion { get; set; }

            }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHBaseTableResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHBaseTableResponseBodyDataMetrics : TeaModel {
                [NameInMap("ColdAccessDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdAccessDay ColdAccessDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdAccessDay : TeaModel {
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

                [NameInMap("ColdConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdConfigDay ColdConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdConfigDay : TeaModel {
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

                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdDataSize : TeaModel {
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

                [NameInMap("DailyReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequest : TeaModel {
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
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequestDayGrowthRatio DailyReadRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequestDayGrowthRatio : TeaModel {
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
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequest : TeaModel {
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
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio DailyWriteRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio : TeaModel {
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

                [NameInMap("FreezeConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsFreezeConfigDay FreezeConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsFreezeConfigDay : TeaModel {
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

                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsFreezeDataSize : TeaModel {
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

                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsHotDataSize : TeaModel {
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

                [NameInMap("Locality")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsLocality Locality { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsLocality : TeaModel {
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

                [NameInMap("ReadRequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsReadRequestBalance ReadRequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsReadRequestBalance : TeaModel {
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
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionBalance RegionBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionBalance : TeaModel {
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
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionCount : TeaModel {
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

                [NameInMap("RegionCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionCountDayGrowthRatio RegionCountDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionCountDayGrowthRatio : TeaModel {
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

                [NameInMap("RegionServerCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionServerCount RegionServerCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionServerCount : TeaModel {
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

                [NameInMap("RequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRequestBalance RequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRequestBalance : TeaModel {
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

                [NameInMap("StoreFileCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCount : TeaModel {
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

                [NameInMap("StoreFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCountDayGrowthRatio StoreFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("TableSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsTableSize TableSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsTableSize : TeaModel {
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

                [NameInMap("TableSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsTableSizeDayGrowthRatio TableSizeDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsTableSizeDayGrowthRatio : TeaModel {
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

                [NameInMap("WarmConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWarmConfigDay WarmConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWarmConfigDay : TeaModel {
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

                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWarmDataSize : TeaModel {
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

                [NameInMap("WriteRequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWriteRequestBalance WriteRequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWriteRequestBalance : TeaModel {
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
