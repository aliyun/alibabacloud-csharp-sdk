// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetWorkflowTaskRequest : TeaModel {
        /// <summary>
        /// <para>The workflow task ID. It is returned by the SubmitWorkflowJob operation and is used to query the execution status and result of the task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>70422****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
