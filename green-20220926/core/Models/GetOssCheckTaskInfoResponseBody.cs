// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetOssCheckTaskInfoResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;Bucket\&quot;:\&quot;aileshijie\&quot;,\&quot;Region\&quot;:\&quot;cn-hangzhou\&quot;}]</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        [NameInMap("Config")]
        [Validation(Required=false)]
        public GetOssCheckTaskInfoResponseBodyConfig Config { get; set; }
        public class GetOssCheckTaskInfoResponseBodyConfig : TeaModel {
            [NameInMap("BucketPrefixFilterConfig")]
            [Validation(Required=false)]
            public Dictionary<string, ConfigBucketPrefixFilterConfigValue> BucketPrefixFilterConfig { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>188</para>
            /// </summary>
            [NameInMap("CallbackId")]
            [Validation(Required=false)]
            public long? CallbackId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("DistinctHistoryTasks")]
            [Validation(Required=false)]
            public bool? DistinctHistoryTasks { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-07-09 10:30:00</para>
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
            /// <para>2025-07-09 10:30:00</para>
            /// </summary>
            [NameInMap("ExecuteTime")]
            [Validation(Required=false)]
            public string ExecuteTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Freeze")]
            [Validation(Required=false)]
            public bool? Freeze { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreezeHighRisk1")]
            [Validation(Required=false)]
            public bool? FreezeHighRisk1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreezeHighRisk2")]
            [Validation(Required=false)]
            public bool? FreezeHighRisk2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("FreezeMediumRisk1")]
            [Validation(Required=false)]
            public bool? FreezeMediumRisk1 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("FreezeMediumRisk2")]
            [Validation(Required=false)]
            public bool? FreezeMediumRisk2 { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("FreezeRestorePath")]
            [Validation(Required=false)]
            public string FreezeRestorePath { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ACL</para>
            /// </summary>
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
            /// <b>Example:</b>
            /// <para>100</para>
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
            public List<GetOssCheckTaskInfoResponseBodyConfigScanServiceInfos> ScanServiceInfos { get; set; }
            public class GetOssCheckTaskInfoResponseBodyConfigScanServiceInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>oss_baselineCheck</para>
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
                /// <para>oss_baselineCheck</para>
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
            /// <para>2023-08-21 16:08:38</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskCycle")]
            [Validation(Required=false)]
            public int? TaskCycle { get; set; }

            [NameInMap("UserFreezeConfig")]
            [Validation(Required=false)]
            public GetOssCheckTaskInfoResponseBodyConfigUserFreezeConfig UserFreezeConfig { get; set; }
            public class GetOssCheckTaskInfoResponseBodyConfigUserFreezeConfig : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("FreezeRestorePath")]
                [Validation(Required=false)]
                public string FreezeRestorePath { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ACL</para>
                /// </summary>
                [NameInMap("FreezeType")]
                [Validation(Required=false)]
                public string FreezeType { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-09 10:30:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>56</para>
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
        /// <para>2025-07-09 10:30:00</para>
        /// </summary>
        [NameInMap("LastExecuteDate")]
        [Validation(Required=false)]
        public string LastExecuteDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2025-07-08 10:30:00</para>
        /// </summary>
        [NameInMap("NextExecuteDate")]
        [Validation(Required=false)]
        public string NextExecuteDate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("ObjectNum")]
        [Validation(Required=false)]
        public long? ObjectNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SearchNum")]
        [Validation(Required=false)]
        public long? SearchNum { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-08-21 16:08:38</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxxx-xxx</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>increment</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
