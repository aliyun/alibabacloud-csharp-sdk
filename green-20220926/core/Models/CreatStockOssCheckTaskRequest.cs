// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreatStockOssCheckTaskRequest : TeaModel {
        /// <summary>
        /// <para>OSS buckets</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Bucket\&quot;:\&quot;bucket01-test\&quot;,\&quot;Region\&quot;:\&quot;cn-beijing\&quot;}]</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <para>Callback ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1751</para>
        /// </summary>
        [NameInMap("CallbackId")]
        [Validation(Required=false)]
        public string CallbackId { get; set; }

        /// <summary>
        /// <para>Flag for deduplicating against previously detected tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DistinctHistoryTasks")]
        [Validation(Required=false)]
        public bool? DistinctHistoryTasks { get; set; }

        /// <summary>
        /// <para>The end time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-18 10:08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Execute date of scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ExecuteDate")]
        [Validation(Required=false)]
        public int? ExecuteDate { get; set; }

        /// <summary>
        /// <para>Execute time of scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01:09:30-01:19:30</para>
        /// </summary>
        [NameInMap("ExecuteTime")]
        [Validation(Required=false)]
        public string ExecuteTime { get; set; }

        /// <summary>
        /// <para>Freeze indicator</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Freeze")]
        [Validation(Required=false)]
        public bool? Freeze { get; set; }

        /// <summary>
        /// <para>Freeze High-Risk Images</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreezeHighRisk1")]
        [Validation(Required=false)]
        public bool? FreezeHighRisk1 { get; set; }

        /// <summary>
        /// <para>Freeze High-Risk Audio and Text</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreezeHighRisk2")]
        [Validation(Required=false)]
        public bool? FreezeHighRisk2 { get; set; }

        /// <summary>
        /// <para>Freeze Medium-Risk Images</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreezeMediumRisk1")]
        [Validation(Required=false)]
        public bool? FreezeMediumRisk1 { get; set; }

        /// <summary>
        /// <para>Freeze Medium-Risk Audio and Text</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("FreezeMediumRisk2")]
        [Validation(Required=false)]
        public bool? FreezeMediumRisk2 { get; set; }

        /// <summary>
        /// <para>Freeze Restore Path</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("FreezeRestorePath")]
        [Validation(Required=false)]
        public string FreezeRestorePath { get; set; }

        /// <summary>
        /// <para>Freeze type</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACL</para>
        /// </summary>
        [NameInMap("FreezeType")]
        [Validation(Required=false)]
        public string FreezeType { get; set; }

        /// <summary>
        /// <para>Indicator for scheduled task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsInc")]
        [Validation(Required=false)]
        public bool? IsInc { get; set; }

        /// <summary>
        /// <para>Media type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <para>Prefix filter type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("PrefixFilterType")]
        [Validation(Required=false)]
        public string PrefixFilterType { get; set; }

        /// <summary>
        /// <para>Prefix filters</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir1,dir2</para>
        /// </summary>
        [NameInMap("PrefixFilters")]
        [Validation(Required=false)]
        public string PrefixFilters { get; set; }

        /// <summary>
        /// <para>The priority of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Referer.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.aliyun.com">https://www.aliyun.com</a></para>
        /// </summary>
        [NameInMap("Referer")]
        [Validation(Required=false)]
        public string Referer { get; set; }

        /// <summary>
        /// <para>Region ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The scan limit of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ScanLimit")]
        [Validation(Required=false)]
        public long? ScanLimit { get; set; }

        /// <summary>
        /// <para>Indicator for scanning files without file type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScanNoFileType")]
        [Validation(Required=false)]
        public bool? ScanNoFileType { get; set; }

        /// <summary>
        /// <para>Scan resource type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ScanResourceType")]
        [Validation(Required=false)]
        public string ScanResourceType { get; set; }

        /// <summary>
        /// <para>The code of scan service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <para>The start time of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-17 10:08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Task Cycle</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TaskCycle")]
        [Validation(Required=false)]
        public int? TaskCycle { get; set; }

        /// <summary>
        /// <para>The name of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image task 20240709101602004</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>Task type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>batch</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
