// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class BatchEditWorkspaceQueuesReceipt : TeaModel {
        /// <summary>
        /// <para>The target states of these queues are progressively written during the workflow.</para>
        /// </summary>
        [NameInMap("acceptedQueues")]
        [Validation(Required=false)]
        public List<string> AcceptedQueues { get; set; }

        /// <summary>
        /// <para>The current values are already equal to the target values, so no write operations are required.</para>
        /// </summary>
        [NameInMap("skippedQueues")]
        [Validation(Required=false)]
        public List<string> SkippedQueues { get; set; }

        /// <summary>
        /// <para>A null value indicates that all queues in this request are already in the target state and no workflow is started (idempotent no-op).</para>
        /// 
        /// <b>Example:</b>
        /// <para>9527</para>
        /// </summary>
        [NameInMap("workflowInstanceId")]
        [Validation(Required=false)]
        public long? WorkflowInstanceId { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-1234abcd</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
