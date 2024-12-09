// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20240730.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>The cluster ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/87116.html">ListClusters</a> operation to query the cluster ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The job name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestJob</para>
        /// </summary>
        [NameInMap("JobName")]
        [Validation(Required=false)]
        public string JobName { get; set; }

        /// <summary>
        /// <para>The job configurations.</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public CreateJobRequestJobSpec JobSpec { get; set; }
        public class CreateJobRequestJobSpec : TeaModel {
            /// <summary>
            /// <para>The jobs in the queue.</para>
            /// <para>Format: X-Y:Z. X is the minimum index value. Y is the maximum index value. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1-5:2</para>
            /// </summary>
            [NameInMap("ArrayRequest")]
            [Validation(Required=false)]
            public string ArrayRequest { get; set; }

            /// <summary>
            /// <para>The command or script that is used to run the job. If you want to use a command, you must specify the full path of the command, for example, /bin/ping.</para>
            /// <para>If you want to use a script, you must make sure that you have the execution permissions on it. By default, the user root directory ~/ is used as the default script path on the cluster side. If your script is not in that directory, you must specify the full path in this parameter, such as /home/xxx/job.sh Note that in this mode, if requirements on resources such as CPU and memory are specified in the script, the job will be run based on the resource requirements specified in the script. In this case, do not specify resource requirements in the Resource parameter. Otherwise, the job may fail to run.</para>
            /// <para>If you want to run the job directly by using the CLI, you must specify the absolute path of the command and add two hyphens and a space (-- ) before the path, such as -- /bin/ping -c 10 localhost.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/xxx/test.job</para>
            /// </summary>
            [NameInMap("CommandLine")]
            [Validation(Required=false)]
            public string CommandLine { get; set; }

            /// <summary>
            /// <para>The queue to which the job belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>comp</para>
            /// </summary>
            [NameInMap("JobQueue")]
            [Validation(Required=false)]
            public string JobQueue { get; set; }

            /// <summary>
            /// <para>The post-processing command of the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/bin/sleep 10</para>
            /// </summary>
            [NameInMap("PostCmdLine")]
            [Validation(Required=false)]
            public string PostCmdLine { get; set; }

            /// <summary>
            /// <para>The job priority.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public string Priority { get; set; }

            /// <summary>
            /// <para>The resource configurations of the job.</para>
            /// </summary>
            [NameInMap("Resources")]
            [Validation(Required=false)]
            public CreateJobRequestJobSpecResources Resources { get; set; }
            public class CreateJobRequestJobSpecResources : TeaModel {
                /// <summary>
                /// <para>The number of vCPUs to be allocated to each compute node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Cores")]
                [Validation(Required=false)]
                public int? Cores { get; set; }

                /// <summary>
                /// <para>The number of GPUs to be allocated to each compute node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Gpus")]
                [Validation(Required=false)]
                public int? Gpus { get; set; }

                /// <summary>
                /// <para>The memory size to be allocated to each compute node. The memory size is in string format. Unit: MB or GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>4gb</para>
                /// </summary>
                [NameInMap("Memory")]
                [Validation(Required=false)]
                public string Memory { get; set; }

                /// <summary>
                /// <para>The number of compute nodes to be allocated to the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2</para>
                /// </summary>
                [NameInMap("Nodes")]
                [Validation(Required=false)]
                public int? Nodes { get; set; }

            }

            /// <summary>
            /// <para>The cluster-side user as which you want to submit the job.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testuser</para>
            /// </summary>
            [NameInMap("RunasUser")]
            [Validation(Required=false)]
            public string RunasUser { get; set; }

            /// <summary>
            /// <para>The password of the user specified by the RunasUser parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("RunasUserPassword")]
            [Validation(Required=false)]
            public string RunasUserPassword { get; set; }

            /// <summary>
            /// <para>The path of the standard error output file of the job. You need to specify the full path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/xxx/job.err</para>
            /// </summary>
            [NameInMap("StderrPath")]
            [Validation(Required=false)]
            public string StderrPath { get; set; }

            /// <summary>
            /// <para>The path of the standard output file of the job. You need to specify the full path.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/home/xxx/job.out</para>
            /// </summary>
            [NameInMap("StdoutPath")]
            [Validation(Required=false)]
            public string StdoutPath { get; set; }

            /// <summary>
            /// <para>The environment variables of the job. The value is a string in the JSON array format. Each array member is a JSON object that contains two members: Name and Value. Name indicates the name of the environment variable, and Value indicates the value of the environment variable.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;Name&quot;:&quot;x&quot;, &quot;Value&quot;:&quot;y&quot;}]</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public string Variables { get; set; }

            /// <summary>
            /// <para>The maximum duration for which the job can be run. Format: <c>hour: minute: second</c>. For example, <c>01:00:00</c> indicates 1 hour.</para>
            /// 
            /// <b>Example:</b>
            /// <para>360:48:50</para>
            /// </summary>
            [NameInMap("WallTime")]
            [Validation(Required=false)]
            public string WallTime { get; set; }

        }

    }

}
