// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkItemRunSummariesResponseBody : TeaModel {
        /// <summary>
        /// <para>公共业务状态码</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>当前计划、当前轮次已经生成的运行总结；重跑受影响节点的新总结生成前不会返回旧总结</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;attemptId&quot;:&quot;attempt_example&quot;,&quot;planId&quot;:&quot;plan_example&quot;,&quot;nodeKey&quot;:&quot;query.amount&quot;,&quot;nodeStatus&quot;:&quot;COMPLETED&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetWorkItemRunSummariesResponseBodyItems> Items { get; set; }
        public class GetWorkItemRunSummariesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>节点尝试 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>attempt_1</para>
            /// </summary>
            [NameInMap("attemptId")]
            [Validation(Required=false)]
            public string AttemptId { get; set; }

            /// <summary>
            /// <para>节点尝试序号，从 1 开始</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("attemptSeq")]
            [Validation(Required=false)]
            public long? AttemptSeq { get; set; }

            /// <summary>
            /// <para>执行器 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>agent_1001</para>
            /// </summary>
            [NameInMap("executorId")]
            [Validation(Required=false)]
            public string ExecutorId { get; set; }

            /// <summary>
            /// <para>执行器名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>销售分析助手</para>
            /// </summary>
            [NameInMap("executorName")]
            [Validation(Required=false)]
            public string ExecutorName { get; set; }

            /// <summary>
            /// <para>执行器类型，如 AGENT、HUMAN</para>
            /// 
            /// <b>Example:</b>
            /// <para>AGENT</para>
            /// </summary>
            [NameInMap("executorType")]
            [Validation(Required=false)]
            public string ExecutorType { get; set; }

            /// <summary>
            /// <para>节点结束时间，ISO8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:05:00Z</para>
            /// </summary>
            [NameInMap("finishedAt")]
            [Validation(Required=false)]
            public string FinishedAt { get; set; }

            /// <summary>
            /// <para>节点 key</para>
            /// 
            /// <b>Example:</b>
            /// <para>query.amount</para>
            /// </summary>
            [NameInMap("nodeKey")]
            [Validation(Required=false)]
            public string NodeKey { get; set; }

            /// <summary>
            /// <para>节点名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>查询销售金额</para>
            /// </summary>
            [NameInMap("nodeName")]
            [Validation(Required=false)]
            public string NodeName { get; set; }

            /// <summary>
            /// <para>节点状态，如 COMPLETED、FAILED</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("nodeStatus")]
            [Validation(Required=false)]
            public string NodeStatus { get; set; }

            /// <summary>
            /// <para>所属物理计划 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>plan_v3</para>
            /// </summary>
            [NameInMap("planId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }

            /// <summary>
            /// <para>节点执行结果，JSON 对象</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;rows&quot;:3}</para>
            /// </summary>
            [NameInMap("result")]
            [Validation(Required=false)]
            public object Result { get; set; }

            /// <summary>
            /// <para>运行总结正文；未生成时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>已完成销售金额查询，共返回 3 行数据</para>
            /// </summary>
            [NameInMap("runSummary")]
            [Validation(Required=false)]
            public object RunSummary { get; set; }

            /// <summary>
            /// <para>运行总结失败原因；成功时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>模型调用超时</para>
            /// </summary>
            [NameInMap("runSummaryError")]
            [Validation(Required=false)]
            public string RunSummaryError { get; set; }

            /// <summary>
            /// <para>运行总结生成时间，ISO8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:06:00Z</para>
            /// </summary>
            [NameInMap("runSummaryGeneratedAt")]
            [Validation(Required=false)]
            public string RunSummaryGeneratedAt { get; set; }

            /// <summary>
            /// <para>运行总结引用的数据来源列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;name&quot;:&quot;report.md&quot;}]</para>
            /// </summary>
            [NameInMap("runSummarySources")]
            [Validation(Required=false)]
            public List<object> RunSummarySources { get; set; }

            /// <summary>
            /// <para>运行总结生成状态，如 COMPLETED、FAILED、PROCESSING</para>
            /// 
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("runSummaryStatus")]
            [Validation(Required=false)]
            public string RunSummaryStatus { get; set; }

            /// <summary>
            /// <para>运行总结使用的工具列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;SKILL&quot;,&quot;name&quot;:&quot;sql_query&quot;}]</para>
            /// </summary>
            [NameInMap("runSummaryTools")]
            [Validation(Required=false)]
            public List<GetWorkItemRunSummariesResponseBodyItemsRunSummaryTools> RunSummaryTools { get; set; }
            public class GetWorkItemRunSummariesResponseBodyItemsRunSummaryTools : TeaModel {
                /// <summary>
                /// <para>工具名称</para>
                /// 
                /// <b>Example:</b>
                /// <para>销售分析助手</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>工具类型，如 SKILL、MCP</para>
                /// 
                /// <b>Example:</b>
                /// <para>AGENT</para>
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>节点开始时间，ISO8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:00:00Z</para>
            /// </summary>
            [NameInMap("startedAt")]
            [Validation(Required=false)]
            public string StartedAt { get; set; }

            /// <summary>
            /// <para>节点轮次序号，从 1 开始</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("turnSeq")]
            [Validation(Required=false)]
            public long? TurnSeq { get; set; }

        }

        /// <summary>
        /// <para>公共错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
