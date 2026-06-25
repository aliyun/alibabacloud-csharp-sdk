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
        /// <para>The time when the task was started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-11-15T07:06:42Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The task description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a task description.</para>
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
        /// <para>The time when the task was finished.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-16T02:03:23Z</para>
        /// </summary>
        [NameInMap("FinishTime")]
        [Validation(Required=false)]
        public string FinishTime { get; set; }

        /// <summary>
        /// <para>The task operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SemanticIndex</para>
        /// </summary>
        [NameInMap("JobAction")]
        [Validation(Required=false)]
        public string JobAction { get; set; }

        /// <summary>
        /// <para>The task pattern.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Full</para>
        /// </summary>
        [NameInMap("JobMode")]
        [Validation(Required=false)]
        public string JobMode { get; set; }

        /// <summary>
        /// <para>The task details.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;modelId\&quot;:\&quot;xxx\&quot;}</para>
        /// </summary>
        [NameInMap("JobSpec")]
        [Validation(Required=false)]
        public string JobSpec { get; set; }

        /// <summary>
        /// <para>The list of task logs.</para>
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
        /// <para>The task status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The total number of files for the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("TotalFileCount")]
        [Validation(Required=false)]
        public long? TotalFileCount { get; set; }

    }

}
