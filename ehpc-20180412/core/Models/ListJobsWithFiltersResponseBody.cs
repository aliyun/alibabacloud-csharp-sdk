// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobsWithFiltersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of jobs.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListJobsWithFiltersResponseBodyJobs> Jobs { get; set; }
        public class ListJobsWithFiltersResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The job array. If the job is not in a queue, the output is empty.</para>
            /// <para>Format: X-Y:Z. X is the minimum index value. Y is the maximum index value. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1-10:2</para>
            /// </summary>
            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            /// <summary>
            /// <para>The description of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>jobDescription</para>
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8.scheduler</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647428667</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// <para>The name of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>job1</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of compute nodes that were used to run the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[\&quot;compute2\&quot;, \&quot;compute3\&quot;]</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public string NodeList { get; set; }

            /// <summary>
            /// <para>The name of the user that ran the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test2@scheduler</para>
            /// </summary>
            [NameInMap("Owner")]
            [Validation(Required=false)]
            public string Owner { get; set; }

            /// <summary>
            /// <para>The priority of the job. Valid values: 0 to 9. A larger value indicates a higher priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The number of queues that ran the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Queue")]
            [Validation(Required=false)]
            public string Queue { get; set; }

            /// <summary>
            /// <para>Indicates whether the job can be run again. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: yes</description></item>
            /// <item><description>false: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Rerunable")]
            [Validation(Required=false)]
            public bool? Rerunable { get; set; }

            /// <summary>
            /// <para>The resources that were used to run the job.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public ListJobsWithFiltersResponseBodyJobsResources Resources { get; set; }
            public class ListJobsWithFiltersResponseBodyJobsResources : TeaModel {
                /// <summary>
                /// <para>The number of CPUs that were used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public long? Cores { get; set; }

                /// <summary>
                /// <para>The number of nodes that were used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public long? Nodes { get; set; }

            }

            /// <summary>
            /// <para>The path that was used to run the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>./Temp</para>
            /// </summary>
            [NameInMap("ShellPath")]
            [Validation(Required=false)]
            public string ShellPath { get; set; }

            /// <summary>
            /// <para>The time when the job was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647427667</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The status of the job. Valid value:</para>
            /// <list type="bullet">
            /// <item><description>FINISHED: The job is completed.</description></item>
            /// <item><description>RUNNING: The job is running.</description></item>
            /// <item><description>QUEUED: The job is pending in a queue.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>FINISHED</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The output file path of stderr.</para>
            /// 
            /// <b>Example:</b>
            /// <para>./Temp</para>
            /// </summary>
            [NameInMap("Stderr")]
            [Validation(Required=false)]
            public string Stderr { get; set; }

            /// <summary>
            /// <para>The output file path of stdout.</para>
            /// 
            /// <b>Example:</b>
            /// <para>./Temp</para>
            /// </summary>
            [NameInMap("Stdout")]
            [Validation(Required=false)]
            public string Stdout { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1647423718</para>
            /// </summary>
            [NameInMap("SubmitTime")]
            [Validation(Required=false)]
            public string SubmitTime { get; set; }

            /// <summary>
            /// <para>The list of variables of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;PBS_O_SHELL&quot;:&quot;/bin/bash&quot;, 	&quot;PBS_O_HOST&quot;:&quot;manager&quot;, 	&quot;PBS_O_SYSTEM&quot;:&quot;Linux&quot;, 	&quot;PBS_O_LANG&quot;:&quot;en_US.UTF-8&quot;, 	&quot;PBS_O_QUEUE&quot;:&quot;workq&quot;}</para>
            /// </summary>
            [NameInMap("VariableList")]
            [Validation(Required=false)]
            public string VariableList { get; set; }

        }

        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
