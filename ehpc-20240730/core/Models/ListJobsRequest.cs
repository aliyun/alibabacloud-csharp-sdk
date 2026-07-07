// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-csbua72***</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The job filter information.</para>
        /// </summary>
        [NameInMap("JobFilter")]
        [Validation(Required=false)]
        public ListJobsRequestJobFilter JobFilter { get; set; }
        public class ListJobsRequestJobFilter : TeaModel {
            /// <summary>
            /// <para>The last update time of the job. The value is a UNIX timestamp representing the number of seconds that have elapsed since 1970-01-01T00:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724123085</para>
            /// </summary>
            [NameInMap("CreateTimeEnd")]
            [Validation(Required=false)]
            public string CreateTimeEnd { get; set; }

            /// <summary>
            /// <para>The start time of the job. The value is a UNIX timestamp representing the number of seconds that have elapsed since 1970-01-01T00:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1724122486</para>
            /// </summary>
            [NameInMap("CreateTimeStart")]
            [Validation(Required=false)]
            public string CreateTimeStart { get; set; }

            /// <summary>
            /// <para>The job diagnostic analysis list.</para>
            /// </summary>
            [NameInMap("Diagnosis")]
            [Validation(Required=false)]
            public List<ListJobsRequestJobFilterDiagnosis> Diagnosis { get; set; }
            public class ListJobsRequestJobFilterDiagnosis : TeaModel {
                /// <summary>
                /// <para>The comparison operator for the job diagnostic threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>greater</para>
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// <para>The job diagnostic analysis metric.</para>
                /// 
                /// <b>Example:</b>
                /// <para>run_duration</para>
                /// </summary>
                [NameInMap("Option")]
                [Validation(Required=false)]
                public string Option { get; set; }

                /// <summary>
                /// <para>The job diagnostic threshold.</para>
                /// 
                /// <b>Example:</b>
                /// <para>24</para>
                /// </summary>
                [NameInMap("Threshold")]
                [Validation(Required=false)]
                public string Threshold { get; set; }

            }

            /// <summary>
            /// <para>The job name. Fuzzy match is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testjob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>all: all statuses.</description></item>
            /// <item><description>finished: completed.</description></item>
            /// <item><description>notfinish: not completed.</description></item>
            /// </list>
            /// <para>Default value: all.</para>
            /// 
            /// <b>Example:</b>
            /// <para>all</para>
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

            /// <summary>
            /// <para>The list of compute nodes that run the jobs.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<string> Nodes { get; set; }

            /// <summary>
            /// <para>The list of queues that run the jobs.</para>
            /// </summary>
            [NameInMap("Queues")]
            [Validation(Required=false)]
            public List<string> Queues { get; set; }

            /// <summary>
            /// <para>The sorting configuration for the job list.</para>
            /// </summary>
            [NameInMap("SortBy")]
            [Validation(Required=false)]
            public ListJobsRequestJobFilterSortBy SortBy { get; set; }
            public class ListJobsRequestJobFilterSortBy : TeaModel {
                /// <summary>
                /// <para>Sorts jobs by execution time. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>asc: ascending order.</description></item>
                /// <item><description>desc: descending order.</description></item>
                /// </list>
                /// <para>Default value: desc.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asc</para>
                /// </summary>
                [NameInMap("ExecuteOrder")]
                [Validation(Required=false)]
                public string ExecuteOrder { get; set; }

                /// <summary>
                /// <para>Sorts jobs by queue wait time. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>asc: ascending order.</description></item>
                /// <item><description>desc: descending order.</description></item>
                /// </list>
                /// <para>Default value: desc.</para>
                /// 
                /// <b>Example:</b>
                /// <para>desc</para>
                /// </summary>
                [NameInMap("PendOrder")]
                [Validation(Required=false)]
                public string PendOrder { get; set; }

                /// <summary>
                /// <para>Sorts jobs by submission time. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>asc: ascending order.</description></item>
                /// <item><description>desc: descending order.</description></item>
                /// </list>
                /// <para>Default value: desc.</para>
                /// 
                /// <b>Example:</b>
                /// <para>asc</para>
                /// </summary>
                [NameInMap("SubmitOrder")]
                [Validation(Required=false)]
                public string SubmitOrder { get; set; }

            }

            /// <summary>
            /// <para>The list of users who run the jobs.</para>
            /// </summary>
            [NameInMap("Users")]
            [Validation(Required=false)]
            public List<string> Users { get; set; }

        }

        /// <summary>
        /// <para>The page number of the list.</para>
        /// <list type="bullet">
        /// <item><description>Minimum value: 1.</description></item>
        /// <item><description>Default value: 1.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public string PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page when using paged query. Paging is applied to the results.</para>
        /// <list type="bullet">
        /// <item><description>Maximum value: 50.</description></item>
        /// <item><description>Default value: 10.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

    }

}
