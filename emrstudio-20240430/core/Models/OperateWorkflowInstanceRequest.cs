// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EmrStudio20240430.Models
{
    public class OperateWorkflowInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>PAUSE</para>
        /// </summary>
        [NameInMap("execType")]
        [Validation(Required=false)]
        public string ExecType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>wi-l9o479p8rrx****</para>
        /// </summary>
        [NameInMap("workflowInstanceId")]
        [Validation(Required=false)]
        public string WorkflowInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>w-lxyy60mpgpg****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
