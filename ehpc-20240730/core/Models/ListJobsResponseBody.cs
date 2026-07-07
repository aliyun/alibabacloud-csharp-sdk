// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class ListJobsResponseBody : TeaModel {
        /// <summary>
        /// <para>The job list.</para>
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
            /// <para>The job configuration.</para>
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
                /// <para>The array sub-job ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ArrayJobSubId")]
                [Validation(Required=false)]
                public string ArrayJobSubId { get; set; }

                /// <summary>
                /// <para>The array job format.</para>
                /// <list type="bullet">
                /// <item><description>If the job is not an array job, the output is empty.</description></item>
                /// <item><description>The format is X-Y:Z, where X is the first index, Y is the last index, and Z is the step size. For example, 2-7:2 indicates that the array job contains three sub-jobs numbered 2, 4, and 6.</description></item>
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
                /// <para>The name of the queue that runs the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>comp</para>
                /// </summary>
                [NameInMap("JobQueue")]
                [Validation(Required=false)]
                public string JobQueue { get; set; }

                /// <summary>
                /// <para>The last update time of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724123085</para>
                /// </summary>
                [NameInMap("LastModifyTime")]
                [Validation(Required=false)]
                public string LastModifyTime { get; set; }

                /// <summary>
                /// <para>The list of compute nodes that run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>compute[002,005,003]</para>
                /// </summary>
                [NameInMap("NodeList")]
                [Validation(Required=false)]
                public string NodeList { get; set; }

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
                /// <para>The resource information required to run the job.</para>
                /// </summary>
                [NameInMap("Resources")]
                [Validation(Required=false)]
                public ListJobsResponseBodyJobsJobSpecResources Resources { get; set; }
                public class ListJobsResponseBodyJobsJobSpecResources : TeaModel {
                    /// <summary>
                    /// <para>The number of CPU cores used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public string Cores { get; set; }

                    /// <summary>
                    /// <para>The number of GPUs used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpus")]
                    [Validation(Required=false)]
                    public string Gpus { get; set; }

                    /// <summary>
                    /// <para>The memory size used to run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1536MB</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public string Memory { get; set; }

                    /// <summary>
                    /// <para>The number of compute nodes that run the job.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>3</para>
                    /// </summary>
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public string Nodes { get; set; }

                }

                /// <summary>
                /// <para>The resources actually occupied by the job.</para>
                /// </summary>
                [NameInMap("ResourcesActualOccupied")]
                [Validation(Required=false)]
                public ListJobsResponseBodyJobsJobSpecResourcesActualOccupied ResourcesActualOccupied { get; set; }
                public class ListJobsResponseBodyJobsJobSpecResourcesActualOccupied : TeaModel {
                    /// <summary>
                    /// <para>The number of CPU cores.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>4</para>
                    /// </summary>
                    [NameInMap("Cores")]
                    [Validation(Required=false)]
                    public string Cores { get; set; }

                    /// <summary>
                    /// <para>The number of GPUs.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Gpus")]
                    [Validation(Required=false)]
                    public string Gpus { get; set; }

                    /// <summary>
                    /// <para>The memory size.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>982MB</para>
                    /// </summary>
                    [NameInMap("Memory")]
                    [Validation(Required=false)]
                    public string Memory { get; set; }

                    /// <summary>
                    /// <para>The number of compute nodes.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2</para>
                    /// </summary>
                    [NameInMap("Nodes")]
                    [Validation(Required=false)]
                    public string Nodes { get; set; }

                }

                /// <summary>
                /// <para>The username of the user who runs the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testuser1</para>
                /// </summary>
                [NameInMap("RunasUser")]
                [Validation(Required=false)]
                public string RunasUser { get; set; }

                /// <summary>
                /// <para>The start time of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724122486</para>
                /// </summary>
                [NameInMap("StartTime")]
                [Validation(Required=false)]
                public string StartTime { get; set; }

                /// <summary>
                /// <para>The job status. Valid values: (PBS cluster/Slurm cluster)</para>
                /// <list type="bullet">
                /// <item><description>FINISHED/Completed: completed.</description></item>
                /// <item><description>RUNNING/Running: running.</description></item>
                /// <item><description>QUEUED/Pending: queued and waiting.</description></item>
                /// <item><description>FAILED/Failed: failed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("State")]
                [Validation(Required=false)]
                public string State { get; set; }

                /// <summary>
                /// <para>The standard error output path.</para>
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
                /// <para>The submission time of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1724122486</para>
                /// </summary>
                [NameInMap("SubmitTime")]
                [Validation(Required=false)]
                public string SubmitTime { get; set; }

                /// <summary>
                /// <para>The list of job variables.</para>
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
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page set for the paged query. Paging settings apply. Default value: 10.</para>
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
        /// <para>Indicates whether the command was run and the result was obtained. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Succeeded.</description></item>
        /// <item><description>false: Failed.</description></item>
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
