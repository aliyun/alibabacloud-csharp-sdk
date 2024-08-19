// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetStockOssCheckTasksListResponseBody : TeaModel {
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetStockOssCheckTasksListResponseBodyItems> Items { get; set; }
        public class GetStockOssCheckTasksListResponseBodyItems : TeaModel {
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetStockOssCheckTasksListResponseBodyItemsConfig Config { get; set; }
            public class GetStockOssCheckTasksListResponseBodyItemsConfig : TeaModel {
                [NameInMap("CallbackId")]
                [Validation(Required=false)]
                public long? CallbackId { get; set; }

                [NameInMap("DistinctHistoryTasks")]
                [Validation(Required=false)]
                public bool? DistinctHistoryTasks { get; set; }

                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                [NameInMap("ExecuteDate")]
                [Validation(Required=false)]
                public int? ExecuteDate { get; set; }

                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                [NameInMap("Freeze")]
                [Validation(Required=false)]
                public bool? Freeze { get; set; }

                [NameInMap("FreezeHighRisk1")]
                [Validation(Required=false)]
                public bool? FreezeHighRisk1 { get; set; }

                [NameInMap("FreezeHighRisk2")]
                [Validation(Required=false)]
                public bool? FreezeHighRisk2 { get; set; }

                [NameInMap("FreezeMediumRisk1")]
                [Validation(Required=false)]
                public bool? FreezeMediumRisk1 { get; set; }

                [NameInMap("FreezeMediumRisk2")]
                [Validation(Required=false)]
                public bool? FreezeMediumRisk2 { get; set; }

                [NameInMap("FreezeType")]
                [Validation(Required=false)]
                public string FreezeType { get; set; }

                [NameInMap("PrefixFilterType")]
                [Validation(Required=false)]
                public string PrefixFilterType { get; set; }

                [NameInMap("PrefixFilters")]
                [Validation(Required=false)]
                public List<string> PrefixFilters { get; set; }

                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("ScanLimit")]
                [Validation(Required=false)]
                public long? ScanLimit { get; set; }

                [NameInMap("ScanNoFileType")]
                [Validation(Required=false)]
                public bool? ScanNoFileType { get; set; }

                [NameInMap("ScanResourceType")]
                [Validation(Required=false)]
                public int? ScanResourceType { get; set; }

                [NameInMap("ScanService")]
                [Validation(Required=false)]
                public List<string> ScanService { get; set; }

                [NameInMap("ScanServiceInfos")]
                [Validation(Required=false)]
                public List<GetStockOssCheckTasksListResponseBodyItemsConfigScanServiceInfos> ScanServiceInfos { get; set; }
                public class GetStockOssCheckTasksListResponseBodyItemsConfigScanServiceInfos : TeaModel {
                    [NameInMap("CopyFrom")]
                    [Validation(Required=false)]
                    public string CopyFrom { get; set; }

                    [NameInMap("IsCopy")]
                    [Validation(Required=false)]
                    public bool? IsCopy { get; set; }

                    [NameInMap("ServiceCode")]
                    [Validation(Required=false)]
                    public string ServiceCode { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                [NameInMap("TaskCycle")]
                [Validation(Required=false)]
                public int? TaskCycle { get; set; }

            }

            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("FinishNum")]
            [Validation(Required=false)]
            public long? FinishNum { get; set; }

            [NameInMap("IsInc")]
            [Validation(Required=false)]
            public bool? IsInc { get; set; }

            [NameInMap("LastExecuteDate")]
            [Validation(Required=false)]
            public string LastExecuteDate { get; set; }

            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public int? MediaType { get; set; }

            [NameInMap("NextExecuteDate")]
            [Validation(Required=false)]
            public string NextExecuteDate { get; set; }

            [NameInMap("ObjectNum")]
            [Validation(Required=false)]
            public long? ObjectNum { get; set; }

            [NameInMap("SearchNum")]
            [Validation(Required=false)]
            public long? SearchNum { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
