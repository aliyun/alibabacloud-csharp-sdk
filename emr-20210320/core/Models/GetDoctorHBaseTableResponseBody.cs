// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseTableResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseTableResponseBodyData Data { get; set; }
        public class GetDoctorHBaseTableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The diagnosis result.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorHBaseTableResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorHBaseTableResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ReadRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> ReadRequestHotspotRegionList { get; set; }

                /// <summary>
                /// <para>The description of read imbalance.</para>
                /// </summary>
                [NameInMap("ReadRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string ReadRequestUnbalanceSuggestion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> RequestHotspotRegionList { get; set; }

                /// <summary>
                /// <para>The description of read/write imbalance.</para>
                /// </summary>
                [NameInMap("RequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string RequestUnbalanceSuggestion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("TableScore")]
                [Validation(Required=false)]
                public int? TableScore { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("WriteRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> WriteRequestHotspotRegionList { get; set; }

                /// <summary>
                /// <para>The description of write imbalance.</para>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Cold access day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coldAccessDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("ColdConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdConfigDay ColdConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdConfigDay : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Cold config day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coldConfigDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdDataSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Size of the cold data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coldDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("DailyReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequest : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test-update</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dailyReadRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("DailyReadRequestDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequestDayGrowthRatio DailyReadRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequestDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of table size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dailyReadRequestDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("DailyWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequest : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of write requests per day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dailyWriteRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("DailyWriteRequestDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio DailyWriteRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The balance of distributing requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>dailyWriteRequestDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("FreezeConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsFreezeConfigDay FreezeConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsFreezeConfigDay : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Freeze config day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>freezeConfigDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsFreezeDataSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Size of the freeze data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>freezeDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsHotDataSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Size of the hot data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hotDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("Locality")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsLocality Locality { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsLocality : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The locality of data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>locality</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("ReadRequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsReadRequestBalance ReadRequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsReadRequestBalance : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The balance of distributing read requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>readRequestBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("RegionBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionBalance RegionBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionBalance : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The ability to evenly distribute Regions on different RegionServer nodes</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>regionBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("RegionCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of regions count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>regionCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("RegionCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionCountDayGrowthRatio RegionCountDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of region count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>regionCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("RegionServerCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionServerCount RegionServerCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionServerCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of region servers count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>regionServerCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("RequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRequestBalance RequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRequestBalance : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The balance of distributing requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>requestBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("StoreFileCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of store files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>storeFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("StoreFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCountDayGrowthRatio StoreFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of store file count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>storeFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("TableSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsTableSize TableSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsTableSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Size of the table</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tableSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tb_item</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TableSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsTableSizeDayGrowthRatio TableSizeDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsTableSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of table size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tableSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("WarmConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWarmConfigDay WarmConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWarmConfigDay : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Size of the warm data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>warmConfigDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWarmDataSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Size of the warm data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>warmDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("WriteRequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWriteRequestBalance WriteRequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWriteRequestBalance : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>The balance of distributing write requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>writeRequestBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

            }

        }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
