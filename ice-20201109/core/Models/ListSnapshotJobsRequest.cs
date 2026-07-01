// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListSnapshotJobsRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range during which the jobs to be queried were created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-14T00:00:00Z</para>
        /// </summary>
        [NameInMap("EndOfCreateTime")]
        [Validation(Required=false)]
        public string EndOfCreateTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("JobId")]
        [Validation(Required=false)]
        public string JobId { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("NextPageToken")]
        [Validation(Required=false)]
        public string NextPageToken { get; set; }

        /// <summary>
        /// <para>The order that you use to sort the query results.</para>
        /// <ol>
        /// <item><description><para>CreateTimeDesc</para>
        /// </description></item>
        /// <item><description><para>CreateTimeAsc</para>
        /// </description></item>
        /// </ol>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreateTimeDesc: sorts the jobs by creation time in descending order</para>
        /// </description></item>
        /// <item><description><para>CreateTimeAsc: sorts the jobs by creation time in ascending order.</para>
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
        /// <para>The number of entries per page. Default value: 20. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The beginning of the time range during which the jobs to be queried were created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-12T00:00:00Z</para>
        /// </summary>
        [NameInMap("StartOfCreateTime")]
        [Validation(Required=false)]
        public string StartOfCreateTime { get; set; }

        /// <summary>
        /// <para>The state of the job.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Init: The job is submitted.</para>
        /// </description></item>
        /// <item><description><para>Success: The job is successful.</para>
        /// </description></item>
        /// <item><description><para>Fail: The job failed.</para>
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
