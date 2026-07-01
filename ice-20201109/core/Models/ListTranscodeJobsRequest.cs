// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTranscodeJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to filter jobs by their creation time. The time must be in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// <para>The token for the next page of results. Not required for the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82df****</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>CreateTimeDesc</c>: Sorts by creation time in descending order.</para>
        /// </description></item>
        /// <item><description><para><c>CreateTimeAsc</c>: Sorts by creation time in ascending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTimeDesc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1-100. Default: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Filters by job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7b38a5d86f1e47838927b6e7ccb1****</para>
        /// </summary>
        [NameInMap("ParentJobId")]
        [Validation(Required=false)]
        public string ParentJobId { get; set; }

        /// <summary>
        /// <para>The start of the time range to filter jobs by their creation time. The time must be in UTC and formatted as <c>yyyy-MM-ddTHH:mm:ssZ</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <para>The job status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Init</c>: Submitted.</para>
        /// </description></item>
        /// <item><description><para><c>Success</c>: Succeeded.</para>
        /// </description></item>
        /// <item><description><para><c>Fail</c>: Failed.</para>
        /// </description></item>
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
