// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range during which the jobs to be queried were created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The order that you use to sort the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateTimeDesc: sorts the query results by creation time in descending order.</description></item>
        /// <item><description>CreateTimeAsc: sorts the query results by creation time in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTimeDesc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 0 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7b38a5d86f1e47838927b6e7ccb1****</para>
        /// </summary>
        [NameInMap("ParentJobId")]
        [Validation(Required=false)]
        public string ParentJobId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the jobs to be queried were created. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <para>The state of the job.</para>
        /// <list type="bullet">
        /// <item><description>Init: The job is submitted.</description></item>
        /// <item><description>Success: The job is successful.</description></item>
        /// <item><description>Fail: The job failed.</description></item>
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
