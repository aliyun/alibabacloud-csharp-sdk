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
            /// The number of retries for the job. Valid values: 1 to 10. You can only retry jobs that are run on the PBS clusters.
            /// 
            /// >  If this parameter is left empty, the JobRetry.Priority and JobRetry.OnExitCode parameters do not take effect.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// The retry condition of the job. If the exit code is the value of the parameter, the job retry is triggered.
            /// 
            /// >  If this parameter is left empty, the job retry is triggered when the exit code is not 0.
            /// </summary>
            [NameInMap("OnExitCode")]
            [Validation(Required=false)]
            public int? OnExitCode { get; set; }

            /// <summary>
            /// The priority of the job retry. Valid values: 0 to 9. A larger value indicates a higher priority.
            /// 
            /// >  If this parameter is left empty, the priority of the job retry is min {Priority of the original job +1, 9}.
            /// </summary>
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        /// <summary>
        /// The job array.
        /// 
        /// Format: X-Y:Z. The minimum index value X is the first index. The maximum index value Y is the last index. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.
        /// </summary>
        [NameInMap("ArrayRequest")]
        [Validation(Required=false)]
        public string ArrayRequest { get; set; }

        /// <summary>
        /// Specifies whether to use an asynchronous link to submit the job.
        /// 
        /// Default value: false.
        /// </summary>
        [NameInMap("Async")]
        [Validation(Required=false)]
        public bool? Async { get; set; }

        /// <summary>
        /// The maximum running time of the job. Valid formats:
        /// 
        /// *   hh:mm:ss
        /// *   mm:ss
        /// *   ss
        /// 
        /// We recommend that you use the hh:mm:ss format. If the maximum running time is 12 hours, set the value to 12:00:00.
        /// </summary>
        [NameInMap("ClockTime")]
        [Validation(Required=false)]
        public string ClockTime { get; set; }

        /// <summary>
        /// The cluster ID.
        /// 
        /// You can call the [ListClusters](~~87116~~) operation to query the cluster ID.
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// The command that is used to run the job.
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// The ID of the containerized application. If you want to use a container application, you must specify its ID.
        /// 
        /// You can call the [ListContainerApps](~~87333~~) operation to query the container application ID.
        /// </summary>
        [NameInMap("ContainerId")]
        [Validation(Required=false)]
        public string ContainerId { get; set; }

        /// <summary>
        /// The number of CPU cores required by a single compute node.
        /// </summary>
        [NameInMap("Cpu")]
        [Validation(Required=false)]
        public int? Cpu { get; set; }

        /// <summary>
        /// The maximum GPU usage required by a single compute node.
        /// 
        /// The parameter takes effect only when the cluster uses PBS and a compute node is a GPU-accelerated instance.
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// The URL of the job file that is uploaded to an Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// The name of the queue in which the job is run.
        /// 
        /// You can call the [ListQueues](~~92176~~) operation to query the name of the queue.
        /// </summary>
        [NameInMap("JobQueue")]
        [Validation(Required=false)]
        public string JobQueue { get; set; }

        /// <summary>
        /// The maximum memory usage required by a single compute node. Unit: GB, MB, or KB. The unit is case-insensitive.
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public string Mem { get; set; }

        /// <summary>
        /// The name of the job. The name must be 6 to 30 characters in length and start with a letter. It can contain letters, digits, and periods (.).
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of compute nodes required to run the job.
        /// 
        /// > If the parameter is not specified, the Cpu, Task, Thread, Mem, and Gpu parameters become invalid.
        /// </summary>
        [NameInMap("Node")]
        [Validation(Required=false)]
        public int? Node { get; set; }

        /// <summary>
        /// The path that is used to run the job.
        /// </summary>
        [NameInMap("PackagePath")]
        [Validation(Required=false)]
        public string PackagePath { get; set; }

        /// <summary>
        /// The command to perform on the job after the job is submitted.
        /// </summary>
        [NameInMap("PostCmdLine")]
        [Validation(Required=false)]
        public string PostCmdLine { get; set; }

        /// <summary>
        /// The priority of the job. Valid values: 0 to 9. A larger value indicates a higher priority.
        /// 
        /// Default value: 0.
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// Specifies whether the job can be rerun. Valid values:
        /// 
        /// *   true: The job can be rerun.
        /// *   false: The job cannot be rerun.
        /// </summary>
        [NameInMap("ReRunable")]
        [Validation(Required=false)]
        public bool? ReRunable { get; set; }

        /// <summary>
        /// The name of the user that runs the job.
        /// 
        /// You can call the [ListUsers](~~188572~~) operation to query the users of the cluster.
        /// </summary>
        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

        /// <summary>
        /// The password that corresponds to the username.
        /// </summary>
        [NameInMap("RunasUserPassword")]
        [Validation(Required=false)]
        public string RunasUserPassword { get; set; }

        /// <summary>
        /// The output file path of stderr.
        /// </summary>
        [NameInMap("StderrRedirectPath")]
        [Validation(Required=false)]
        public string StderrRedirectPath { get; set; }

        /// <summary>
        /// The output file path of stdout.
        /// </summary>
        [NameInMap("StdoutRedirectPath")]
        [Validation(Required=false)]
        public string StdoutRedirectPath { get; set; }

        /// <summary>
        /// The number of processes created for a single compute node.
        /// 
        /// The parameter is applicable to Message Passing Interface (MPI) jobs.
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public int? Task { get; set; }

        /// <summary>
        /// The number of threads created for a single compute node.
        /// 
        /// The parameter is applicable to OpenMP jobs.
        /// </summary>
        [NameInMap("Thread")]
        [Validation(Required=false)]
        public int? Thread { get; set; }

        /// <summary>
        /// The command for file decompression. The command that is used to decompress the job files downloaded from an OSS bucket. Valid values:
        /// 
        /// *   tar xzf: Decompresses GZIP files.
        /// *   tar xf: Decompresses TAR files.
        /// *   unzip: Decompresses ZIP files.
        /// </summary>
        [NameInMap("UnzipCmd")]
        [Validation(Required=false)]
        public string UnzipCmd { get; set; }

        /// <summary>
        /// The runtime variables passed to the job. They can be accessed by using environment variables in the executable file.
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

    }

}
