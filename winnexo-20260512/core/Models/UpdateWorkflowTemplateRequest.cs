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
        /// <item><description>SAVE: Saves the template as a draft without taking effect.</description></item>
        /// <item><description>SUBMIT: Saves and submits the template, setting it as the only effective version.
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
        /// <para>group_example</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The complete JSON definition of the template to overwrite the existing one.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("definition")]
        [Validation(Required=false)]
        public Dictionary<string, object> Definition { get; set; }

        /// <summary>
        /// <para>The submitted version number on which the new version is based. This parameter is mutually exclusive with the version parameter. If not specified, the current effective version is used as the fallback.</para>
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
        /// <para>tpl_example</para>
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
        /// <para>The draft template version number to write. The format is a lowercase v followed by a positive integer, such as v1. Submitted versions cannot be written. If not specified, a new version is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v2</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description. The maximum length is 500 characters. When writing a draft, if this parameter is not specified or is null, the original value is retained. An empty string clears the value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Add a review step</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

    }

}
