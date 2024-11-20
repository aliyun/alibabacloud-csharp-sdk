// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaProducingJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The maximum time range between EndTime and StartTime cannot exceed 30 days. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The job type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LiveEditingJob: live editing job.</description></item>
        /// <item><description>EditingJob: regular template-based editing job</description></item>
        /// <item><description>VETemplateJob: advanced template-based editing job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EditingJob</para>
        /// </summary>
        [NameInMap("JobType")]
        [Validation(Required=false)]
        public string JobType { get; set; }

        /// <summary>
        /// <para>The search keyword. For example, you can use a job ID as the keyword to search for jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The ID of the quick video production job. If this parameter is specified, the subjobs of the quick video production job are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>8750b54e3c976a47da6f</b></b></b></para>
        /// </summary>
        [NameInMap("MasterJobId")]
        [Validation(Required=false)]
        public string MasterJobId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return.</para>
        /// <para>Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8EqYpQbZ6Eh7+Zz8DxVYoQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>927cfb53d05b96c1bfe1</b></b></b></para>
        /// </summary>
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        /// <summary>
        /// <para>The sorting parameter. By default, the query results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreationTime:Asc: sorted by creation time in ascending order.</description></item>
        /// <item><description>CreationTime:Desc: sorted by creation time in descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The job state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Init: The job is initialized.</description></item>
        /// <item><description>Failed: The job failed.</description></item>
        /// <item><description>Success: The job is successful.</description></item>
        /// <item><description>Processing: The job is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
