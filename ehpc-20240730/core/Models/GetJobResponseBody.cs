// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class GetJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The job details.</para>
        /// </summary>
        [NameInMap("JobInfo")]
        [Validation(Required=false)]
        public GetJobResponseBodyJobInfo JobInfo { get; set; }
        public class GetJobResponseBodyJobInfo : TeaModel {
            /// <summary>
            /// <para>The parent job ID. If the return value is a non-empty string, the job is an array job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ArrayJobId")]
            [Validation(Required=false)]
            public string ArrayJobId { get; set; }

            /// <summary>
            /// <para>The sub-job ID. This parameter is valid when the ArrayJobId parameter is a non-empty string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ArrayJobSubId")]
            [Validation(Required=false)]
            public string ArrayJobSubId { get; set; }

            /// <summary>
            /// <para>The job queue. If the job is not in a queue, the output is empty.</para>
            /// <para>The format is X-Y:Z. X indicates the first index, Y indicates the final index, and Z indicates the step size. For example, 2-7:2 indicates three sub-jobs numbered 2, 4, and 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1-5:2</para>
            /// </summary>
            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            /// <summary>
            /// <para>The command that is used to run the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/huangsf/ehpc/job_meta.pbs</para>
            /// </summary>
            [NameInMap("CommandLine")]
            [Validation(Required=false)]
            public string CommandLine { get; set; }

            /// <summary>
            /// <para>The time when the job was submitted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-16T10:52:48</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The error log file of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/xxx/STDIN.e1</para>
            /// </summary>
            [NameInMap("ErrorLog")]
            [Validation(Required=false)]
            public string ErrorLog { get; set; }

            /// <summary>
            /// <para>Additional information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            /// <summary>
            /// <para>The job ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.manager</para>
            /// </summary>
            [NameInMap("JobId")]
            [Validation(Required=false)]
            public string JobId { get; set; }

            /// <summary>
            /// <para>The job name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testJob</para>
            /// </summary>
            [NameInMap("JobName")]
            [Validation(Required=false)]
            public string JobName { get; set; }

            /// <summary>
            /// <para>The queue to which the job belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>workq</para>
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// <para>The time when the job was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-16T10:52:48</para>
            /// </summary>
            [NameInMap("LastModifyTime")]
            [Validation(Required=false)]
            public string LastModifyTime { get; set; }

            /// <summary>
            /// <para>The compute nodes that are used to run the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>compute000</para>
            /// </summary>
            [NameInMap("NodeList")]
            [Validation(Required=false)]
            public string NodeList { get; set; }

            /// <summary>
            /// <para>The standard output log file of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/xxx/STDIN.o1</para>
            /// </summary>
            [NameInMap("OutputLog")]
            [Validation(Required=false)]
            public string OutputLog { get; set; }

            /// <summary>
            /// <para>The priority of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The resources that were requested when the job was submitted.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoResources Resources { get; set; }
            public class GetJobResponseBodyJobInfoResources : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs used by the job on each node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public string Cores { get; set; }

                /// <summary>
                /// <para>The number of GPUs used by the job on each node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Gpus")]
                [Validation(Required=false)]
                public string Gpus { get; set; }

                /// <summary>
                /// <para>The memory size used by the job on each node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1gb</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The number of nodes that are used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public string Nodes { get; set; }

            }

            /// <summary>
            /// <para>The resources that are actually used by the job.</para>
            /// </summary>
            [NameInMap("ResourcesUsed")]
            [Validation(Required=false)]
            public GetJobResponseBodyJobInfoResourcesUsed ResourcesUsed { get; set; }
            public class GetJobResponseBodyJobInfoResourcesUsed : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs used by the job on each node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public string Cores { get; set; }

                /// <summary>
                /// <para>The memory size used by the job on each node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>512mb</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The number of nodes that are used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public string Nodes { get; set; }

            }

            /// <summary>
            /// <para>The user to which the job belongs or that is used to submit the job. This user is a cluster-side user.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("RunasUser")]
            [Validation(Required=false)]
            public string RunasUser { get; set; }

            /// <summary>
            /// <para>The time when the job was started.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-08-16T10:52:48</para>
            /// </summary>
            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

            /// <summary>
            /// <para>The job state.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            /// <summary>
            /// <para>The variables of the job.</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public List<GetJobResponseBodyJobInfoVariables> Variables { get; set; }
            public class GetJobResponseBodyJobInfoVariables : TeaModel {
                /// <summary>
                /// <para>The name of the environment variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ProxyIP</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The value of the environment variable.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.x.x.x</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0****-1335-<b><b>-A1D7-6C044FE7</b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The request result. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
