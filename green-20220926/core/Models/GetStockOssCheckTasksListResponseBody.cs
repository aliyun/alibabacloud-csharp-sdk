// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetStockOssCheckTasksListResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The data on the current page.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<GetStockOssCheckTasksListResponseBodyItems> Items { get; set; }
        public class GetStockOssCheckTasksListResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The OSS bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tmp</para>
            /// </summary>
            [NameInMap("Buckets")]
            [Validation(Required=false)]
            public string Buckets { get; set; }

            /// <summary>
            /// <para>The configuration item.</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public GetStockOssCheckTasksListResponseBodyItemsConfig Config { get; set; }
            public class GetStockOssCheckTasksListResponseBodyItemsConfig : TeaModel {
                /// <summary>
                /// <para>The callback notification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3942</para>
                /// </summary>
                [NameInMap("CallbackId")]
                [Validation(Required=false)]
                public long? CallbackId { get; set; }

                /// <summary>
                /// <para>Specifies whether to deduplicate historically scanned tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("DistinctHistoryTasks")]
                [Validation(Required=false)]
                public bool? DistinctHistoryTasks { get; set; }

                /// <summary>
                /// <para>The end time. Format: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2024-01-10 11:42:31</para>
                /// </summary>
                [NameInMap("EndTime")]
                [Validation(Required=false)]
                public string EndTime { get; set; }

                /// <summary>
                /// <para>The execution date of the scheduled task.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ExecuteDate")]
                [Validation(Required=false)]
                public int? ExecuteDate { get; set; }

                /// <summary>
                /// <para>The expected execution time of the scheduled task. Format: HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>02:00:00</para>
                /// </summary>
                [NameInMap("ExecuteTime")]
                [Validation(Required=false)]
                public string ExecuteTime { get; set; }

                /// <summary>
                /// <para>Specifies whether to freeze files.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Freeze")]
                [Validation(Required=false)]
                public bool? Freeze { get; set; }

                /// <summary>
                /// <para>Specifies whether to freeze high-risk images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FreezeHighRisk1")]
                [Validation(Required=false)]
                public bool? FreezeHighRisk1 { get; set; }

                /// <summary>
                /// <para>Specifies whether to freeze high-risk audio and text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FreezeHighRisk2")]
                [Validation(Required=false)]
                public bool? FreezeHighRisk2 { get; set; }

                /// <summary>
                /// <para>Specifies whether to freeze medium-risk images.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FreezeMediumRisk1")]
                [Validation(Required=false)]
                public bool? FreezeMediumRisk1 { get; set; }

                /// <summary>
                /// <para>Specifies whether to freeze medium-risk audio and text.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("FreezeMediumRisk2")]
                [Validation(Required=false)]
                public bool? FreezeMediumRisk2 { get; set; }

                /// <summary>
                /// <para>The transfer path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>/backup</para>
                /// </summary>
                [NameInMap("FreezeRestorePath")]
                [Validation(Required=false)]
                public string FreezeRestorePath { get; set; }

                /// <summary>
                /// <para>The freeze type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ACL</para>
                /// </summary>
                [NameInMap("FreezeType")]
                [Validation(Required=false)]
                public string FreezeType { get; set; }

                /// <summary>
                /// <para>The prefix filter type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>all</para>
                /// </summary>
                [NameInMap("PrefixFilterType")]
                [Validation(Required=false)]
                public string PrefixFilterType { get; set; }

                /// <summary>
                /// <para>The prefix.</para>
                /// </summary>
                [NameInMap("PrefixFilters")]
                [Validation(Required=false)]
                public List<string> PrefixFilters { get; set; }

                /// <summary>
                /// <para>The priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>Referer。</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Referer")]
                [Validation(Required=false)]
                public string Referer { get; set; }

                /// <summary>
                /// <para>The maximum number of files to scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("ScanLimit")]
                [Validation(Required=false)]
                public long? ScanLimit { get; set; }

                /// <summary>
                /// <para>Specifies whether to scan images without file name extensions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("ScanNoFileType")]
                [Validation(Required=false)]
                public bool? ScanNoFileType { get; set; }

                /// <summary>
                /// <para>The type of files to scan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ScanResourceType")]
                [Validation(Required=false)]
                public int? ScanResourceType { get; set; }

                /// <summary>
                /// <para>The scan service code.</para>
                /// </summary>
                [NameInMap("ScanService")]
                [Validation(Required=false)]
                public List<string> ScanService { get; set; }

                /// <summary>
                /// <para>The scan service information.</para>
                /// </summary>
                [NameInMap("ScanServiceInfos")]
                [Validation(Required=false)]
                public List<GetStockOssCheckTasksListResponseBodyItemsConfigScanServiceInfos> ScanServiceInfos { get; set; }
                public class GetStockOssCheckTasksListResponseBodyItemsConfigScanServiceInfos : TeaModel {
                    /// <summary>
                    /// <para>The primary service.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>baselineCheck</para>
                    /// </summary>
                    [NameInMap("CopyFrom")]
                    [Validation(Required=false)]
                    public string CopyFrom { get; set; }

                    /// <summary>
                    /// <para>Indicates whether the service is a copy.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsCopy")]
                    [Validation(Required=false)]
                    public bool? IsCopy { get; set; }

                    /// <summary>
                    /// <para>The service code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>baselineCheck_01</para>
                    /// </summary>
                    [NameInMap("ServiceCode")]
                    [Validation(Required=false)]
                    public string ServiceCode { get; set; }

                    /// <summary>
                    /// <para>The service name.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>通用基线检测</para>
                    /// </summary>
                    [NameInMap("ServiceName")]
                    [Validation(Required=false)]
                    public string ServiceName { get; set; }

                }

                /// <summary>
                /// <para>The start time. Format: YYYY-MM-DD HH:mm:ss.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-12-21 15:30:19</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The scheduling date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("TaskCycle")]
                [Validation(Required=false)]
                public int? TaskCycle { get; set; }

                /// <summary>
                /// <para>The manual freeze configuration.</para>
                /// </summary>
                [NameInMap("UserFreezeConfig")]
                [Validation(Required=false)]
                public GetStockOssCheckTasksListResponseBodyItemsConfigUserFreezeConfig UserFreezeConfig { get; set; }
                public class GetStockOssCheckTasksListResponseBodyItemsConfigUserFreezeConfig : TeaModel {
                    /// <summary>
                    /// <para>The transfer path.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/backup</para>
                    /// </summary>
                    [NameInMap("FreezeRestorePath")]
                    [Validation(Required=false)]
                    public string FreezeRestorePath { get; set; }

                    /// <summary>
                    /// <para>The freeze type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>ACL</para>
                    /// </summary>
                    [NameInMap("FreezeType")]
                    [Validation(Required=false)]
                    public string FreezeType { get; set; }

                }

            }

            /// <summary>
            /// <para>The end time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-10 11:42:31</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The number of completed tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("FinishNum")]
            [Validation(Required=false)]
            public long? FinishNum { get; set; }

            /// <summary>
            /// <para>Indicates whether the task is a scheduled scan task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsInc")]
            [Validation(Required=false)]
            public bool? IsInc { get; set; }

            /// <summary>
            /// <para>The next execution time of the scheduled task. Format: HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("LastExecuteDate")]
            [Validation(Required=false)]
            public string LastExecuteDate { get; set; }

            /// <summary>
            /// <para>The media asset type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>video</para>
            /// </summary>
            [NameInMap("MediaType")]
            [Validation(Required=false)]
            public int? MediaType { get; set; }

            /// <summary>
            /// <para>The last execution time of the scheduled task. Format: HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>02:00:00</para>
            /// </summary>
            [NameInMap("NextExecuteDate")]
            [Validation(Required=false)]
            public string NextExecuteDate { get; set; }

            /// <summary>
            /// <para>The total number of files in the bucket.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("ObjectNum")]
            [Validation(Required=false)]
            public long? ObjectNum { get; set; }

            /// <summary>
            /// <para>The number of scan tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SearchNum")]
            [Validation(Required=false)]
            public long? SearchNum { get; set; }

            /// <summary>
            /// <para>The start time. Format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-12-21 15:30:19</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The task status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>P_XHDUS</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <para>The task name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>图片定时任务20231205135716797</para>
            /// </summary>
            [NameInMap("TaskName")]
            [Validation(Required=false)]
            public string TaskName { get; set; }

            /// <summary>
            /// <para>The task type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>batch</para>
            /// </summary>
            [NameInMap("TaskType")]
            [Validation(Required=false)]
            public string TaskType { get; set; }

        }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
