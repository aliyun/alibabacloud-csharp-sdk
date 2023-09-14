// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ListDoctorHiveTablesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListDoctorHiveTablesResponseBodyData> Data { get; set; }
        public class ListDoctorHiveTablesResponseBodyData : TeaModel {
            [NameInMap("Analysis")]
            [Validation(Required=false)]
            public ListDoctorHiveTablesResponseBodyDataAnalysis Analysis { get; set; }
            public class ListDoctorHiveTablesResponseBodyDataAnalysis : TeaModel {
                [NameInMap("HiveDistributionScore")]
                [Validation(Required=false)]
                public int? HiveDistributionScore { get; set; }

                [NameInMap("HiveFormatScore")]
                [Validation(Required=false)]
                public int? HiveFormatScore { get; set; }

                [NameInMap("HiveFrequencyScore")]
                [Validation(Required=false)]
                public int? HiveFrequencyScore { get; set; }

                [NameInMap("HiveScore")]
                [Validation(Required=false)]
                public int? HiveScore { get; set; }

            }

            [NameInMap("Formats")]
            [Validation(Required=false)]
            public List<ListDoctorHiveTablesResponseBodyDataFormats> Formats { get; set; }
            public class ListDoctorHiveTablesResponseBodyDataFormats : TeaModel {
                [NameInMap("FormatDayGrowthSize")]
                [Validation(Required=false)]
                public long? FormatDayGrowthSize { get; set; }

                [NameInMap("FormatName")]
                [Validation(Required=false)]
                public string FormatName { get; set; }

                [NameInMap("FormatRatio")]
                [Validation(Required=false)]
                public float? FormatRatio { get; set; }

                [NameInMap("FormatSize")]
                [Validation(Required=false)]
                public long? FormatSize { get; set; }

                [NameInMap("FormatSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public float? FormatSizeDayGrowthRatio { get; set; }

                [NameInMap("FormatSizeUnit")]
                [Validation(Required=false)]
                public string FormatSizeUnit { get; set; }

            }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public ListDoctorHiveTablesResponseBodyDataMetrics Metrics { get; set; }
            public class ListDoctorHiveTablesResponseBodyDataMetrics : TeaModel {
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
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

                [NameInMap("ColdDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsColdDataRatio ColdDataRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsColdDataRatio : TeaModel {
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

                [NameInMap("ColdDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsColdDataSize : TeaModel {
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

                [NameInMap("ColdDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
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

                [NameInMap("EmptyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileCount : TeaModel {
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

                [NameInMap("EmptyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("EmptyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
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

                [NameInMap("EmptyFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileRatio EmptyFileRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsEmptyFileRatio : TeaModel {
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

                [NameInMap("FreezeDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
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

                [NameInMap("FreezeDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataRatio FreezeDataRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataRatio : TeaModel {
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

                [NameInMap("FreezeDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataSize : TeaModel {
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

                [NameInMap("FreezeDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
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

                [NameInMap("HotDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
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

                [NameInMap("HotDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsHotDataRatio HotDataRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsHotDataRatio : TeaModel {
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

                [NameInMap("HotDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsHotDataSize : TeaModel {
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

                [NameInMap("HotDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
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

                [NameInMap("LargeFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsLargeFileCount : TeaModel {
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

                [NameInMap("LargeFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("LargeFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
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

                [NameInMap("LargeFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsLargeFileRatio LargeFileRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsLargeFileRatio : TeaModel {
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

                [NameInMap("MediumFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsMediumFileCount : TeaModel {
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

                [NameInMap("MediumFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("MediumFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
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

                [NameInMap("MediumFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsMediumFileRatio MediumFileRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsMediumFileRatio : TeaModel {
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

                [NameInMap("PartitionNum")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsPartitionNum PartitionNum { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsPartitionNum : TeaModel {
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

                [NameInMap("SmallFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsSmallFileCount : TeaModel {
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

                [NameInMap("SmallFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("SmallFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
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

                [NameInMap("SmallFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsSmallFileRatio SmallFileRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsSmallFileRatio : TeaModel {
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

                [NameInMap("TinyFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTinyFileCount : TeaModel {
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

                [NameInMap("TinyFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("TinyFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
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

                [NameInMap("TinyFileRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTinyFileRatio TinyFileRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTinyFileRatio : TeaModel {
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

                [NameInMap("TotalDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
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
                public ListDoctorHiveTablesResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTotalDataSize : TeaModel {
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

                [NameInMap("TotalDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
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

                [NameInMap("TotalFileCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTotalFileCount : TeaModel {
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

                [NameInMap("TotalFileCountDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
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

                [NameInMap("TotalFileDayGrowthCount")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
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

                [NameInMap("WarmDataDayGrowthSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
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

                [NameInMap("WarmDataRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsWarmDataRatio WarmDataRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsWarmDataRatio : TeaModel {
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

                [NameInMap("WarmDataSize")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsWarmDataSize : TeaModel {
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

                [NameInMap("WarmDataSizeDayGrowthRatio")]
                [Validation(Required=false)]
                public ListDoctorHiveTablesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class ListDoctorHiveTablesResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
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

            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

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
