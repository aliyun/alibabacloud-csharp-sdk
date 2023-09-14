// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHBaseTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHBaseTablesResponseBodyData> Data { get; set; }
        public class ListDoctorHBaseTablesResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorHBaseTablesResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorHBaseTablesResponseBodyDataAnalysis : TeaModel {
                [NameInMap("ReadRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> ReadRequestHotspotRegionList { get; set; }

                [NameInMap("ReadRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string ReadRequestUnbalanceSuggestion { get; set; }

                [NameInMap("RequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> RequestHotspotRegionList { get; set; }

                [NameInMap("RequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string RequestUnbalanceSuggestion { get; set; }

                [NameInMap("TableScore")]
                [Validation(Required=false)]
                public int? TableScore { get; set; }

                [NameInMap("WriteRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> WriteRequestHotspotRegionList { get; set; }

                [NameInMap("WriteRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string WriteRequestUnbalanceSuggestion { get; set; }

            }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHBaseTablesResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHBaseTablesResponseBodyDataMetrics : TeaModel {
                [NameInMap("ColdAccessDay")]
                [Validation(Required=false)]
                public ListDoctorHBaseTablesResponseBodyDataMetricsColdAccessDay ColdAccessDay { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsColdAccessDay : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsColdConfigDay ColdConfigDay { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsColdConfigDay : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsColdDataSize : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsDailyReadRequest : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsDailyReadRequestDayGrowthRatio DailyReadRequestDayGrowthRatio { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsDailyReadRequestDayGrowthRatio : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsDailyWriteRequest : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio DailyWriteRequestDayGrowthRatio { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsFreezeConfigDay FreezeConfigDay { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsFreezeConfigDay : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsFreezeDataSize : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsHotDataSize : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsLocality Locality { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsLocality : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsReadRequestBalance ReadRequestBalance { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsReadRequestBalance : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsRegionBalance RegionBalance { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsRegionBalance : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsRegionCount : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsRegionCountDayGrowthRatio RegionCountDayGrowthRatio { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsRegionCountDayGrowthRatio : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsRegionServerCount RegionServerCount { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsRegionServerCount : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsRequestBalance RequestBalance { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsRequestBalance : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsStoreFileCount : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsStoreFileCountDayGrowthRatio StoreFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsStoreFileCountDayGrowthRatio : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsTableSize TableSize { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsTableSize : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsTableSizeDayGrowthRatio TableSizeDayGrowthRatio { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsTableSizeDayGrowthRatio : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsWarmConfigDay WarmConfigDay { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsWarmConfigDay : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsWarmDataSize : TeaModel {
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
                public ListDoctorHBaseTablesResponseBodyDataMetricsWriteRequestBalance WriteRequestBalance { get; set; }
                public class ListDoctorHBaseTablesResponseBodyDataMetricsWriteRequestBalance : TeaModel {
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

            [NameInMap("TableName")]
            [Validation(Required=false)]
            public string TableName { get; set; }

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
