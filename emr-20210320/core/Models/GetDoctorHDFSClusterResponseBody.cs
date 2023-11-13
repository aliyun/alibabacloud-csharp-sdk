// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHDFSClusterResponseBody : TeaModel {
        /// <summary>
        /// The HDFS analysis results.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHDFSClusterResponseBodyData Data { get; set; }
        public class GetDoctorHDFSClusterResponseBodyData : TeaModel {
            /// <summary>
            /// The analysis results.
            /// </summary>
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public GetDoctorHDFSClusterResponseBodyDataAnalysis Analysis { get; set; }
            public class GetDoctorHDFSClusterResponseBodyDataAnalysis : TeaModel {
                /// <summary>
                /// The overall score of HDFS storage resources.
                /// </summary>
                [NameInMap("HdfsScore")]
                [Validation(Required=false)]
                public int? HdfsScore { get; set; }

            }

            /// <summary>
            /// The metric information.
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHDFSClusterResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHDFSClusterResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// The daily increment of the amount of cold data. Cold data refers to data that is not accessed for more than 30 days but is accessed in 90 days.
                /// </summary>
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSClusterResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsColdDataRatio ColdDataRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsColdDataRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsColdDataSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileRatio EmptyFileRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsEmptyFileRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataRatio FreezeDataRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsHotDataRatio HotDataRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsHotDataRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsHotDataSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileRatio LargeFileRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsLargeFileRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileRatio MediumFileRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsMediumFileRatio : TeaModel {
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
                /// The number of small files. Small files are those with a size greater than or equal to 10 MB and less than 128 MB.
                /// </summary>
                [NameInMap("SmallFileCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileRatio SmallFileRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsSmallFileRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileRatio TinyFileRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTinyFileRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTotalDataSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTotalFileCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataRatio WarmDataRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataRatio : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataSize : TeaModel {
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
                public GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSClusterResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
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

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
