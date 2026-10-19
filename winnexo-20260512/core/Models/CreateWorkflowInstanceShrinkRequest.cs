// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateWorkflowInstanceShrinkRequest : TeaModel {
        /// <summary>
        /// <para>Workflow 必填验收标准</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>完成全部审批节点并产出报告</para>
        /// </summary>
        [NameInMap("acceptanceCriteria")]
        [Validation(Required=false)]
        public string AcceptanceCriteria { get; set; }

        /// <summary>
        /// <para>空间内唯一需求编号，重复请求幂等</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-1001</para>
        /// </summary>
        [NameInMap("businessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        /// <summary>
        /// <para>协作空间 ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_20261016_abc123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>外部发起人展示标签</para>
        /// 
        /// <b>Example:</b>
        /// <para>外部发起人张三</para>
        /// </summary>
        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        /// <summary>
        /// <para>工作项优先级</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>工作流模板 ID，最多 64 字符</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft_20261016_abc123</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；winnexo-cli 通过 --tenant-id 显式传入</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>需求标题</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>季度经营分析报告</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>业务变量对象，tags 可为字符串标签列表</para>
        /// 
        /// <b>Example:</b>
        /// <para>tags=季度报告</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public string VariablesShrink { get; set; }

    }

}
