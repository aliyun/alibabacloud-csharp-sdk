// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHiveDatabasesResponseBody : TeaModel {
        /// <summary>
        /// <para>The analysis results of Hive databases.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHiveDatabasesResponseBodyData> Data { get; set; }
        public class ListDoctorHiveDatabasesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The analysis results.</para>
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorHiveDatabasesResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorHiveDatabasesResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// <para>The score for the distribution of files of different sizes stored in the Hive database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("HiveDistributionScore")]
                [Validation(Required=false)]
                public int? HiveDistributionScore { get; set; }

                /// <summary>
                /// <para>The score for the distribution of files stored in different formats in the Hive database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("HiveFormatScore")]
                [Validation(Required=false)]
                public int? HiveFormatScore { get; set; }

                /// <summary>
                /// <para>The score for the access frequency of the Hive database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("HiveFrequencyScore")]
                [Validation(Required=false)]
                public int? HiveFrequencyScore { get; set; }

                /// <summary>
                /// <para>The overall score of the Hive database.</para>
                /// 
                /// <b>Example:</b>
                /// <para>85</para>
                /// </summary>
                [NameInMap("HiveScore")]
                [Validation(Required=false)]
                public int? HiveScore { get; set; }

            }

            /// <summary>
            /// <para>The database name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>db1</para>
            /// </summary>
            [NameInMap("DatabaseName")]
            [Validation(Required=false)]
            public string DatabaseName { get; set; }

            /// <summary>
            /// <para>The information from the perspective of storage formats.</para>
            /// </summary>
            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<ListDoctorHiveDatabasesResponseBodyDataFormats> Formats { get; set; }
            public class ListDoctorHiveDatabasesResponseBodyDataFormats : TeaModel {
                /// <summary>
                /// <para>The daily increment of storage format-specific data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("FormatDayGrowthSize")]
                [Validation(Required=false)]
                public long? FormatDayGrowthSize { get; set; }

                /// <summary>
                /// <para>The name of the storage format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TextInputFormat</para>
                /// </summary>
                [NameInMap("FormatName")]
                [Validation(Required=false)]
                public string FormatName { get; set; }

                /// <summary>
                /// <para>The proportion of data in a specific storage format.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("FormatRatio")]
                [Validation(Required=false)]
                public float? FormatRatio { get; set; }

                /// <summary>
                /// <para>The amount of storage format-specific data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1000</para>
                /// </summary>
                [NameInMap("FormatSize")]
                [Validation(Required=false)]
                public long? FormatSize { get; set; }

                /// <summary>
                /// <para>The day-to-day growth rate of storage format-specific data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0.5</para>
                /// </summary>
                [NameInMap("FormatSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public float? FormatSizeDayGrowthRatio { get; set; }

                /// <summary>
                /// <para>The unit of the amount of storage format-specific data.</para>
                /// 
                /// <b>Example:</b>
                /// <para>MB</para>
                /// </summary>
                [NameInMap("FormatSizeUnit")]
                [Validation(Required=false)]
                public string FormatSizeUnit { get; set; }

            }

            /// <summary>
            /// <para>The metric information.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHiveDatabasesResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHiveDatabasesResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The daily increment of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.</para>
                /// </summary>
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth size of cold data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldDataDayGrowthSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.</para>
                /// </summary>
                [NameInMap("ColdDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataRatio ColdDataRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Cold data ratio</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldDataRatio</para>
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
                /// <para>The amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.</para>
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of cold files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldDataSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.</para>
                /// </summary>
                [NameInMap("ColdDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of cold data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>coldDataSizeDayGrowthRatio</para>
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
                /// <para>The number of empty files. Empty files are those with a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emptyFileCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the number of empty files. Empty files are those with a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emptyFileCountDayGrowthRatio</para>
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
                /// <para>The daily increment of the number of empty files. Empty files are those with a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth count of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emptyFileDayGrowthCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of empty files. Empty files are those with a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileRatio EmptyFileRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsEmptyFileRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>emptyFileRatio</para>
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
                /// <para>The daily increment of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth size of freeze data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>freezeDataDayGrowthSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataRatio FreezeDataRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of freeze data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>freezeDataRatio</para>
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
                /// <para>The amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of freeze files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>freezeDataSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of freeze data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>freezeDataSizeDayGrowthRatio</para>
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
                /// <para>The daily increment of the amount of hot data. Hot data refers to data that is accessed in recent seven days.</para>
                /// </summary>
                [NameInMap("HotDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth size of hot data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hotDataDayGrowthSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of hot data. Hot data refers to data that is accessed in recent seven days.</para>
                /// </summary>
                [NameInMap("HotDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataRatio HotDataRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Hot data ratio</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hotDataRatio</para>
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
                /// <para>The amount of hot data. Hot data refers to data that is accessed in recent seven days.</para>
                /// </summary>
                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of hot files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the amount of hot data. Hot data refers to data that is accessed in recent seven days.</para>
                /// </summary>
                [NameInMap("HotDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of hot data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>hotDataSizeDayGrowthRatio</para>
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
                /// <para>The number of large files. Large files are those with a size greater than 1 GB.</para>
                /// </summary>
                [NameInMap("LargeFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>largeFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>“”</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the number of large files. Large files are those with a size greater than 1 GB.</para>
                /// </summary>
                [NameInMap("LargeFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>largeFileCountDayGrowthRatio</para>
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
                /// <para>The daily increment of the number of large files. Large files are those with a size greater than 1 GB.</para>
                /// </summary>
                [NameInMap("LargeFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth count of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>largeFileDayGrowthCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of large files. Large files are those with a size greater than 1 GB.</para>
                /// </summary>
                [NameInMap("LargeFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileRatio LargeFileRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsLargeFileRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>largeFileRatio</para>
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
                /// <para>The number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mediumFileCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mediumFileCountDayGrowthRatio</para>
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
                /// <para>The daily increment of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth count of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mediumFileDayGrowthCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileRatio MediumFileRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsMediumFileRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mediumFileRatio</para>
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
                /// <para>The number of partitions.</para>
                /// </summary>
                [NameInMap("PartitionNum")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsPartitionNum PartitionNum { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsPartitionNum : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of partitions</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ppartitionNum</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>smallFileCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>smallFileCountDayGrowthRatio</para>
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
                /// <para>The daily increment of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth count of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>smallFileDayGrowthCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileRatio SmallFileRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsSmallFileRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>smallFileRatio</para>
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
                /// <para>The number of tables.</para>
                /// </summary>
                [NameInMap("TableCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTableCount TableCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTableCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of tables</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>TableCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</para>
                /// </summary>
                [NameInMap("TinyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tinyFileCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</para>
                /// </summary>
                [NameInMap("TinyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tinyFileCountDayGrowthRatio</para>
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
                /// <para>The daily increment of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</para>
                /// </summary>
                [NameInMap("TinyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth count of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tinyFileDayGrowthCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.</para>
                /// </summary>
                [NameInMap("TinyFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileRatio TinyFileRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTinyFileRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>tinyFileRatio</para>
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
                /// <para>The daily incremental of the total data volume.</para>
                /// </summary>
                [NameInMap("TotalDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth size of total data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalDataDayGrowthSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The total amount of data.</para>
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTotalDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Total data size in megabytes (MB)</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalDataSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the total data volume.</para>
                /// </summary>
                [NameInMap("TotalDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of total data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalDataSizeDayGrowthRatio</para>
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
                /// <para>The total number of files.</para>
                /// </summary>
                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTotalFileCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Number of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalFileCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the total number of files.</para>
                /// </summary>
                [NameInMap("TotalFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalFileCountDayGrowthRatio</para>
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
                /// <para>The daily increment of the total number of files.</para>
                /// </summary>
                [NameInMap("TotalFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth count of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>totalFileDayGrowthCount</para>
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
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily increment of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.</para>
                /// </summary>
                [NameInMap("WarmDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth size of warm data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warmDataDayGrowthSize</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The proportion of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.</para>
                /// </summary>
                [NameInMap("WarmDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataRatio WarmDataRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of warm data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>warmDataRatio</para>
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
                /// <para>The amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.</para>
                /// </summary>
                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Ratio of warm files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
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
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1000</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-to-day growth rate of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.</para>
                /// </summary>
                [NameInMap("WarmDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveDatabasesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of warm data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <para>The name of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>WarmDataSizeDayGrowthRatio</para>
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

            }

        }

        /// <summary>
        /// <para>The maximum number of entries that are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>A pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
