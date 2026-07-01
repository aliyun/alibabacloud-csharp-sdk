// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListLiveSnapshotJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, the default is the current time.</para>
        /// </description></item>
        /// <item><description></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number to return. The value must be an integer greater than or equal to 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of jobs to return on each page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The search keyword. You can search by Job ID or Job Name. Fuzzy search is supported for Job Name.</para>
        /// <list type="bullet">
        /// <item><description>The maximum length is 128 characters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>a046-263c-3560-978a-fb287782</b></b></para>
        /// </summary>
        [NameInMap("SearchKeyWord")]
        [Validation(Required=false)]
        public string SearchKeyWord { get; set; }

        /// <summary>
        /// <para>The sort order. The results are sorted by <c>CreateTime</c>. Default: <c>desc</c> (Descending).</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start of the time range to query. Specify the time in the ISO 8601 format: <c>yyyy-MM-ddTHH:mm:ssZ</c>. The time must be in UTC.</para>
        /// <list type="bullet">
        /// <item><description><para>If this parameter is not specified, the default is 7 days ago.</para>
        /// </description></item>
        /// <item><description><para>The interval between <c>StartTime</c> and <c>EndTime</c> cannot exceed 30 days.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job status to filter by. If omitted, jobs of all statuses are returned.</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
