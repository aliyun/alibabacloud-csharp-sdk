// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RetryAgentlessTaskRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the task. You can call the <a href="~~ListAgentlessTask~~">ListAgentlessTask</a> operation to obtain the IDs of tasks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5347c7b6-c85c-4070-846a-3029e08e****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
