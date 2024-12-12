// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveSnapshotJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>By default, EndTime is seven days later than StartTime.</description></item>
        /// <item><description>The time range specified by the StartTime and EndTime parameters cannot exceed 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Valid values: [1,n). Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword. You can use the job ID or name as the keyword to search for jobs. If you search for jobs by name, fuzzy match is supported.</para>
        /// <list type="bullet">
        /// <item><description>It cannot exceed 128 characters in length.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// <para>The sorting order. By default, the query results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: sorts the query results by creation time in ascending order.</description></item>
        /// <item><description>desc: sorts the query results by creation time in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description>The default value is seven days ago.</description></item>
        /// <item><description>The time range specified by the StartTime and EndTime parameters cannot exceed 30 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job state filter. By default, all jobs are queried.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>init: The job is not started.</description></item>
        /// <item><description>paused: The job is paused.</description></item>
        /// <item><description>started: The job is in progress.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
