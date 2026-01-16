// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreatePreCheckRequest : TeaModel {
        [NameInMap("BucketPrefixFilterConfig")]
        [Validation(Required=false)]
        public string BucketPrefixFilterConfig { get; set; }

        /// <summary>
        /// <para>Buckets.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;Bucket\&quot;:\&quot;bucket01-test\&quot;,\&quot;Region\&quot;:\&quot;cn-beijing\&quot;}]</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <para>Whether to deduplicate historical detected tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DistinctHistoryTasks")]
        [Validation(Required=false)]
        public bool? DistinctHistoryTasks { get; set; }

        /// <summary>
        /// <para>Task end time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-18 10:08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Whether it is a scheduled scan task.</para>
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
        /// <para>Prefixes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dir1,dir2</para>
        /// </summary>
        [NameInMap("PrefixFilters")]
        [Validation(Required=false)]
        public string PrefixFilters { get; set; }

        /// <summary>
        /// <para>Priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Scan limit count.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("ScanLimit")]
        [Validation(Required=false)]
        public long? ScanLimit { get; set; }

        /// <summary>
        /// <para>Whether to scan images without file extensions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ScanNoFileType")]
        [Validation(Required=false)]
        public bool? ScanNoFileType { get; set; }

        /// <summary>
        /// <para>Scan service code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <para>Task start time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-12-17 10:08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>图片任务 20240709101602004</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
