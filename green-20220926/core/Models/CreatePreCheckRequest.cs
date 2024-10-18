// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class CreatePreCheckRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>[{\&quot;Bucket\&quot;:\&quot;bucket01-test\&quot;,\&quot;Region\&quot;:\&quot;cn-beijing\&quot;}]</para>
        /// </summary>
        [NameInMap("Buckets")]
        [Validation(Required=false)]
        public string Buckets { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DistinctHistoryTasks")]
        [Validation(Required=false)]
        public bool? DistinctHistoryTasks { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-12-18 10:08:00</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IsInc")]
        [Validation(Required=false)]
        public bool? IsInc { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public int? MediaType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>all</para>
        /// </summary>
        [NameInMap("PrefixFilterType")]
        [Validation(Required=false)]
        public string PrefixFilterType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dir1,dir2</para>
        /// </summary>
        [NameInMap("PrefixFilters")]
        [Validation(Required=false)]
        public string PrefixFilters { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

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
        /// <para>baselineCheck</para>
        /// </summary>
        [NameInMap("ScanService")]
        [Validation(Required=false)]
        public string ScanService { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2023-12-17 10:08:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

    }

}
