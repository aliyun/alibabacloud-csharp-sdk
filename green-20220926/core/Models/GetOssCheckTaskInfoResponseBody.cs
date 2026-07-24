// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The OSS buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Bucket\&quot;:\&quot;aileshijie\&quot;,\&quot;Region\&quot;:\&quot;cn-hangzhou\&quot;}]</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <para>The configuration item.</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetOssCheckTaskInfoResponseBodyConfig Config { get; set; }
        public class GetOssCheckTaskInfoResponseBodyConfig : TeaModel {
            /// <summary>
            /// <para>The filter configuration for each bucket. The key is the bucket name, and the value is the filter configuration, which includes prefix and suffix filters and filter character lists.</para>
            /// </summary>
            [NameInMap("BucketPrefixFilterConfig")]
            [Validation(Required=false)]
            public Dictionary<string, ConfigBucketPrefixFilterConfigValue> BucketPrefixFilterConfig { get; set; }

            /// <summary>
            /// <para>The callback notification ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>188</para>
            /// </summary>
            [NameInMap("CallbackId")]
            [Validation(Required=false)]
            public long? CallbackId { get; set; }

            /// <summary>
            /// <para>Indicates whether to deduplicate historically scanned tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DistinctHistoryTasks")]
            [Validation(Required=false)]
            public bool? DistinctHistoryTasks { get; set; }

            /// <summary>
            /// <para>The end time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-09 10:30:00</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The execution date of the scheduled task. The value is an integer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecuteDate")]
            [Validation(Required=false)]
            public int? ExecuteDate { get; set; }

            /// <summary>
            /// <para>The estimated execution time of the scheduled task. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-07-09 10:30:00</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            /// <summary>
            /// <para>Indicates whether freezing is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Freeze")]
            [Validation(Required=false)]
            public bool? Freeze { get; set; }

            /// <summary>
            /// <para>Indicates whether to freeze high-risk images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreezeHighRisk1")]
            [Validation(Required=false)]
            public bool? FreezeHighRisk1 { get; set; }

            /// <summary>
            /// <para>Indicates whether to freeze high-risk audio and text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreezeHighRisk2")]
            [Validation(Required=false)]
            public bool? FreezeHighRisk2 { get; set; }

            /// <summary>
            /// <para>Indicates whether to freeze medium-risk images.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreezeMediumRisk1")]
            [Validation(Required=false)]
            public bool? FreezeMediumRisk1 { get; set; }

            /// <summary>
            /// <para>Indicates whether to freeze medium-risk audio and text.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FreezeMediumRisk2")]
            [Validation(Required=false)]
            public bool? FreezeMediumRisk2 { get; set; }

            /// <summary>
            /// <para>The transfer path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
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
            /// <para>The prefixes.</para>
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
            /// <para><a href="https://www.aliyun.com/">https://www.aliyun.com/</a></para>
            /// </summary>
            [NameInMap("Referer")]
            [Validation(Required=false)]
            public string Referer { get; set; }

            /// <summary>
            /// <para>The scan limit.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("ScanLimit")]
            [Validation(Required=false)]
            public long? ScanLimit { get; set; }

            /// <summary>
            /// <para>Indicates whether to scan images without file extensions.</para>
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
            public List<GetOssCheckTaskInfoResponseBodyConfigScanServiceInfos> ScanServiceInfos { get; set; }
            public class GetOssCheckTaskInfoResponseBodyConfigScanServiceInfos : TeaModel {
                /// <summary>
                /// <para>The primary service.</para>
                /// 
                /// <b>Example:</b>
                /// <para>oss_baselineCheck</para>
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
                /// <para>oss_baselineCheck</para>
                /// </summary>
                [NameInMap("ServiceCode")]
                [Validation(Required=false)]
                public string ServiceCode { get; set; }

                /// <summary>
                /// <para>The service name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>内容检测</para>
                /// </summary>
                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

            }

            /// <summary>
            /// <para>The start time. The format is YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-08-21 16:08:38</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The scheduling date.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskCycle")]
            [Validation(Required=false)]
            public int? TaskCycle { get; set; }

            /// <summary>
            /// <para>The user freeze configuration.</para>
            /// </summary>
            [NameInMap("UserFreezeConfig")]
            [Validation(Required=false)]
            public GetOssCheckTaskInfoResponseBodyConfigUserFreezeConfig UserFreezeConfig { get; set; }
            public class GetOssCheckTaskInfoResponseBodyConfigUserFreezeConfig : TeaModel {
                /// <summary>
                /// <para>The transfer directory.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
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
        /// <para>The end time. The format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-09 10:30:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The number of completed tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>56</para>
        /// </summary>
        [NameInMap("FinishNum")]
        [Validation(Required=false)]
        public long? FinishNum { get; set; }

        /// <summary>
        /// <para>Indicates whether this is a scheduled scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsInc")]
        [Validation(Required=false)]
        public bool? IsInc { get; set; }

        /// <summary>
        /// <para>The next execution time of the scheduled task. The format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-09 10:30:00</para>
        /// </summary>
        [NameInMap("LastExecuteDate")]
        [Validation(Required=false)]
        public string LastExecuteDate { get; set; }

        /// <summary>
        /// <para>The media asset type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <para>The previous execution time of the scheduled task. The format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2025-07-08 10:30:00</para>
        /// </summary>
        [NameInMap("NextExecuteDate")]
        [Validation(Required=false)]
        public string NextExecuteDate { get; set; }

        /// <summary>
        /// <para>The total number of files in the bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ObjectNum")]
        [Validation(Required=false)]
        public long? ObjectNum { get; set; }

        /// <summary>
        /// <para>The ID assigned by the backend to uniquely identify a request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of scan tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SearchNum")]
        [Validation(Required=false)]
        public long? SearchNum { get; set; }

        /// <summary>
        /// <para>The start time. The format is YYYY-MM-DD HH:mm:ss.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-08-21 16:08:38</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx-xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>文档存量任务 20240914100517757</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>increment</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
