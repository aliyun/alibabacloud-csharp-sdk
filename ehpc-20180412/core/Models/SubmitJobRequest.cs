// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class SubmitJobRequest : TeaModel {
        [NameInMap("JobRetry")]
        [Validation(Required=false)]
        public SubmitJobRequestJobRetry JobRetry { get; set; }
        public class SubmitJobRequestJobRetry : TeaModel {
            /// <summary>
            /// <para>The number of retries for the job. Valid values: 1 to 10. You can only retry jobs that are run on the PBS clusters.</para>
            /// <remarks>
            /// <para> If this parameter is left empty, the JobRetry.Priority and JobRetry.OnExitCode parameters do not take effect.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The retry condition of the job. If the exit code is the value of the parameter, the job retry is triggered.</para>
            /// <remarks>
            /// <para> If this parameter is left empty, the job retry is triggered when the exit code is not 0.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("OnExitCode")]
            [Validation(Required=false)]
            public int? OnExitCode { get; set; }

            /// <summary>
            /// <para>The priority of the job retry. Valid values: 0 to 9. A larger value indicates a higher priority.</para>
            /// <remarks>
            /// <para> If this parameter is left empty, the priority of the job retry is min {Priority of the original job +1, 9}.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// <para>The job array.</para>
        /// <para>Format: X-Y:Z. The minimum index value X is the first index. The maximum index value Y is the last index. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1-10:2</para>
        /// </summary>
        [NameInMap("ArrayRequest")]
        [Validation(Required=false)]
        public string ArrayRequest { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an asynchronous link to submit the job.</para>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// <para>The maximum running time of the job. Valid formats:</para>
        /// <list type="bullet">
        /// <item><description>hh:mm:ss</description></item>
        /// <item><description>mm:ss</description></item>
        /// <item><description>ss</description></item>
        /// </list>
        /// <para>We recommend that you use the hh:mm:ss format. If the maximum running time is 12 hours, set the value to 12:00:00.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12:00:00</para>
        /// </summary>
        [NameInMap("ClockTime")]
        [Validation(Required=false)]
        public string ClockTime { get; set; }

        /// <summary>
        /// <para>The command that is used to run the job.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ehpc-hz-FYUr32****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The name of the user that runs the job.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188572.html">ListUsers</a> operation to query the users of the cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>./LammpsTest/lammps.pbs</para>
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// <para>The number of CPU cores required by a single compute node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// <para>The maximum GPU usage required by a single compute node.</para>
        /// <para>The parameter takes effect only when the cluster uses PBS and a compute node is a GPU-accelerated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The URL of the job file that is uploaded to an Object Storage Service (OSS) bucket.</para>
        /// </summary>
        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// <para>The name of the queue in which the job is run.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/92176.html">ListQueues</a> operation to query the name of the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// <para>The maximum memory usage required by a single compute node. Unit: GB, MB, or KB. The unit is case-insensitive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1GB</para>
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public string Mem { get; set; }

        /// <summary>
        /// <para>job1</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobtest</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of compute nodes required to run the job.</para>
        /// <remarks>
        /// <para>If the parameter is not specified, the Cpu, Task, Thread, Mem, and Gpu parameters become invalid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public int? Node { get; set; }

        /// <summary>
        /// <para>The path that is used to run the job.</para>
        /// 
        /// <b>Example:</b>
        /// <para>./Tem</para>
        /// </summary>
        [NameInMap("PackagePath")]
        [Validation(Required=false)]
        public string PackagePath { get; set; }

        /// <summary>
        /// <para>The command to perform on the job after the job is submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.sh</para>
        /// </summary>
        [NameInMap("PostCmdLine")]
        [Validation(Required=false)]
        public string PostCmdLine { get; set; }

        /// <summary>
        /// <para>The priority of the job. Valid values: 0 to 9. A larger value indicates a higher priority.</para>
        /// <para>Default value: 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>Specifies whether the job can be rerun. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The job can be rerun.</description></item>
        /// <item><description>false: The job cannot be rerun.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReRunable")]
        [Validation(Required=false)]
        public bool? ReRunable { get; set; }

        /// <summary>
        /// <para>The password that corresponds to the username.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuser</para>
        /// </summary>
        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        /// <summary>
        /// <para>The name of the job. The name must be 6 to 30 characters in length and start with a letter. It can contain letters, digits, and periods (.).</para>
        /// 
        /// <b>Example:</b>
        /// <para>12****</para>
        /// </summary>
        [NameInMap("RunasUserPassword")]
        [Validation(Required=false)]
        public string RunasUserPassword { get; set; }

        /// <summary>
        /// <para>The output file path of stderr.</para>
        /// 
        /// <b>Example:</b>
        /// <para>./LammpsTest</para>
        /// </summary>
        [NameInMap("StderrRedirectPath")]
        [Validation(Required=false)]
        public string StderrRedirectPath { get; set; }

        /// <summary>
        /// <para>The output file path of stdout.</para>
        /// 
        /// <b>Example:</b>
        /// <para>./LammpsTest</para>
        /// </summary>
        [NameInMap("StdoutRedirectPath")]
        [Validation(Required=false)]
        public string StdoutRedirectPath { get; set; }

        /// <summary>
        /// <para>The number of processes created for a single compute node.</para>
        /// <para>The parameter is applicable to Message Passing Interface (MPI) jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public int? Task { get; set; }

        /// <summary>
        /// <para>The number of threads created for a single compute node.</para>
        /// <para>The parameter is applicable to OpenMP jobs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Thread")]
        [Validation(Required=false)]
        public int? Thread { get; set; }

        /// <summary>
        /// <para>The command for file decompression. The command that is used to decompress the job files downloaded from an OSS bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tar xzf: Decompresses GZIP files.</description></item>
        /// <item><description>tar xf: Decompresses TAR files.</description></item>
        /// <item><description>unzip: Decompresses ZIP files.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>tar xzf</para>
        /// </summary>
        [NameInMap("UnzipCmd")]
        [Validation(Required=false)]
        public string UnzipCmd { get; set; }

        /// <summary>
        /// <para>The runtime variables passed to the job. They can be accessed by using environment variables in the executable file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{Name:test1,Value:value1},{Name:test2,Value:value2}]</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
