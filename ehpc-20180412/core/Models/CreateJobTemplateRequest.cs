// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class CreateJobTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The job array.</para>
        /// <para>Format: X-Y:Z. X is the minimum index value. Y is the maximum index value. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1-10:2</para>
        /// </summary>
        [NameInMap("ArrayRequest")]
        [Validation(Required=false)]
        public string ArrayRequest { get; set; }

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
        /// <para>./LammpsTest/lammps.pbs</para>
        /// </summary>
        [NameInMap("CommandLine")]
        [Validation(Required=false)]
        public string CommandLine { get; set; }

        /// <summary>
        /// <para>The maximum GPU usage required by a single compute node. Valid values: 1 to 8.</para>
        /// <para>The parameter takes effect only when the cluster uses PBS and a compute node is a GPU-accelerated instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Gpu")]
        [Validation(Required=false)]
        public int? Gpu { get; set; }

        /// <summary>
        /// <para>The URL of the job files that are uploaded to an Object Storage Service (OSS) bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://test.oss-cn-beijing.aliyuncs.com/test.py">https://test.oss-cn-beijing.aliyuncs.com/test.py</a></para>
        /// </summary>
        [NameInMap("InputFileUrl")]
        [Validation(Required=false)]
        public string InputFileUrl { get; set; }

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
        /// <para>The name of the job template. The name must be 2 to 64 characters in length. It must start with a letter and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>jobtemplate1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of compute nodes. Valid values: 1 to 500.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the Task, Thread, Mem, or GPU parameters do not take effect.</para>
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
        /// <para>./jobfolder</para>
        /// </summary>
        [NameInMap("PackagePath")]
        [Validation(Required=false)]
        public string PackagePath { get; set; }

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
        /// <para>The name of the queue in which the job is run.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/92176.html">ListQueues</a> operation to query the name of the queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>workq</para>
        /// </summary>
        [NameInMap("Queue")]
        [Validation(Required=false)]
        public string Queue { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically rerun the job after the job fails. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>true: reruns the job.</description></item>
        /// <item><description>false: does not rerun the job.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ReRunable")]
        [Validation(Required=false)]
        public bool? ReRunable { get; set; }

        /// <summary>
        /// <para>The name of the user that runs the job.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/188572.html">ListUsers</a> operation to query the users of the cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user1</para>
        /// </summary>
        [NameInMap("RunasUser")]
        [Validation(Required=false)]
        public string RunasUser { get; set; }

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
        /// <para>The number of tasks required by a single compute node. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Task")]
        [Validation(Required=false)]
        public int? Task { get; set; }

        /// <summary>
        /// <para>The number of threads required by a single compute node. Valid values: 1 to 1000.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Thread")]
        [Validation(Required=false)]
        public int? Thread { get; set; }

        /// <summary>
        /// <para>The command that is used to decompress the job files downloaded from an OSS bucket. The parameter takes effect only when WithUnzipCmd is set to true. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>tar xzf: decompresses GZIP files.</description></item>
        /// <item><description>tar xf: decompresses TAR files.</description></item>
        /// <item><description>unzip: decompresses ZIP files.</description></item>
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
        /// <para>[{Name:,Value:},{Name:,Value:}]</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

        /// <summary>
        /// <para>Specifies whether to decompress the job files downloaded from an OSS bucket. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: decompresses the job file.</description></item>
        /// <item><description>false: does not decompress the job file.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("WithUnzipCmd")]
        [Validation(Required=false)]
        public bool? WithUnzipCmd { get; set; }

    }

}
