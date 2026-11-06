// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class RerunWorkflowNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>本次重跑影响的节点 key 列表，供调用方刷新；成功响应恒包含，错误响应可缺省</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;query.amount&quot;]</para>
        /// </summary>
        [NameInMap("affectedNodeKeys")]
        [Validation(Required=false)]
        public List<string> AffectedNodeKeys { get; set; }

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
        /// <para>错误描述</para>
        /// 
        /// <b>Example:</b>
        /// <para>请求的资源不存在</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>重跑后的当前物理计划ID；固定规划节点重跑可能生成新计划，后续查询应使用此值</para>
        /// 
        /// <b>Example:</b>
        /// <para>plan_new</para>
        /// </summary>
        [NameInMap("planId")]
        [Validation(Required=false)]
        public string PlanId { get; set; }

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
        /// <para>重跑后的当前计划修订号</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("revision")]
        [Validation(Required=false)]
        public long? Revision { get; set; }

        /// <summary>
        /// <para>当前工作流运行ID，固定节点生成新 revision 时保持不变</para>
        /// 
        /// <b>Example:</b>
        /// <para>run_20261105_01</para>
        /// </summary>
        [NameInMap("runId")]
        [Validation(Required=false)]
        public string RunId { get; set; }

        /// <summary>
        /// <para>重跑被接受后的工作流状态版本</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("stateVersion")]
        [Validation(Required=false)]
        public long? StateVersion { get; set; }

    }

}
