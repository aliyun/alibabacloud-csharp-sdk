// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class GetDoctorHDFSDirectoryResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDoctorHDFSDirectoryResponseBodyData Data { get; set; }
        public class GetDoctorHDFSDirectoryResponseBodyData : TeaModel {
            [NameInMap("Depth")]
            [Validation(Required=false)]
            public int? Depth { get; set; }

            [NameInMap("Group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            [NameInMap("Metrics")]
            [Validation(Required=false)]
            public GetDoctorHDFSDirectoryResponseBodyDataMetrics Metrics { get; set; }
            public class GetDoctorHDFSDirectoryResponseBodyDataMetrics : TeaModel {
                [NameInMap("ColdDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsColdDataDayGrowthSize ColdDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsColdDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsColdDataSize ColdDataSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsColdDataSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsColdDataSizeDayGrowthRatio ColdDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsColdDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsEmptyFileCount EmptyFileCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsEmptyFileCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsEmptyFileCountDayGrowthRatio EmptyFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsEmptyFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsEmptyFileDayGrowthCount EmptyFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsEmptyFileDayGrowthCount : TeaModel {
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

                [NameInMap("FreezeDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsFreezeDataDayGrowthSize FreezeDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsFreezeDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsFreezeDataSize FreezeDataSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsFreezeDataSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio FreezeDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsFreezeDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsHotDataDayGrowthSize HotDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsHotDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsHotDataSize HotDataSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsHotDataSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsHotDataSizeDayGrowthRatio HotDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsHotDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsLargeFileCount LargeFileCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsLargeFileCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsLargeFileCountDayGrowthRatio LargeFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsLargeFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsLargeFileDayGrowthCount LargeFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsLargeFileDayGrowthCount : TeaModel {
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

                [NameInMap("MediumFileCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsMediumFileCount MediumFileCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsMediumFileCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsMediumFileCountDayGrowthRatio MediumFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsMediumFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsMediumFileDayGrowthCount MediumFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsMediumFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsSmallFileCount SmallFileCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsSmallFileCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsSmallFileCountDayGrowthRatio SmallFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsSmallFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsSmallFileDayGrowthCount SmallFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsSmallFileDayGrowthCount : TeaModel {
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

                [NameInMap("TinyFileCount")]
                [Validation(Required=false)]
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTinyFileCount TinyFileCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTinyFileCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTinyFileCountDayGrowthRatio TinyFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTinyFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTinyFileDayGrowthCount TinyFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTinyFileDayGrowthCount : TeaModel {
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

                [NameInMap("TotalDataDayGrowthSize")]
                [Validation(Required=false)]
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalDataDayGrowthSize TotalDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalDataSize TotalDataSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalDataSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalDataSizeDayGrowthRatio TotalDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalDataSizeDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalFileCount TotalFileCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalFileCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalFileCountDayGrowthRatio TotalFileCountDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalFileCountDayGrowthRatio : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalFileDayGrowthCount TotalFileDayGrowthCount { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsTotalFileDayGrowthCount : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsWarmDataDayGrowthSize WarmDataDayGrowthSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsWarmDataDayGrowthSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsWarmDataSize WarmDataSize { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsWarmDataSize : TeaModel {
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
                public GetDoctorHDFSDirectoryResponseBodyDataMetricsWarmDataSizeDayGrowthRatio WarmDataSizeDayGrowthRatio { get; set; }
                public class GetDoctorHDFSDirectoryResponseBodyDataMetricsWarmDataSizeDayGrowthRatio : TeaModel {
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

            [NameInMap("User")]
            [Validation(Required=false)]
            public string User { get; set; }

        }

        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
