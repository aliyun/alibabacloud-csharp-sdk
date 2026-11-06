// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateFreeExplorationWorkItemResponseBody : TeaModel {
        /// <summary>
        /// <para>已选择的数字员工技术名称</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sales-agent&quot;]</para>
        /// </summary>
        [NameInMap("agentNames")]
        [Validation(Required=false)]
        public List<string> AgentNames { get; set; }

        /// <summary>
        /// <para>业务状态码，成功为200</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>所属协作空间 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_9401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>真实群话题 ID，可在 queryWorkItemFeed 中关联；不可作为 Workflow workItemId</para>
        /// 
        /// <b>Example:</b>
        /// <para>conv_20261105_9f2c</para>
        /// </summary>
        [NameInMap("conversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>平台创建人用户 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>10001</para>
        /// </summary>
        [NameInMap("createdByUserId")]
        [Validation(Required=false)]
        public long? CreatedByUserId { get; set; }

        /// <summary>
        /// <para>工作项模式，固定 FREE_EXPLORATION</para>
        /// 
        /// <b>Example:</b>
        /// <para>FREE_EXPLORATION</para>
        /// </summary>
        [NameInMap("itemType")]
        [Validation(Required=false)]
        public string ItemType { get; set; }

        /// <summary>
        /// <para>实际话题成员，含创建人；公开档不枚举全空间成员</para>
        /// 
        /// <b>Example:</b>
        /// <para>[43]</para>
        /// </summary>
        [NameInMap("memberUserIds")]
        [Validation(Required=false)]
        public List<long?> MemberUserIds { get; set; }

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
        /// <para>请求追踪ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>工作项标题</para>
        /// 
        /// <b>Example:</b>
        /// <para>调查销售机会</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>实际可见范围 PRIVATE/COLLABORATIVE/PUBLIC</para>
        /// 
        /// <b>Example:</b>
        /// <para>PRIVATE</para>
        /// </summary>
        [NameInMap("visibility")]
        [Validation(Required=false)]
        public string Visibility { get; set; }

    }

}
