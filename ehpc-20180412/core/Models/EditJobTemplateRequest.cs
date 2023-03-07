// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class EditJobTemplateRequest : TeaModel {
        /// <summary>
        /// The job array.
        /// 
        /// Format: X-Y:Z. X is the minimum index value. Y is the maximum index value. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.
        /// </summary>
        [NameInMap("ArrayRequest")]
        [Validation(Required=false)]
        public string ArrayRequest { get; set; }

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
        /// The command that is used to run the job.
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// The maximum GPU usage required by a single compute node. Valid values: 1 to 8.
        /// 
        /// The parameter takes effect only when the cluster uses PBS and a compute node is a GPU-accelerated instance.
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// The URL of the job files that are uploaded to an Object Storage Service (OSS) bucket.
        /// </summary>
        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

        /// <summary>
        /// The maximum memory usage required by a single compute node. Unit: GB, MB, or KB. The unit is case-insensitive.
        /// </summary>
        [NameInMap("Mem")]
        [Validation(Required=false)]
        public string Mem { get; set; }

        /// <summary>
        /// The name of the job template.
        /// 
        /// You can call the [ListJobTemplates](~~87248~~) operation to obtain the job template name.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The number of the compute nodes. Valid values: 1 to 500.
        /// 
        /// >  If the parameter is not specified, the Task, Thread, Mem, and Gpu parameters become invalid.
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
        /// The priority of the job. Valid values: 0 to 9. A large value indicates a high priority.
        /// 
        /// Default value: 0
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// The name of the queue.
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

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
        /// The number of tasks required by a single compute node. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public int? Task { get; set; }

        /// <summary>
        /// The ID of the job template.
        /// 
        /// You can call the [ListJobTemplates](~~87248~~) operation to obtain the job template ID.
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The number of threads required by a single compute node. Valid values: 1 to 1000.
        /// </summary>
        [NameInMap("Thread")]
        [Validation(Required=false)]
        public int? Thread { get; set; }

        /// <summary>
        /// The command that is used to decompress the job files downloaded from an OSS bucket. The parameter takes effect only when WithUnzipCmd is set to true. Valid values:
        /// 
        /// *   tar xzf: decompresses GZIP files.
        /// *   tar xf: decompresses TAR files.
        /// *   unzip: decompresses ZIP files.
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

        /// <summary>
        /// Specifies whether to decompress the job files downloaded from an OSS bucket. Valid values:
        /// 
        /// *   true: The job files are decompressed.
        /// *   false: The job files are not decompressed.
        /// </summary>
        [NameInMap("WithUnzipCmd")]
        [Validation(Required=false)]
        public bool? WithUnzipCmd { get; set; }

    }

}
