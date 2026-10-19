// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ListWorkflowInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码，来自统一 POP 响应包装</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>当前页实例列表</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<ListWorkflowInstancesResponseBodyItems> Items { get; set; }
        public class ListWorkflowInstancesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>空间内唯一外部需求编号</para>
            /// 
            /// <b>Example:</b>
            /// <para>REQ-1001</para>
            /// </summary>
            [NameInMap("businessId")]
            [Validation(Required=false)]
            public string BusinessId { get; set; }

            /// <summary>
            /// <para>协作空间 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>cg_20261016_abc123</para>
            /// </summary>
            [NameInMap("collaborationGroupId")]
            [Validation(Required=false)]
            public string CollaborationGroupId { get; set; }

            /// <summary>
            /// <para>逻辑实例创建时间，ISO8601</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>首个活动节点，终态为 null</para>
            /// </summary>
            [NameInMap("currentNode")]
            [Validation(Required=false)]
            public ListWorkflowInstancesResponseBodyItemsCurrentNode CurrentNode { get; set; }
            public class ListWorkflowInstancesResponseBodyItemsCurrentNode : TeaModel {
                /// <summary>
                /// <para>当前处理人展示名</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("handler")]
                [Validation(Required=false)]
                public string Handler { get; set; }

                /// <summary>
                /// <para>处理人或数字员工标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_10086</para>
                /// </summary>
                [NameInMap("handlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                /// <summary>
                /// <para>真实运行节点 nodeKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>node_key_confirm</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>节点展示名</para>
                /// 
                /// <b>Example:</b>
                /// <para>需求确认</para>
                /// </summary>
                [NameInMap("nodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>真实节点类型 AGENT/HUMAN/CONDITION</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("nodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>节点运行状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>全部活动节点，支持并行 DAG</para>
            /// </summary>
            [NameInMap("currentNodes")]
            [Validation(Required=false)]
            public List<ListWorkflowInstancesResponseBodyItemsCurrentNodes> CurrentNodes { get; set; }
            public class ListWorkflowInstancesResponseBodyItemsCurrentNodes : TeaModel {
                /// <summary>
                /// <para>当前处理人展示名</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("handler")]
                [Validation(Required=false)]
                public string Handler { get; set; }

                /// <summary>
                /// <para>处理人或数字员工标识</para>
                /// 
                /// <b>Example:</b>
                /// <para>user_10086</para>
                /// </summary>
                [NameInMap("handlerId")]
                [Validation(Required=false)]
                public string HandlerId { get; set; }

                /// <summary>
                /// <para>真实运行节点 nodeKey</para>
                /// 
                /// <b>Example:</b>
                /// <para>node_key_confirm</para>
                /// </summary>
                [NameInMap("nodeId")]
                [Validation(Required=false)]
                public string NodeId { get; set; }

                /// <summary>
                /// <para>节点展示名</para>
                /// 
                /// <b>Example:</b>
                /// <para>需求确认</para>
                /// </summary>
                [NameInMap("nodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                /// <summary>
                /// <para>真实节点类型 AGENT/HUMAN/CONDITION</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("nodeType")]
                [Validation(Required=false)]
                public string NodeType { get; set; }

                /// <summary>
                /// <para>节点运行状态</para>
                /// 
                /// <b>Example:</b>
                /// <para>Running</para>
                /// </summary>
                [NameInMap("status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>当前计划终态时间，未结束为 null</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("endedAt")]
            [Validation(Required=false)]
            public string EndedAt { get; set; }

            /// <summary>
            /// <para>外部发起人标签，不参与鉴权</para>
            /// 
            /// <b>Example:</b>
            /// <para>外部发起人张三</para>
            /// </summary>
            [NameInMap("initiator")]
            [Validation(Required=false)]
            public string Initiator { get; set; }

            /// <summary>
            /// <para>稳定逻辑实例 ID，工作项重启不改变</para>
            /// 
            /// <b>Example:</b>
            /// <para>wfi_20261016_abc123</para>
            /// </summary>
            [NameInMap("instanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>原始计划暂停范围</para>
            /// 
            /// <b>Example:</b>
            /// <para>ALL</para>
            /// </summary>
            [NameInMap("pauseScope")]
            [Validation(Required=false)]
            public string PauseScope { get; set; }

            /// <summary>
            /// <para>当前物理计划修订 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan_20261016_abc123</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>可见图进度</para>
            /// </summary>
            [NameInMap("progress")]
            [Validation(Required=false)]
            public ListWorkflowInstancesResponseBodyItemsProgress Progress { get; set; }
            public class ListWorkflowInstancesResponseBodyItemsProgress : TeaModel {
                /// <summary>
                /// <para>已成功或跳过的可见节点数</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("completedCount")]
                [Validation(Required=false)]
                public long? CompletedCount { get; set; }

                /// <summary>
                /// <para>当前图可见节点总数，非固定六节点</para>
                /// 
                /// <b>Example:</b>
                /// <para>5</para>
                /// </summary>
                [NameInMap("totalCount")]
                [Validation(Required=false)]
                public long? TotalCount { get; set; }

            }

            /// <summary>
            /// <para>原始计划审核状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>APPROVED</para>
            /// </summary>
            [NameInMap("reviewStatus")]
            [Validation(Required=false)]
            public string ReviewStatus { get; set; }

            /// <summary>
            /// <para>当前物理计划修订号</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("revision")]
            [Validation(Required=false)]
            public long? Revision { get; set; }

            /// <summary>
            /// <para>当前运行 ID，重启后会改变</para>
            /// 
            /// <b>Example:</b>
            /// <para>run_20261016_abc123</para>
            /// </summary>
            [NameInMap("runId")]
            [Validation(Required=false)]
            public string RunId { get; set; }

            /// <summary>
            /// <para>原始 BUILDING/RUNNING/SUCCEEDED/FAILED/CANCELLED</para>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("runtimeStatus")]
            [Validation(Required=false)]
            public string RuntimeStatus { get; set; }

            /// <summary>
            /// <para>当前计划节点首次开始时间，未执行为 null</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-10-16T10:30:00+08:00</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <para>运行状态版本</para>
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
            /// <para>创建时绑定的工作流模板 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>wft_20261016_abc123</para>
            /// </summary>
            [NameInMap("templateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>当前需求标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>季度经营分析报告</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>关联工作项 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>wi_20261016_abc123</para>
            /// </summary>
            [NameInMap("workItemId")]
            [Validation(Required=false)]
            public string WorkItemId { get; set; }

        }

        /// <summary>
        /// <para>用户可见错误描述，来自统一 POP 响应包装</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>当前页码</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>每页数量</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>筛选后可见实例总数</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

    }

}
