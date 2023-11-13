// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHiveTableResponseBody : TeaModel {
        /// <summary>
        /// The analysis results of the Hive table.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHiveTableResponseBodyData Data { get; set; }
        public class GetDoctorHiveTableResponseBodyData : TeaModel {
            /// <summary>
            /// The analysis results.
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorHiveTableResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorHiveTableResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// The score for the distribution of files of different sizes stored in the Hive table.
                /// </summary>
                [NameInMap("HiveDistributionScore")]
                [Validation(Required=false)]
                public int? HiveDistributionScore { get; set; }

                /// <summary>
                /// The score for the distribution of files stored in different formats in the Hive table.
                /// </summary>
                [NameInMap("HiveFormatScore")]
                [Validation(Required=false)]
                public int? HiveFormatScore { get; set; }

                /// <summary>
                /// The score for the access frequency of the Hive table.
                /// </summary>
                [NameInMap("HiveFrequencyScore")]
                [Validation(Required=false)]
                public int? HiveFrequencyScore { get; set; }

                /// <summary>
                /// The overall score of the Hive table.
                /// </summary>
                [NameInMap("HiveScore")]
                [Validation(Required=false)]
                public int? HiveScore { get; set; }

            }

            /// <summary>
            /// The information from the perspective of formats.
            /// </summary>
            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<GetDoctorHiveTableResponseBodyDataFormats> Formats { get; set; }
            public class GetDoctorHiveTableResponseBodyDataFormats : TeaModel {
                /// <summary>
                /// The daily amount increment of the data in a specific storage format.
                /// </summary>
                [NameInMap("FormatDayGrowthSize")]
                [Validation(Required=false)]
                public long? FormatDayGrowthSize { get; set; }

                /// <summary>
                /// The name of the storage format.
                /// </summary>
                [NameInMap("FormatName")]
                [Validation(Required=false)]
                public string FormatName { get; set; }

                /// <summary>
                /// The ratio of the data in a specific storage format.
                /// </summary>
                [NameInMap("FormatRatio")]
                [Validation(Required=false)]
                public float? FormatRatio { get; set; }

                /// <summary>
                /// The size of storage format-specific data.
                /// </summary>
                [NameInMap("FormatSize")]
                [Validation(Required=false)]
                public long? FormatSize { get; set; }

                /// <summary>
                /// The day-to-day growth rate of the amount of the data in a specific storage format.
                /// </summary>
                [NameInMap("FormatSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public float? FormatSizeDayGrowthRatio { get; set; }

                /// <summary>
                /// The unit of the data size.
                /// </summary>
                [NameInMap("FormatSizeUnit")]
                [Validation(Required=false)]
                public string FormatSizeUnit { get; set; }

            }

            /// <summary>
            /// The metric information.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHiveTableResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHiveTableResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The daily increment of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.
                /// </summary>
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.
                /// </summary>
                [NameInMap("ColdDataRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsColdDataRatio ColdDataRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsColdDataRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsColdDataSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.
                /// </summary>
                [NameInMap("ColdDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The number of empty files. Empty files are those with a size of 0 MB.
                /// </summary>
                [NameInMap("EmptyFileCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsEmptyFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the number of empty files. Empty files are those with a size of 0 MB.
                /// </summary>
                [NameInMap("EmptyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the number of empty files. Empty files are those with a size of 0 MB.
                /// </summary>
                [NameInMap("EmptyFileDayGrowthCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of empty files. Empty files are those with a size of 0 MB.
                /// </summary>
                [NameInMap("EmptyFileRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsEmptyFileRatio EmptyFileRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsEmptyFileRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
                /// </summary>
                [NameInMap("FreezeDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
                /// </summary>
                [NameInMap("FreezeDataRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsFreezeDataRatio FreezeDataRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsFreezeDataRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
                /// </summary>
                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsFreezeDataSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the amount of very cold data. Very cold data refers to data that is not accessed for more than 90 days.
                /// </summary>
                [NameInMap("FreezeDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the amount of hot data. Hot data refers to data that is accessed in recent seven days.
                /// </summary>
                [NameInMap("HotDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of hot data. Hot data refers to data that is accessed in recent seven days.
                /// </summary>
                [NameInMap("HotDataRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsHotDataRatio HotDataRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsHotDataRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The amount of hot data. Hot data refers to data that is accessed in recent seven days.
                /// </summary>
                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsHotDataSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the amount of hot data. Hot data refers to data that is accessed in recent seven days.
                /// </summary>
                [NameInMap("HotDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The number of large files. Large files are those with a size greater than 1 GB.
                /// </summary>
                [NameInMap("LargeFileCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsLargeFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the number of large files. Large files are those with a size greater than 1 GB.
                /// </summary>
                [NameInMap("LargeFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the number of large files. Large files are those with a size greater than 1 GB.
                /// </summary>
                [NameInMap("LargeFileDayGrowthCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of large files. Large files are those with a size greater than 1 GB.
                /// </summary>
                [NameInMap("LargeFileRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsLargeFileRatio LargeFileRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsLargeFileRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
                /// </summary>
                [NameInMap("MediumFileCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsMediumFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
                /// </summary>
                [NameInMap("MediumFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the number of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
                /// </summary>
                [NameInMap("MediumFileDayGrowthCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of medium files. Medium files are those with a size greater than or equal to 128 MB and less than or equal to 1 GB.
                /// </summary>
                [NameInMap("MediumFileRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsMediumFileRatio MediumFileRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsMediumFileRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The number of partitions.
                /// </summary>
                [NameInMap("PartitionNum")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsPartitionNum PartitionNum { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsPartitionNum : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
                /// </summary>
                [NameInMap("SmallFileCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsSmallFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
                /// </summary>
                [NameInMap("SmallFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
                /// </summary>
                [NameInMap("SmallFileDayGrowthCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
                /// </summary>
                [NameInMap("SmallFileRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsSmallFileRatio SmallFileRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsSmallFileRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
                /// </summary>
                [NameInMap("TinyFileCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTinyFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
                /// </summary>
                [NameInMap("TinyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the number of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
                /// </summary>
                [NameInMap("TinyFileDayGrowthCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of very small files. Very small files are those with a size greater than 0 MB and less than 10 MB.
                /// </summary>
                [NameInMap("TinyFileRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTinyFileRatio TinyFileRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTinyFileRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily incremental of the total data volume.
                /// </summary>
                [NameInMap("TotalDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The total amount of data.
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTotalDataSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the total data volume.
                /// </summary>
                [NameInMap("TotalDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The total number of files.
                /// </summary>
                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTotalFileCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the total number of files.
                /// </summary>
                [NameInMap("TotalFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the total number of files.
                /// </summary>
                [NameInMap("TotalFileDayGrowthCount")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The daily increment of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.
                /// </summary>
                [NameInMap("WarmDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The proportion of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.
                /// </summary>
                [NameInMap("WarmDataRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsWarmDataRatio WarmDataRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsWarmDataRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// The amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.
                /// </summary>
                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsWarmDataSize : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// The day-to-day growth rate of the amount of warm data. Warm data refers to data that is not accessed for more than 7 days but is accessed in 30 days.
                /// </summary>
                [NameInMap("WarmDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public GetDoctorHiveTableResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHiveTableResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// The description of the metric.
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// The name of the metric.
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// The unit of the metric.
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// The value of the metric.
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

            }

            /// <summary>
            /// The owner.
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
