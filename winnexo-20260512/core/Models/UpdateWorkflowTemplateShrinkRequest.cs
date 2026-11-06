// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateWorkflowTemplateShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The write action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SAVE: Saves the template as a draft. The changes do not take effect. Node names and assignees can be left empty.</description></item>
        /// <item><description>SUBMIT: Requires complete nodes. Saves and submits the template as the only effective version.
        /// Default value: SUBMIT.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUBMIT</para>
        /// </summary>
        [NameInMap("action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_9401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The complete JSON definition of the template. This overwrites the existing definition.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Customer Complaint Handling Process&quot;,&quot;schemaVersion&quot;:2,&quot;steps&quot;:[{&quot;stepId&quot;:&quot;collect&quot;,&quot;sortOrder&quot;:1,&quot;name&quot;:&quot;Collect Customer Information&quot;}]}</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public string DefinitionShrink { get; set; }

        /// <summary>
        /// <para>The submitted version number on which the new version is based. This parameter is mutually exclusive with version. If you do not specify this parameter, the current effective version is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("sourceVersion")]
        [Validation(Required=false)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl_9401</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The version number to which the content belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The change description for this version. An empty value indicates that no description is provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Added a review step</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
