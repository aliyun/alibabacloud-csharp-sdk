// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>Queries job filter conditions.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public ListJobsRequestFilter Filter { get; set; }
        public class ListJobsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job name. Fuzzy search is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending</description></item>
            /// <item><description>initing</description></item>
            /// <item><description>Succeed</description></item>
            /// <item><description>Failed</description></item>
            /// <item><description>Running</description></item>
            /// <item><description>Exception</description></item>
            /// <item><description>Retrying</description></item>
            /// <item><description>Expired</description></item>
            /// <item><description>Suspended</description></item>
            /// <item><description>Restarting</description></item>
            /// <item><description>Deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>For jobs submitted after this time, the time in the region is converted into a UNIX timestamp (UI8).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>For jobs submitted before this time, the time in the region is converted into a Unix timestamp (for domestic sites, the UI8 region).</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeCreatedBefore")]
            [Validation(Required=false)]
            public int? TimeCreatedBefore { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries on the current page. Default value: 50. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting method.</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public ListJobsRequestSortBy SortBy { get; set; }
        public class ListJobsRequestSortBy : TeaModel {
            /// <summary>
            /// <para>The sorting label. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>time_start</description></item>
            /// <item><description>job_name</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>time_start</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The sorting order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>ASC (default): ascending order</description></item>
            /// <item><description>DESC: descending order</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ASC</para>
            /// </summary>
            [NameInMap("Order")]
            [Validation(Required=false)]
            public string Order { get; set; }

        }

    }

}
