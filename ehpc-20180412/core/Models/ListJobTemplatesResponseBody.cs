// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListJobTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

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
        /// <para>The list of job templates.</para>
        /// </summary>
        [NameInMap("Templates")]
        [Validation(Required=false)]
        public ListJobTemplatesResponseBodyTemplates Templates { get; set; }
        public class ListJobTemplatesResponseBodyTemplates : TeaModel {
            [NameInMap("JobTemplates")]
            [Validation(Required=false)]
            public List<ListJobTemplatesResponseBodyTemplatesJobTemplates> JobTemplates { get; set; }
            public class ListJobTemplatesResponseBodyTemplatesJobTemplates : TeaModel {
                /// <summary>
                /// <para>The queue of the job.</para>
                /// <para>Format: X-Y:Z. X is the minimum index value. Y is the maximum index value. Z is the step size. For example, 2-7:2 indicates that three jobs need to be run and their index values are 2, 4, and 6.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2-7:2</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>12:00:00</para>
                /// </summary>
                [NameInMap("ClockTime")]
                [Validation(Required=false)]
                public string ClockTime { get; set; }

                /// <summary>
                /// <para>The command that is used to run the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>./LammpsTest/lammps.pbs</para>
                /// </summary>
                [NameInMap("CommandLine")]
                [Validation(Required=false)]
                public string CommandLine { get; set; }

                /// <summary>
                /// <para>The maximum GPU usage for individual compute nodes. Valid values: 1 to 8.</para>
                /// <para>The parameter takes effect only when the cluster uses PBS and a compute node is a GPU-accelerated instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("Gpu")]
                [Validation(Required=false)]
                public int? Gpu { get; set; }

                /// <summary>
                /// <para>The ID of the job template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ehpc-job-tmpl-6RxO5y****</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

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
                /// <para>The maximum memory usage of a single compute node. The unit can be GB, MB, or KB, and is case-insensitive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1GB</para>
                /// </summary>
                [NameInMap("Mem")]
                [Validation(Required=false)]
                public string Mem { get; set; }

                /// <summary>
                /// <para>The name of the job template.</para>
                /// 
                /// <b>Example:</b>
                /// <para>job1</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The number of compute nodes. Valid values: 1 to 500.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Priority")]
                [Validation(Required=false)]
                public int? Priority { get; set; }

                /// <summary>
                /// <para>The queue of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>workq</para>
                /// </summary>
                [NameInMap("Queue")]
                [Validation(Required=false)]
                public string Queue { get; set; }

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
                /// <para>The name of the user that runs the job.</para>
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
                /// <para>./Lammps</para>
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
                /// <para>The number of threads required by a single task. Valid values: 1 to 1000.</para>
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
                /// <para>The environment variables of the job.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{Name:,Value:},{Name:,Value:}]</para>
                /// </summary>
                [NameInMap("Variables")]
                [Validation(Required=false)]
                public string Variables { get; set; }

                /// <summary>
                /// <para>Specifies whether to decompress the job files downloaded from an OSS bucket. Valid value:</para>
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

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
