// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetStockOssCheckTasksListResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetStockOssCheckTasksListResponseBodyItems> Items { get; set; }
        public class GetStockOssCheckTasksListResponseBodyItems : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>tmp</para>
            /// </summary>
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

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DistinctHistoryTasks")]
                [Validation(Required=false)]
                public bool? DistinctHistoryTasks { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-01-10 11:42:31</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteDate")]
                [Validation(Required=false)]
                public int? ExecuteDate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>02:00:00</para>
                /// </summary>
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

                [NameInMap("FreezeRestorePath")]
                [Validation(Required=false)]
                public string FreezeRestorePath { get; set; }

                [NameInMap("FreezeType")]
                [Validation(Required=false)]
                public string FreezeType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("PrefixFilterType")]
                [Validation(Required=false)]
                public string PrefixFilterType { get; set; }

                [NameInMap("PrefixFilters")]
                [Validation(Required=false)]
                public List<string> PrefixFilters { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                [NameInMap("Referer")]
                [Validation(Required=false)]
                public string Referer { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ScanLimit")]
                [Validation(Required=false)]
                public long? ScanLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ScanNoFileType")]
                [Validation(Required=false)]
                public bool? ScanNoFileType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
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
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>baselineCheck</para>
                    /// </summary>
                    [NameInMap("CopyFrom")]
                    [Validation(Required=false)]
                    public string CopyFrom { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCopy")]
                    [Validation(Required=false)]
                    public bool? IsCopy { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>baselineCheck_01</para>
                    /// </summary>
                    [NameInMap("ServiceCode")]
                    [Validation(Required=false)]
                    public string ServiceCode { get; set; }

                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2023-12-21 15:30:19</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskCycle")]
                [Validation(Required=false)]
                public int? TaskCycle { get; set; }

                [NameInMap("UserFreezeConfig")]
                [Validation(Required=false)]
                public GetStockOssCheckTasksListResponseBodyItemsConfigUserFreezeConfig UserFreezeConfig { get; set; }
                public class GetStockOssCheckTasksListResponseBodyItemsConfigUserFreezeConfig : TeaModel {
                    [NameInMap("FreezeRestorePath")]
                    [Validation(Required=false)]
                    public string FreezeRestorePath { get; set; }

                    [NameInMap("FreezeType")]
                    [Validation(Required=false)]
                    public string FreezeType { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2024-01-10 11:42:31</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FinishNum")]
            [Validation(Required=false)]
            public long? FinishNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsInc")]
            [Validation(Required=false)]
            public bool? IsInc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("LastExecuteDate")]
            [Validation(Required=false)]
            public string LastExecuteDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public int? MediaType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("NextExecuteDate")]
            [Validation(Required=false)]
            public string NextExecuteDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ObjectNum")]
            [Validation(Required=false)]
            public long? ObjectNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SearchNum")]
            [Validation(Required=false)]
            public long? SearchNum { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2023-12-21 15:30:19</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>P_XHDUS</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>batch</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
