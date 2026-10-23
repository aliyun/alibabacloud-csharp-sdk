// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListInstanceNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The physical instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_example</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The visible nodes arranged in topological order. The number of nodes is determined by the actual dynamic graph.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<ListInstanceNodesResponseBodyNodes> Nodes { get; set; }
        public class ListInstanceNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>The conclusion of the node result. This field is empty if there is no conclusion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Analysis completed</para>
            /// </summary>
            [NameInMap("conclusion")]
            [Validation(Required=false)]
            public string Conclusion { get; set; }

            /// <summary>
            /// <para>The total number of seconds from the first run to the desired state. This field is empty if the time is missing.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>The time when the node was first run. This field is empty for historical or unrun nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:00:00Z</para>
            /// </summary>
            [NameInMap("enteredAt")]
            [Validation(Required=false)]
            public string EnteredAt { get; set; }

            /// <summary>
            /// <para>The time when the node actually entered the desired state. This field is empty if the node has not finished.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:02:03Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>The display name of the node assignee. This field is empty if the assignee is unknown.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Assistant Customer Success Manager (CSM)</para>
            /// </summary>
            [NameInMap("handler")]
            [Validation(Required=false)]
            public string Handler { get; set; }

            /// <summary>
            /// <para>The lane position of the node in the workflow graph.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lane")]
            [Validation(Required=false)]
            public long? Lane { get; set; }

            /// <summary>
            /// <para>The key of the node (nodeKey). This is not the session ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>The display name of the node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Query signed contract amount</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>The display sequence number of the node in the returned topology list, starting from 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("nodeOrder")]
            [Validation(Required=false)]
            public long? NodeOrder { get; set; }

            /// <summary>
            /// <para>The actual node type, such as AGENT or HUMAN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>The level of the node in the workflow graph, starting from 0.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("rank")]
            [Validation(Required=false)]
            public long? Rank { get; set; }

            /// <summary>
            /// <para>The original running status of the node, such as READY, RUNNING, WAITING, SUCCEEDED, or FAILED.</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The reason for waiting, such as HUMAN_INPUT, HUMAN_STEP, REVIEW, MANUAL_PAUSE, or UNBLOCK. This field is empty if the node is not waiting.</para>
            /// 
            /// <b>Example:</b>
            /// <para>REVIEW</para>
            /// </summary>
            [NameInMap("waitType")]
            [Validation(Required=false)]
            public string WaitType { get; set; }

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
        /// <para>The state version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

    }

}
