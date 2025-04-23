// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetDatasetJobResponseBody : TeaModel {
        /// <summary>
        /// <para>The total number of completed files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>990</para>
        /// </summary>
        [NameInMap("CompletedFileCount")]
        [Validation(Required=false)]
        public long? CompletedFileCount { get; set; }

        /// <summary>
        /// <para>The time when the job is started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-15T07:06:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The total number of failed files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FailedFileCount")]
        [Validation(Required=false)]
        public long? FailedFileCount { get; set; }

        /// <summary>
        /// <para>The time when the job ends.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-16T02:03:23Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The action that is performed on the job.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SemanticIndex: semantic indexing</description></item>
        /// <item><description>IntelligentTag: smart labeling</description></item>
        /// <item><description>FileMetaExport: metadata export</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SemanticIndex</para>
        /// </summary>
        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        /// <summary>
        /// <para>The job mode.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>Full: full data mode.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("JobMode")]
        [Validation(Required=false)]
        public string JobMode { get; set; }

        /// <summary>
        /// <para>The job details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;modelId\&quot;:\&quot;xxx\&quot;}</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpec { get; set; }

        /// <summary>
        /// <para>The job logs.</para>
        /// </summary>
        [NameInMap("Logs")]
        [Validation(Required=false)]
        public List<string> Logs { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64B50C1D-D4C2-560C-86A3-A6ED****16D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The job state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Succeeded</description></item>
        /// <item><description>Failed</description></item>
        /// <item><description>Running</description></item>
        /// <item><description>Pending</description></item>
        /// <item><description>PartialFailed</description></item>
        /// <item><description>Deleting</description></item>
        /// <item><description>ManuallyStop</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of job files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

    }

}
