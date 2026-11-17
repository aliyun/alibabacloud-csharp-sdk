// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class UpdateWorkflowTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The write action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>SAVE: Saves the template as a draft without taking effect, allowing node names and executors to be left empty.</description></item>
        /// <item><description>SUBMIT: Requires complete nodes, and saves and submits the template as the only effective version.
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
        /// <para>The collaboration workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_9401</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The complete JSON definition of the template for full overwriting.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Customer Complaint Handling Process&quot;,&quot;schemaVersion&quot;:2,&quot;steps&quot;:[{&quot;stepId&quot;:&quot;collect&quot;,&quot;sortOrder&quot;:1,&quot;name&quot;:&quot;Collect Customer Information&quot;}]}</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public Dictionary<string, object> Definition { get; set; }

        /// <summary>
        /// <para>The submitted version number on which the new version is based. This parameter is mutually exclusive with version. If not specified, the system falls back to the current effective version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("sourceVersion")]
        [Validation(Required=false)]
        public string SourceVersion { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
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
        /// <para>The version number to which the returned content belongs.</para>
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
        /// <para>Added review step</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
