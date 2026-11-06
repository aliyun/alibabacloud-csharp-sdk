// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SendWorkItemMessageRequest : TeaModel {
        /// <summary>
        /// <para>目标会话所属的协作空间ID，必填，长度1至64，不能为空白。调用者须具有目标话题的查看和发送权限。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_9401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>用户发送的文本正文，必填，长度1至32768，不能全为空白；保留原有文本格式。</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>请根据刚才的讨论整理下一步行动清单。</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>已有自由探索话题的会话ID，长度1至128，可使用创建自由探索接口返回的conversation_id。与workItemId至少传一个，同时传入时须指向同一会话。</para>
        /// 
        /// <b>Example:</b>
        /// <para>01234567-89ab-4def-8123-456789abcdef</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>业务租户ID，可选。必须属于当前调用身份的可访问租户；无权访问时拒绝请求。未传时按现有鉴权规则解析租户，多租户用户无法唯一确定时需显式指定。</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>自由探索工作项ID，长度1至256；兼容legacy-topic:<conversationId>形式。与conversationId至少传一个，同时传入时须指向同一会话。普通工作项必须为FREE_EXPLORATION类型。</para>
        /// 
        /// <b>Example:</b>
        /// <para>wi_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("workItemId")]
        [Validation(Required=false)]
        public string WorkItemId { get; set; }

    }

}
