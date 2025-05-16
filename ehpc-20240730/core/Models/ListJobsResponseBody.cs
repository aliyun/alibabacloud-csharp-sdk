// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The jobs.</para>
        /// </summary>
        [NameInMap("Jobs")]
        [Validation(Required=false)]
        public List<ListJobsResponseBodyJobs> Jobs { get; set; }
        public class ListJobsResponseBodyJobs : TeaModel {
            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testjob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The job configurations.</para>
            /// </summary>
            [NameInMap("JobSpec")]
            [Validation(Required=false)]
            public ListJobsResponseBodyJobsJobSpec JobSpec { get; set; }
            public class ListJobsResponseBodyJobsJobSpec : TeaModel {
                /// <summary>
                /// <para>The array job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("ArrayJobId")]
                [Validation(Required=false)]
                public string ArrayJobId { get; set; }

                /// <summary>
                /// <para>The ID of the job in the array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ArrayJobSubId")]
                [Validation(Required=false)]
                public string ArrayJobSubId { get; set; }

                /// <summary>
                /// <para>The queue format of the job.</para>
                /// <list type="bullet">
                /// <item><description>If the job is not in a queue, the output is empty.</description></item>
                /// <item><description>The format is X-Y:Z. X indicates the first index, Y indicates the final index, and Z indicates the step size. For example, 2-7:2 indicates three sub-jobs numbered 2, 4, and 6.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1-5:2</para>
                /// </summary>
                [NameInMap("ArrayRequest")]
                [Validation(Required=false)]
                public string ArrayRequest { get; set; }

                /// <summary>
                /// <para>The job description.</para>
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
                /// <para>12</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The queue name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>comp</para>
                /// </summary>
                [NameInMap("JobQueue")]
                [Validation(Required=false)]
                public string JobQueue { get; set; }

                /// <summary>
                /// <para>The time when the job was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724123085</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <para>The compute nodes that were used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute[002,005,003]</para>
                /// </summary>
                [NameInMap("NodeList")]
                [Validation(Required=false)]
                public string NodeList { get; set; }

                /// <summary>
                /// <para>The job priority. Valid values: 0 to 9. A larger value indicates a higher priority.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public string Priority { get; set; }

                /// <summary>
                /// <para>The information about the resources required to run the job.</para>
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public ListJobsResponseBodyJobsJobSpecResources Resources { get; set; }
                public class ListJobsResponseBodyJobsJobSpecResources : TeaModel {
                    /// <summary>
                    /// <para>The number of vCPUs that were used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public string Cores { get; set; }

                    /// <summary>
                    /// <para>The number of GPUs that were used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpus")]
                    [Validation(Required=false)]
                    public string Gpus { get; set; }

                    /// <summary>
                    /// <para>The size of memory that was used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1536MB</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public string Memory { get; set; }

                    /// <summary>
                    /// <para>The number of compute nodes that were used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public string Nodes { get; set; }

                }

                /// <summary>
                /// <para>Actual resource usage of the job program</para>
                /// </summary>
                [NameInMap("ResourcesActualOccupied")]
                [Validation(Required=false)]
                public ListJobsResponseBodyJobsJobSpecResourcesActualOccupied ResourcesActualOccupied { get; set; }
                public class ListJobsResponseBodyJobsJobSpecResourcesActualOccupied : TeaModel {
                    /// <summary>
                    /// <para>Number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public string Cores { get; set; }

                    /// <summary>
                    /// <para>Number of CPUs</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpus")]
                    [Validation(Required=false)]
                    public string Gpus { get; set; }

                    /// <summary>
                    /// <para>Number of memory.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>982MB</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public string Memory { get; set; }

                    /// <summary>
                    /// <para>Number of compute nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public string Nodes { get; set; }

                }

                /// <summary>
                /// <para>The user that ran the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testuser1</para>
                /// </summary>
                [NameInMap("RunasUser")]
                [Validation(Required=false)]
                public string RunasUser { get; set; }

                /// <summary>
                /// <para>Job start time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724122486</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The job state. Valid values: (PBS cluster and Slurm cluster)</para>
                /// <list type="bullet">
                /// <item><description>FINISHED/Completed</description></item>
                /// <item><description>RUNNING/Running</description></item>
                /// <item><description>QUEUED/Pending</description></item>
                /// <item><description>FAILED/Failed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The error output path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>./Temp</para>
                /// </summary>
                [NameInMap("StderrPath")]
                [Validation(Required=false)]
                public string StderrPath { get; set; }

                /// <summary>
                /// <para>The standard output path.</para>
                /// 
                /// <b>Example:</b>
                /// <para>./Temp</para>
                /// </summary>
                [NameInMap("StdoutPath")]
                [Validation(Required=false)]
                public string StdoutPath { get; set; }

                /// <summary>
                /// <para>The time when the job was submitted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724122486</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// <para>The variables of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;PBS_O_SHELL&quot;:&quot;/bin/bash&quot;, 	&quot;PBS_O_HOST&quot;:&quot;manager&quot;, 	&quot;PBS_O_SYSTEM&quot;:&quot;Linux&quot;, 	&quot;PBS_O_LANG&quot;:&quot;en_US.UTF-8&quot;, 	&quot;PBS_O_QUEUE&quot;:&quot;workq&quot;}</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public string Variables { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number. Default value: 1</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EABFBD93-58BE-53F3-BBFE-8654BB2E****</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
