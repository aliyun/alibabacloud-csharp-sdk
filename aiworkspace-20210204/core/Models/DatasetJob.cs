// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class DatasetJob : TeaModel {
        /// <summary>
        /// <para>The number of completed files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>990</para>
        /// </summary>
        [NameInMap("CompletedFileCount")]
        [Validation(Required=false)]
        public long? CompletedFileCount { get; set; }

        /// <summary>
        /// <para>The job creation time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-20T04:05:59Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsjob-9jx1*****uj9e</para>
        /// </summary>
        [NameInMap("DatasetJobId")]
        [Validation(Required=false)]
        public string DatasetJobId { get; set; }

        /// <summary>
        /// <para>The dataset version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("DatasetVersion")]
        [Validation(Required=false)]
        public string DatasetVersion { get; set; }

        /// <summary>
        /// <para>The job description.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The number of failed files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("FailedFileCount")]
        [Validation(Required=false)]
        public long? FailedFileCount { get; set; }

        /// <summary>
        /// <para>The job finish time (UTC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>2023-06-20T06:03:48Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The job action.</para>
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
        /// <item><description>Full</description></item>
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
        /// <para>The job status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of job files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>145883</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
