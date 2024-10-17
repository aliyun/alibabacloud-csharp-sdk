// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHDFSDirectoriesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHDFSDirectoriesResponseBodyData> Data { get; set; }
        public class ListDoctorHDFSDirectoriesResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Depth")]
            [Validation(Required=false)]
            public int? Depth { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/tmp/test</para>
            /// </summary>
            [NameInMap("DirPath")]
            [Validation(Required=false)]
            public string DirPath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHDFSDirectoriesResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHDFSDirectoriesResponseBodyDataMetrics : TeaModel {
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth size of cold data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coldDataDayGrowthSize</para>
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
                    /// <para>-182636577752</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSize : TeaModel {
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
                    /// <para>MB</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>5570958082267</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("ColdDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of cold data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>coldDataSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-0.03</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("EmptyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>emptyFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>15595897</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("EmptyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>emptyFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.005</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("EmptyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth count of empty files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>emptyFileDayGrowthCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>114</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("FreezeDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth size of freeze data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>freezeDataDayGrowthSize</para>
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
                    /// <para>-167683929450</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSize : TeaModel {
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
                    /// <para>1231312431</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("FreezeDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of freeze data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>freezeDataSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-0.09</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("HotDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth size of hot data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hotDataDayGrowthSize</para>
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
                    /// <para>123154</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSize : TeaModel {
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
                    /// <para>6701531944206</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("HotDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of hot data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>hotDataSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.1114</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("LargeFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>largeFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>123</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("LargeFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>largeFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.39</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("LargeFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth count of large files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>largeFileDayGrowthCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("MediumFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mediumFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>323</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("MediumFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mediumFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.19</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("MediumFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth count of medium files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>mediumFileDayGrowthCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>176</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("SmallFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>smallFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("SmallFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>smallFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.02</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("SmallFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth count of small files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>smallFileDayGrowthCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>12345</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TinyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tinyFileCount</para>
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
                    /// <para>232131</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TinyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tinyFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.003</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("TinyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth count of tiny files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>tinyFileDayGrowthCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-123</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth size of total data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>totalDataDayGrowthSize</para>
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
                    /// <para>256482228248</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Total data size in megabytes (MB)</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>totalDataSize</para>
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
                    /// <para>62086342083623</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of total data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>totalDataSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.14</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Number of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>totalFileCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>51683279</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("TotalFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>totalFileCountDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0.02</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

                [NameInMap("TotalFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth count of total files</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>totalFileDayGrowthCount</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>27809</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("WarmDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth size of warm data</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>warmDataDayGrowthSize</para>
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
                    /// <para>-64806998319</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSize : TeaModel {
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
                    /// <para>4062349775577</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public long? Value { get; set; }

                }

                [NameInMap("WarmDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHDFSDirectoriesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Day growth ratio of warm data size</para>
                    /// </summary>
                    [NameInMap("Description")]
                    [Validation(Required=false)]
                    public string Description { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>warmDataSizeDayGrowthRatio</para>
                    /// </summary>
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>”“</para>
                    /// </summary>
                    [NameInMap("Unit")]
                    [Validation(Required=false)]
                    public string Unit { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>-0.015</para>
                    /// </summary>
                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public float? Value { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>DW</para>
            /// </summary>
            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// <para>本次请求所返回的最大记录条数。</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>返回读取到的数据位置，空代表数据已经读取完毕。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C89568980</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>请求ID。</para>
        /// 
        /// <b>Example:</b>
        /// <para>DD6B1B2A-5837-5237-ABE4-FF0C8944****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>本次请求条件下的数据总量。</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
