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
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>Filters jobs by a list of job IDs. A maximum of 100 job IDs are supported.</para>
            /// </summary>
            [NameInMap("JobIds")]
            [Validation(Required=false)]
            public List<string> JobIds { get; set; }

            /// <summary>
            /// <para>The job name. Fuzzy match is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The ID of the job template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jt-xxxx</para>
            /// </summary>
            [NameInMap("JobTemplateId")]
            [Validation(Required=false)]
            public string JobTemplateId { get; set; }

            /// <summary>
            /// <para>The name of the resource pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MyPool</para>
            /// </summary>
            [NameInMap("PoolName")]
            [Validation(Required=false)]
            public string PoolName { get; set; }

            /// <summary>
            /// <para>The job status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Pending: The job is queued.</description></item>
            /// <item><description>Initing: The job is being initialized.</description></item>
            /// <item><description>Succeeded: The job ran successfully.</description></item>
            /// <item><description>Failed: The job failed to run.</description></item>
            /// <item><description>Running: The job is running.</description></item>
            /// <item><description>Exception: A scheduling exception occurred.</description></item>
            /// <item><description>Retrying: The job is being retried.</description></item>
            /// <item><description>Expired: The job timed out.</description></item>
            /// <item><description>Suspended: The job is hibernated.</description></item>
            /// <item><description>Restarting: The job is being restarted.</description></item>
            /// <item><description>Deleted: The job is deleted.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The list of job tags.</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public List<ListJobsRequestFilterTag> Tag { get; set; }
            public class ListJobsRequestFilterTag : TeaModel {
                /// <summary>
                /// <para>The key of the job tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The value of the job tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The time after which jobs were submitted. The time is converted to a UNIX timestamp based on the time zone of the region. For regions in the Chinese mainland, the time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703819914</para>
            /// </summary>
            [NameInMap("TimeCreatedAfter")]
            [Validation(Required=false)]
            public int? TimeCreatedAfter { get; set; }

            /// <summary>
            /// <para>The time before which jobs were submitted. The time is converted to a UNIX timestamp based on the time zone of the region. For regions in the Chinese mainland, the time zone is UTC+8.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1703820113</para>
            /// </summary>
            [NameInMap("TimeCreatedBefore")]
            [Validation(Required=false)]
            public int? TimeCreatedBefore { get; set; }

        }

        /// <summary>
        /// <para>The page number. Starting value: 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The paging Settings for the number of entries per page in a paged query. Default value: 50. Maximum value: 100.</para>
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
            /// <item><description>ASC: ascending order. This is the default value.</description></item>
            /// <item><description>DESC: descending order.</description></item>
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
