// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHBaseTableResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHBaseTableResponseBodyData Data { get; set; }
        public class GetDoctorHBaseTableResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Diagnostic results.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorHBaseTableResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorHBaseTableResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// <para>List of read hotspot regions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("ReadRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> ReadRequestHotspotRegionList { get; set; }

                /// <summary>
                /// <para>Description of read imbalance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>read request unbalance is &lt;p class=\&quot;report-detail-topic\&quot;&gt;表分区总数量为14，分区平均读请求数量为5032486，以下分区存在读请求热点访问：</para>&lt;ul class=\&quot;report-detail-ul\&quot;&gt;&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-4 Region Id： 4ac818a3ab3fd727490a5b4d4dac7667 读请求数量： 15485664</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： 021b387ae92959def65041e25eade3aa 读请求数量： 7731980</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： d58f33abfe857e5fd0045eaa31c93df8 读请求数量： 7705237</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： 4ca84757a7d0948b8552cfeebefa25a9 读请求数量： 7703492</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-4 Region Id： 1018192dae42995fc75c6d5b5981a9b7 读请求数量： 7695284</description></item></list>&lt;p style=\&quot;line-height： 16px; font-size： 16px; margin： 0 auto\&quot;&gt;&nbsp;</para></para>
                /// </summary>
                [NameInMap("ReadRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string ReadRequestUnbalanceSuggestion { get; set; }

                /// <summary>
                /// <para>List of read/write hotspot regions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("RequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> RequestHotspotRegionList { get; set; }

                /// <summary>
                /// <para>Description of read/write imbalance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>read request unbalance is &lt;p class=\&quot;report-detail-topic\&quot;&gt;表分区总数量为14，分区平均读请求数量为5032486，以下分区存在读请求热点访问：</para>&lt;ul class=\&quot;report-detail-ul\&quot;&gt;&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-4 Region Id： 4ac818a3ab3fd727490a5b4d4dac7667 读请求数量： 15485664</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： 021b387ae92959def65041e25eade3aa 读请求数量： 7731980</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： d58f33abfe857e5fd0045eaa31c93df8 读请求数量： 7705237</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： 4ca84757a7d0948b8552cfeebefa25a9 读请求数量： 7703492</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-4 Region Id： 1018192dae42995fc75c6d5b5981a9b7 读请求数量： 7695284</description></item></list>&lt;p style=\&quot;line-height： 16px; font-size： 16px; margin： 0 auto\&quot;&gt;&nbsp;</para></para>
                /// </summary>
                [NameInMap("RequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string RequestUnbalanceSuggestion { get; set; }

                /// <summary>
                /// <para>Table score.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("TableScore")]
                [Validation(Required=false)]
                public int? TableScore { get; set; }

                /// <summary>
                /// <para>List of write hotspot regions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>null</para>
                /// </summary>
                [NameInMap("WriteRequestHotspotRegionList")]
                [Validation(Required=false)]
                public List<string> WriteRequestHotspotRegionList { get; set; }

                /// <summary>
                /// <para>Description of write imbalance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>write request unbalance is &lt;p class=\&quot;report-detail-topic\&quot;&gt;表分区总数量为15，分区平均写请求数量为769954，以下分区存在写请求热点访问：</para>&lt;ul class=\&quot;report-detail-ul\&quot;&gt;&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： 4a938c08750869c47b7a92edeeec2ccc 写请求数量： 2115051</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： b4d21974df92bdf3589e63e4da1fc923 写请求数量： 1592509</description></item>&lt;li class=\&quot;.report-detail-li\&quot;&gt;RegionServer： emr-worker-2 Region Id： 25eb6717470f4ddbabe9187ff0fc0cb3 写请求数量： 1585420</description></item></list>&lt;p style=\&quot;line-height： 16px; font-size： 16px; margin： 0 auto\&quot;&gt;&nbsp;</para></para>
                /// </summary>
                [NameInMap("WriteRequestUnbalanceSuggestion")]
                [Validation(Required=false)]
                public string WriteRequestUnbalanceSuggestion { get; set; }

            }

            /// <summary>
            /// <para>Metrics information.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHBaseTableResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHBaseTableResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>Number of days the table has not been accessed.</para>
                /// </summary>
                [NameInMap("ColdAccessDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdAccessDay ColdAccessDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdAccessDay : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cold access day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldAccessDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Cold data access days configuration.</para>
                /// </summary>
                [NameInMap("ColdConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdConfigDay ColdConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdConfigDay : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cold config day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldConfigDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Cold data size.</para>
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsColdDataSize : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the cold data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Number of read requests per day.</para>
                /// </summary>
                [NameInMap("DailyReadRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequest DailyReadRequest { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequest : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>test-update</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the item.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dailyReadRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Daily growth ratio of daily read requests.</para>
                /// </summary>
                [NameInMap("DailyReadRequestDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequestDayGrowthRatio DailyReadRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyReadRequestDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of table size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dailyReadRequestDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Number of write requests per day.</para>
                /// </summary>
                [NameInMap("DailyWriteRequest")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequest DailyWriteRequest { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequest : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of write requests per day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dailyWriteRequest</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Daily write request growth ratio.</para>
                /// </summary>
                [NameInMap("DailyWriteRequestDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio DailyWriteRequestDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsDailyWriteRequestDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The balance of distributing requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>dailyWriteRequestDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Configuration for the number of days cold data is accessed.</para>
                /// </summary>
                [NameInMap("FreezeConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsFreezeConfigDay FreezeConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsFreezeConfigDay : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Freeze config day</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>freezeConfigDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>day</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Frozen data size.</para>
                /// </summary>
                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsFreezeDataSize : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the freeze data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>freezeDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Hot data size.</para>
                /// </summary>
                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsHotDataSize : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the hot data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hotDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Locality rate.</para>
                /// </summary>
                [NameInMap("Locality")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsLocality Locality { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsLocality : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The locality of data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>locality</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Read request balance.</para>
                /// </summary>
                [NameInMap("ReadRequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsReadRequestBalance ReadRequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsReadRequestBalance : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The balance of distributing read requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>readRequestBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Region balance.</para>
                /// </summary>
                [NameInMap("RegionBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionBalance RegionBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionBalance : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The ability to evenly distribute Regions on different RegionServer nodes</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regionBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Number of regions.</para>
                /// </summary>
                [NameInMap("RegionCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionCount RegionCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionCount : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of regions count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regionCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Daily incremental ratio of regions</para>
                /// </summary>
                [NameInMap("RegionCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionCountDayGrowthRatio RegionCountDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of region count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regionCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.8</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Number of RegionServers.</para>
                /// </summary>
                [NameInMap("RegionServerCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRegionServerCount RegionServerCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRegionServerCount : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of region servers count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>regionServerCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Usage.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>10</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Request balance.</para>
                /// </summary>
                [NameInMap("RequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsRequestBalance RequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsRequestBalance : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The balance of distributing requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>requestBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.0</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Number of store files.</para>
                /// </summary>
                [NameInMap("StoreFileCount")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCount StoreFileCount { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCount : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of store files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>storeFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Daily growth ratio of store file count.</para>
                /// </summary>
                [NameInMap("StoreFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCountDayGrowthRatio StoreFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsStoreFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of store file count</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>storeFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Table size.</para>
                /// </summary>
                [NameInMap("TableSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsTableSize TableSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsTableSize : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the table</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tableSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tb_item</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Daily growth ratio of table size.</para>
                /// </summary>
                [NameInMap("TableSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsTableSizeDayGrowthRatio TableSizeDayGrowthRatio { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsTableSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of table size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tableSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1.5</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>Warm data access days configuration.</para>
                /// </summary>
                [NameInMap("WarmConfigDay")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWarmConfigDay WarmConfigDay { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWarmConfigDay : TeaModel {
                    /// <summary>
                    /// <para>Metric description.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the warm data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Metric name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warmConfigDay</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Metric unit.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Warm data size.</para>
                /// </summary>
                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWarmDataSize : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the warm data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warmDataSize</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>Usage rate.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>Write request balance.</para>
                /// </summary>
                [NameInMap("WriteRequestBalance")]
                [Validation(Required=false)]
                public GetDoctorHBaseTableResponseBodyDataMetricsWriteRequestBalance WriteRequestBalance { get; set; }
                public class GetDoctorHBaseTableResponseBodyDataMetricsWriteRequestBalance : TeaModel {
                    /// <summary>
                    /// <para>Description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>The balance of distributing write requests</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>Name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>writeRequestBalance</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>Unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>&quot;&quot;</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
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
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
