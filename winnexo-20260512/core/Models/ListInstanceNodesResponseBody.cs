// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListInstanceNodesResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码；成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>物理实例ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_example</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>按拓扑顺序排列的可见节点，数量由实际动态图决定</para>
        /// 
        /// <b>Example:</b>
        /// <para>[]</para>
        /// </summary>
        [NameInMap("nodes")]
        [Validation(Required=false)]
        public List<ListInstanceNodesResponseBodyNodes> Nodes { get; set; }
        public class ListInstanceNodesResponseBodyNodes : TeaModel {
            /// <summary>
            /// <para>节点结果结论，无结论时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>分析完成</para>
            /// </summary>
            [NameInMap("conclusion")]
            [Validation(Required=false)]
            public string Conclusion { get; set; }

            /// <summary>
            /// <para>从首次运行到终态的整秒数，缺时间时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>节点首次运行时间，历史或未运行节点为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:00:00Z</para>
            /// </summary>
            [NameInMap("enteredAt")]
            [Validation(Required=false)]
            public string EnteredAt { get; set; }

            /// <summary>
            /// <para>节点实际进入终态的时间，未结束时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-14T08:02:03Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>节点负责人展示名称，未知时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>客户成功经理助理</para>
            /// </summary>
            [NameInMap("handler")]
            [Validation(Required=false)]
            public string Handler { get; set; }

            /// <summary>
            /// <para>节点在工作流图中的泳道位置</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("lane")]
            [Validation(Required=false)]
            public long? Lane { get; set; }

            /// <summary>
            /// <para>所属节点key（nodeKey），不是会话ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>节点展示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>查询签单金额</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>节点在返回拓扑列表中的展示序号，从1开始</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("nodeOrder")]
            [Validation(Required=false)]
            public long? NodeOrder { get; set; }

            /// <summary>
            /// <para>实际节点类型，例如AGENT或HUMAN</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("nodeType")]
            [Validation(Required=false)]
            public string NodeType { get; set; }

            /// <summary>
            /// <para>节点在工作流图中的层级，从0开始</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("rank")]
            [Validation(Required=false)]
            public long? Rank { get; set; }

            /// <summary>
            /// <para>原始节点运行状态，例如READY、RUNNING、WAITING、SUCCEEDED或FAILED</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>等待原因：HUMAN_INPUT、HUMAN_STEP、REVIEW、MANUAL_PAUSE或UNBLOCK；未等待时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>REVIEW</para>
            /// </summary>
            [NameInMap("waitType")]
            [Validation(Required=false)]
            public string WaitType { get; set; }

        }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>状态版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

    }

}
