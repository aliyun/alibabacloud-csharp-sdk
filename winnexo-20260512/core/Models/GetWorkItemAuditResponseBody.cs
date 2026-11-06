// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkItemAuditResponseBody : TeaModel {
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
        /// <para>按事件时间倒序排列的完整工作项审计记录</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;eventId&quot;:&quot;evt_example&quot;,&quot;eventType&quot;:&quot;WORK_ITEM_UPDATED&quot;,&quot;occurredAt&quot;:&quot;2026-11-05T08:00:00Z&quot;,&quot;status&quot;:&quot;SUCCESS&quot;}]</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<GetWorkItemAuditResponseBodyItems> Items { get; set; }
        public class GetWorkItemAuditResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>字段变更明细列表，每项包含变更字段与前后值</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;field&quot;:&quot;title&quot;,&quot;before&quot;:&quot;旧标题&quot;,&quot;after&quot;:&quot;新标题&quot;}]</para>
            /// </summary>
            [NameInMap("changes")]
            [Validation(Required=false)]
            public object Changes { get; set; }

            /// <summary>
            /// <para>事件描述</para>
            /// 
            /// <b>Example:</b>
            /// <para>工作项标题调整为季度销售机会复盘</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>审计事件唯一标识</para>
            /// 
            /// <b>Example:</b>
            /// <para>evt_20261105_0001</para>
            /// </summary>
            [NameInMap("eventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>审计事件类型，如 WORK_ITEM_UPDATED、TODO_COMPLETED</para>
            /// 
            /// <b>Example:</b>
            /// <para>WORK_ITEM_UPDATED</para>
            /// </summary>
            [NameInMap("eventType")]
            [Validation(Required=false)]
            public string EventType { get; set; }

            /// <summary>
            /// <para>事件发生时间，ISO8601 格式</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-11-05T08:00:00Z</para>
            /// </summary>
            [NameInMap("occurredAt")]
            [Validation(Required=false)]
            public string OccurredAt { get; set; }

            /// <summary>
            /// <para>操作人显示名</para>
            /// 
            /// <b>Example:</b>
            /// <para>张三</para>
            /// </summary>
            [NameInMap("operatorName")]
            [Validation(Required=false)]
            public string OperatorName { get; set; }

            /// <summary>
            /// <para>操作人用户 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>10001</para>
            /// </summary>
            [NameInMap("operatorUserId")]
            [Validation(Required=false)]
            public string OperatorUserId { get; set; }

            /// <summary>
            /// <para>事件涉及的待确认问题列表</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;question&quot;:&quot;是否继续执行&quot;}]</para>
            /// </summary>
            [NameInMap("questions")]
            [Validation(Required=false)]
            public List<object> Questions { get; set; }

            /// <summary>
            /// <para>事件结果负载，JSON 对象；无结果时为空</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;result&quot;:&quot;ok&quot;}</para>
            /// </summary>
            [NameInMap("resultPayload")]
            [Validation(Required=false)]
            public object ResultPayload { get; set; }

            /// <summary>
            /// <para>事件状态</para>
            /// 
            /// <b>Example:</b>
            /// <para>ACTIVE</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>事件标题</para>
            /// 
            /// <b>Example:</b>
            /// <para>调查销售机会</para>
            /// </summary>
            [NameInMap("title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>关联待办 ID；无关联时为空字符串</para>
            /// 
            /// <b>Example:</b>
            /// <para>todo_20261105_0007</para>
            /// </summary>
            [NameInMap("todoId")]
            [Validation(Required=false)]
            public string TodoId { get; set; }

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
