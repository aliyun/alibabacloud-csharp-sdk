// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EhpcInstant20230701.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs.</para>
        /// </summary>
        [NameInMap("JobList")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobList> JobList { get; set; }
        public class ListJobsResponseBodyJobList : TeaModel {
            /// <summary>
            /// <para>Additional information about the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;xxx\&quot;: \&quot;xxxxx\&quot;}</para>
            /// </summary>
            [NameInMap("AppExtraInfo")]
            [Validation(Required=false)]
            public string AppExtraInfo { get; set; }

            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alphafold3</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-25 12:29:21</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the job ended.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-25 12:35:23</para>
            /// </summary>
            [NameInMap("EndTime")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            /// <summary>
            /// <para>The number of running nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ExecutorCount")]
            [Validation(Required=false)]
            public int? ExecutorCount { get; set; }

            /// <summary>
            /// <para>The description of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Demo</para>
            /// </summary>
            [NameInMap("JobDescription")]
            [Validation(Required=false)]
            public string JobDescription { get; set; }

            /// <summary>
            /// <para>The ID of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job-xxx</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The UID of the user who created the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>129**********</para>
            /// </summary>
            [NameInMap("OwnerUid")]
            [Validation(Required=false)]
            public string OwnerUid { get; set; }

            /// <summary>
            /// <para>The time when the job started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-01-25 12:29:23</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the job. Possible values:</para>
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

            /// <summary>
            /// <para>The list of job tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListJobsResponseBodyJobListTags> Tags { get; set; }
            public class ListJobsResponseBodyJobListTags : TeaModel {
                /// <summary>
                /// <para>The key of the job tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestKey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The value of the job tag.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>The number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TaskCount")]
            [Validation(Required=false)]
            public int? TaskCount { get; set; }

            /// <summary>
            /// <para>Indicates whether the job is a long-running job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("TaskSustainable")]
            [Validation(Required=false)]
            public bool? TaskSustainable { get; set; }

        }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>896D338C-E4F4-41EC-A154-D605E5DE****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries that meet the filter conditions.
        /// This parameter is optional and may not be returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
