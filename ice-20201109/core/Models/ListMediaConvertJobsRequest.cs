// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListMediaConvertJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to filter jobs by creation time. The time must be in the <c>yyyy-MM-ddTHH:mm:ssZ</c> ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-15T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// <para>Filters the results by job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2****</para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The token for the next page of results. Leave this empty for the first request. To retrieve the next page, pass the <c>NextPageToken</c> value from the previous response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab4802364a2e49208c99efab82dfa8e8</para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The sort order for the results. Valid values: <c>CreateTimeDesc</c> (descending by creation time) and <c>CreateTimeAsc</c> (ascending by creation time).</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreateTimeDesc</para>
        /// </summary>
        [NameInMap("OrderBy")]
        [Validation(Required=false)]
        public string OrderBy { get; set; }

        /// <summary>
        /// <para>The page size. Valid values: 1 to 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The start of the time range to filter jobs by creation time. The time must be in the <c>yyyy-MM-ddTHH:mm:ssZ</c> ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-01T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <para>The status of the job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>Inited</c>: The job has been submitted.</para>
        /// </description></item>
        /// <item><description><para><c>Running</c>: The job is running.</para>
        /// </description></item>
        /// <item><description><para><c>Complete</c>: The job is complete.</para>
        /// </description></item>
        /// <item><description><para><c>Error</c>: The job failed due to an error.</para>
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
