// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkflowInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The unique external requirement number within the workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-1001</para>
        /// </summary>
        [NameInMap("businessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        /// <summary>
        /// <para>The business status code from the unified POP response wrapper.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_20261016_abc123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The creation time of the logical instance in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16T10:30:00+08:00</para>
        /// </summary>
        [NameInMap("createdAt")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The first active node. This value is null when the instance reaches a terminal state.</para>
        /// </summary>
        [NameInMap("currentNode")]
        [Validation(Required=false)]
        public GetWorkflowInstanceResponseBodyCurrentNode CurrentNode { get; set; }
        public class GetWorkflowInstanceResponseBodyCurrentNode : TeaModel {
            /// <summary>
            /// <para>The display name of the current handler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("handler")]
            [Validation(Required=false)]
            public string Handler { get; set; }

            /// <summary>
            /// <para>The identifier of the handler or digital worker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_10086</para>
            /// </summary>
            [NameInMap("handlerId")]
            [Validation(Required=false)]
            public string HandlerId { get; set; }

            /// <summary>
            /// <para>The nodeKey of the actual running node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_key_confirm</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The display name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Requirement Confirmation</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The actual node type. Valid values: AGENT, HUMAN, and CONDITION.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The running status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>All active nodes. Parallel DAGs are supported.</para>
        /// </summary>
        [NameInMap("currentNodes")]
        [Validation(Required=false)]
        public List<GetWorkflowInstanceResponseBodyCurrentNodes> CurrentNodes { get; set; }
        public class GetWorkflowInstanceResponseBodyCurrentNodes : TeaModel {
            /// <summary>
            /// <para>The display name of the current handler.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Zhang San</para>
            /// </summary>
            [NameInMap("handler")]
            [Validation(Required=false)]
            public string Handler { get; set; }

            /// <summary>
            /// <para>The identifier of the handler or digital worker.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user_10086</para>
            /// </summary>
            [NameInMap("handlerId")]
            [Validation(Required=false)]
            public string HandlerId { get; set; }

            /// <summary>
            /// <para>The nodeKey of the actual running node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>node_key_confirm</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The display name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Requirement Confirmation</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The actual node type. Valid values: AGENT, HUMAN, and CONDITION.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The running status of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The time when the current plan reached a terminal state. This value is null if the plan has not ended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16T10:30:00+08:00</para>
        /// </summary>
        [NameInMap("endedAt")]
        [Validation(Required=false)]
        public string EndedAt { get; set; }

        /// <summary>
        /// <para>The external initiator label. This label is not used for authentication.</para>
        /// 
        /// <b>Example:</b>
        /// <para>External Initiator Zhang San</para>
        /// </summary>
        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        /// <summary>
        /// <para>The stable logical instance ID. This ID does not change when the work item is restarted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wfi_20261016_abc123</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The user-visible error description from the unified POP response wrapper.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The raw plan pause scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALL</para>
        /// </summary>
        [NameInMap("pauseScope")]
        [Validation(Required=false)]
        public string PauseScope { get; set; }

        /// <summary>
        /// <para>The revision ID of the current physical plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_20261016_abc123</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

        /// <summary>
        /// <para>The visible graph progress.</para>
        /// </summary>
        [NameInMap("progress")]
        [Validation(Required=false)]
        public GetWorkflowInstanceResponseBodyProgress Progress { get; set; }
        public class GetWorkflowInstanceResponseBodyProgress : TeaModel {
            /// <summary>
            /// <para>The number of visible nodes that have succeeded or been skipped.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("completedCount")]
            [Validation(Required=false)]
            public long? CompletedCount { get; set; }

            /// <summary>
            /// <para>The total number of visible nodes in the current graph. This number is not fixed to six.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("totalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The raw plan review status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>APPROVED</para>
        /// </summary>
        [NameInMap("reviewStatus")]
        [Validation(Required=false)]
        public string ReviewStatus { get; set; }

        /// <summary>
        /// <para>The revision number of the current physical plan.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <para>The current run ID. This ID changes after a restart.</para>
        /// 
        /// <b>Example:</b>
        /// <para>run_20261016_abc123</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>The raw runtime status. Valid values: BUILDING, RUNNING, SUCCEEDED, FAILED, and CANCELLED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("runtimeStatus")]
        [Validation(Required=false)]
        public string RuntimeStatus { get; set; }

        /// <summary>
        /// <para>The time when the current plan node started for the first time. This value is null if the node has not been executed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-10-16T10:30:00+08:00</para>
        /// </summary>
        [NameInMap("startedAt")]
        [Validation(Required=false)]
        public string StartedAt { get; set; }

        /// <summary>
        /// <para>The runtime status version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

        /// <summary>
        /// <para>Running/Completed/Failed/Terminated</para>
        /// 
        /// <b>Example:</b>
        /// <para>Running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The ID of the workflow template bound at creation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft_20261016_abc123</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The current requirement title.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly Business Analysis Report</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The ID of the associated work item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_20261016_abc123</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

    }

}
