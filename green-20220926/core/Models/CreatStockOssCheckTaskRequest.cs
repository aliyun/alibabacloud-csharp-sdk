// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreatStockOssCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>The filter configuration for each bucket. The value can be parsed as a JSON map. The key is the bucket name, and the value is the filter configuration, which includes prefix/suffix filters and a list of filter strings.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;{\&quot;test-bucket1\&quot;:{\&quot;prefixFilterType\&quot;:\&quot;include\&quot;,\&quot;prefixFilters\&quot;:[\&quot;test1\&quot;]},\&quot;test-bucket2\&quot;:{\&quot;prefixFilterType\&quot;:\&quot;exclude\&quot;,\&quot;prefixFilters\&quot;:[\&quot;test2\&quot;]}}&quot;</para>
        /// </summary>
        [NameInMap("BucketPrefixFilterConfig")]
        [Validation(Required=false)]
        public string BucketPrefixFilterConfig { get; set; }

        /// <summary>
        /// <para>The storage buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Bucket\&quot;:\&quot;bucket01-test\&quot;,\&quot;Region\&quot;:\&quot;cn-beijing\&quot;}]</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <para>The notification callback ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751</para>
        /// </summary>
        [NameInMap("CallbackId")]
        [Validation(Required=false)]
        public string CallbackId { get; set; }

        /// <summary>
        /// <para>Specifies whether to deduplicate against historically scanned tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DistinctHistoryTasks")]
        [Validation(Required=false)]
        public bool? DistinctHistoryTasks { get; set; }

        /// <summary>
        /// <para>The task end time. Format: <c>YYYY-MM-DD HH:mm:ss</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-18 10:08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The execution date of the scheduled task. The value is in integer format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecuteDate")]
        [Validation(Required=false)]
        public int? ExecuteDate { get; set; }

        /// <summary>
        /// <para>The expected execution time of the scheduled task. Format: <c>HH:mm:ss-HH:mm:ss</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:09:30-01:19:30</para>
        /// </summary>
        [NameInMap("ExecuteTime")]
        [Validation(Required=false)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// <para>Specifies whether to freeze files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
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
        /// <para>The path to which frozen files are transferred.</para>
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
        /// <para>Specifies whether the task is a scheduled scan task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsInc")]
        [Validation(Required=false)]
        public bool? IsInc { get; set; }

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
        /// 
        /// <b>Example:</b>
        /// <para>dir1,dir2</para>
        /// </summary>
        [NameInMap("PrefixFilters")]
        [Validation(Required=false)]
        public string PrefixFilters { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Referer。</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Referer")]
        [Validation(Required=false)]
        public string Referer { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>Specifies whether to scan images without file extensions.</para>
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
        public string ScanResourceType { get; set; }

        /// <summary>
        /// <para>The scan service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <para>The task start time. Format: <c>YYYY-MM-DD HH:mm:ss</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-17 10:08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The scheduling cycle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskCycle")]
        [Validation(Required=false)]
        public int? TaskCycle { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片任务 20240709101602004</para>
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

}
