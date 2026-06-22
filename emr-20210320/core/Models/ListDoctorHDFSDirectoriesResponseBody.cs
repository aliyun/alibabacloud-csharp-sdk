// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHDFSDirectoriesResponseBody : TeaModel {
        /// <summary>
        /// <para>The analytical data for the batch analysis of HDFS directories.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHDFSDirectoriesResponseBodyData> Data { get; set; }
        public class ListDoctorHDFSDirectoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The directory level.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Depth")]
            [Validation(Required=false)]
            public int? Depth { get; set; }

            /// <summary>
            /// <para>The directory name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/tmp/test</para>
            /// </summary>
            [NameInMap("DirPath")]
            [Validation(Required=false)]
            public string DirPath { get; set; }

            /// <summary>
            /// <para>The group of the folder.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// <para>The metric information.</para>
            /// </summary>
            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHDFSDirectoriesResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHDFSDirectoriesResponseBodyDataMetrics : TeaModel {
                /// <summary>
                /// <para>The daily growth in the size of cold data. Cold data is data that was last accessed between 30 and 90 days ago.</para>
                /// </summary>
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
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
                    /// <para>-182636577752</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The size of the cold data. Cold data is data that was last accessed between 30 and 90 days ago.</para>
                /// </summary>
                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the cold data size</para>
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
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>5570958082267</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth rate of the cold data size. Cold data refers to data last accessed between 30 and 90 days ago.</para>
                /// </summary>
                [NameInMap("ColdDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-0.03</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The count of empty files. An empty file is a file with a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>15595897</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the empty file count. An empty file is a file with a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.005</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth in the number of empty files. An empty file has a size of 0 MB.</para>
                /// </summary>
                [NameInMap("EmptyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>114</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth in the size of freeze data. Freeze data is data that has not been accessed for 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
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
                    /// <para>-167683929450</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The size of the frozen data. Data is considered frozen if it has not been accessed in the last 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the freeze data size</para>
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
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1231312431</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth rate of freeze data. Freeze data is data that has not been accessed in 90 days.</para>
                /// </summary>
                [NameInMap("FreezeDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-0.09</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily increase in hot data size. Hot data is data that has been accessed within the last 7 days.</para>
                /// </summary>
                [NameInMap("HotDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
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
                    /// <para>123154</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The size of the hot data. Hot data is data accessed within the last 7 days.</para>
                /// </summary>
                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the hot data size</para>
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
                    /// <para>6701531944206</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth rate of the hot data size. Hot data is any data accessed in the past 7 days.</para>
                /// </summary>
                [NameInMap("HotDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.1114</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of large files. A large file is a file that is 1 GB or larger.</para>
                /// </summary>
                [NameInMap("LargeFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the large file count. A large file is a file that is 1 GB or larger.</para>
                /// </summary>
                [NameInMap("LargeFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.39</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily increase in the number of large files. A large file is a file larger than 1 GB.</para>
                /// </summary>
                [NameInMap("LargeFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of files larger than 128 MB and up to 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>323</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the number of medium-sized files. A medium-sized file is larger than 128 MB and smaller than 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.19</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily increase in the number of medium-sized files. A medium-sized file is larger than 128 MB and less than or equal to 1 GB.</para>
                /// </summary>
                [NameInMap("MediumFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>176</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of small files. A small file is a file with a size from 10 MB to 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the number of small files. A small file has a size greater than 10 MB and less than or equal to 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.02</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of new small files added each day. A small file is 10 MB to 128 MB.</para>
                /// </summary>
                [NameInMap("SmallFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The number of tiny files. A tiny file is larger than 0 MB and up to 10 MB in size.</para>
                /// </summary>
                [NameInMap("TinyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCount : TeaModel {
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
                    /// <para>232131</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth rate of tiny files. A tiny file is larger than 0 MB and smaller than 10 MB.</para>
                /// </summary>
                [NameInMap("TinyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.003</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth in the tiny file count. A tiny file is a file larger than 0 MB and smaller than 10 MB.</para>
                /// </summary>
                [NameInMap("TinyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-123</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth in the total data size.</para>
                /// </summary>
                [NameInMap("TotalDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
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
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>256482228248</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The total data size.</para>
                /// </summary>
                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSize : TeaModel {
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
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>62086342083623</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the total data size.</para>
                /// </summary>
                [NameInMap("TotalDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.14</para>
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
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>51683279</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the total file count.</para>
                /// </summary>
                [NameInMap("TotalFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0.02</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth in the total file count.</para>
                /// </summary>
                [NameInMap("TotalFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
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
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>27809</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The daily growth in the size of warm data. Warm data is data that has not been accessed in the last 7 days, but has been accessed in the last 30 days.</para>
                /// </summary>
                [NameInMap("WarmDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
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
                    /// <para>-64806998319</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The size of the warm data. Warm data is data that has been accessed within the past 30 days, but not within the past 7 days.</para>
                /// </summary>
                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSize : TeaModel {
                    /// <summary>
                    /// <para>The description of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Size of the warm data size</para>
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
                    /// <para>The metric value.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4062349775577</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                /// <summary>
                /// <para>The day-over-day growth ratio of the warm data size. Warm data has not been accessed in the last 7 days but has been accessed in the last 30 days.</para>
                /// </summary>
                [NameInMap("WarmDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
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
                    /// <para>warmDataSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <para>The unit of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <para>The value of the metric.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>-0.015</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

            }

            /// <summary>
            /// <para>The owner of the directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of records returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The starting position for the next read.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that match the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
