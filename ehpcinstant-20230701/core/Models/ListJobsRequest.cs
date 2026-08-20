// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListJobsRequest : TeaModel {
        /// <summary>
        /// <para>The filter conditions for querying jobs.</para>
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

            [NameInMap("JobIds")]
            [Validation(Required=false)]
            public List<string> JobIds { get; set; }

            /// <summary>
            /// <para>The name of the job. Fuzzy search is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>jt-xxxx</para>
            /// </summary>
            [NameInMap("JobTemplateId")]
            [Validation(Required=false)]
            public string JobTemplateId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MyPool</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Pending: The job is in the queue.</para>
            /// </description></item>
            /// <item><description><para>Initing: The job is initializing.</para>
            /// </description></item>
            /// <item><description><para>Succeeded: The job was successful.</para>
            /// </description></item>
            /// <item><description><para>Failed: The job failed.</para>
            /// </description></item>
            /// <item><description><para>Running: The job is running.</para>
            /// </description></item>
            /// <item><description><para>Exception: A scheduling exception occurred.</para>
            /// </description></item>
            /// <item><description><para>Retrying: The job is being retried.</para>
            /// </description></item>
            /// <item><description><para>Expired: The job timed out.</para>
            /// </description></item>
            /// <item><description><para>Suspended: The job is in hibernation.</para>
            /// </description></item>
            /// <item><description><para>Restarting: The job is restarting.</para>
            /// </description></item>
            /// <item><description><para>Deleted: The job is deleted.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListJobsRequestFilterTag> Tag { get; set; }
            public class ListJobsRequestFilterTag : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time after which the jobs were submitted. This is a UNIX timestamp based on the local time of the region. For sites in the Chinese mainland, the time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>The time before which the jobs were submitted. This is a UNIX timestamp based on the local time of the region. For sites in the Chinese mainland, the time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeCreatedBefore")]
            [Validation(Required=false)]
            public int? TimeCreatedBefore { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// <para>Start value: 1</para>
        /// <para>Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. The default value is 50. The maximum value is 100.</para>
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
            /// <para>The field to sort by. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>time_start</para>
            /// </description></item>
            /// <item><description><para>job_name</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>time_start</para>
            /// </summary>
            [NameInMap("Label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            /// <summary>
            /// <para>The sort order. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>ASC (default): Ascending</para>
            /// </description></item>
            /// <item><description><para>DESC: Descending</para>
            /// </description></item>
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
