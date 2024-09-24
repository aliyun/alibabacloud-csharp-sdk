// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class KillSparkLogAnalyzeTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the Spark log analysis task. You can call the ListSparkLogAnalyzeTasks operation to query the IDs and states of all analysis tasks in the current cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

    }

}
