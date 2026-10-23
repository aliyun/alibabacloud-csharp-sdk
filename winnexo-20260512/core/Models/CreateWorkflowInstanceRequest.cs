// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateWorkflowInstanceRequest : TeaModel {
        /// <summary>
        /// <para>The required acceptance criteria for the workflow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Complete all approval nodes and generate the report</para>
        /// </summary>
        [NameInMap("acceptanceCriteria")]
        [Validation(Required=false)]
        public string AcceptanceCriteria { get; set; }

        /// <summary>
        /// <para>The unique requirement ID in the workspace. Repeated requests are idempotent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>REQ-1001</para>
        /// </summary>
        [NameInMap("businessId")]
        [Validation(Required=false)]
        public string BusinessId { get; set; }

        /// <summary>
        /// <para>The collaboration workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_20261016_abc123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The display label of the external initiator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>External Initiator Zhang San</para>
        /// </summary>
        [NameInMap("initiator")]
        [Validation(Required=false)]
        public string Initiator { get; set; }

        /// <summary>
        /// <para>The work item priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HIGH</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The workflow template ID. Maximum length: 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wft_20261016_abc123</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter explicitly passed by using --tenant-id in winnexo-cli.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The requirement title.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Quarterly Business Analysis Report</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The business variable object. The tags field can be a list of string tags.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tags=Quarterly Report</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
