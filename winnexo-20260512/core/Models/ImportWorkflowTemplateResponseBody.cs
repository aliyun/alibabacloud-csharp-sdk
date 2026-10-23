// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ImportWorkflowTemplateResponseBody : TeaModel {
        /// <summary>
        /// <para>The business status code. A value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The user ID of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("createdByUserId")]
        [Validation(Required=false)]
        public long? CreatedByUserId { get; set; }

        /// <summary>
        /// <para>The template description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The current effective version number of the template. An empty value indicates that only a draft exists and the template cannot be used for work items. Importing a template always creates a v1 draft, so this field is empty.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("effectiveVersion")]
        [Validation(Required=false)]
        public string EffectiveVersion { get; set; }

        /// <summary>
        /// <para>The creation time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The template name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request tracking ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ordered steps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("steps")]
        [Validation(Required=false)]
        public List<ImportWorkflowTemplateResponseBodySteps> Steps { get; set; }
        public class ImportWorkflowTemplateResponseBodySteps : TeaModel {
            /// <summary>
            /// <para>The model tier.</para>
            /// 
            /// <b>Example:</b>
            /// <para>standard</para>
            /// </summary>
            [NameInMap("modelMode")]
            [Validation(Required=false)]
            public string ModelMode { get; set; }

            /// <summary>
            /// <para>The step name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the responsible agent.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ownerAgentName")]
            [Validation(Required=false)]
            public string OwnerAgentName { get; set; }

            /// <summary>
            /// <para>The type of the responsible party. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>MEMBER: human.</description></item>
            /// <item><description>AGENT: agent.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MEMBER</para>
            /// </summary>
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The user ID of the human responsible party.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public long? OwnerUserId { get; set; }

            /// <summary>
            /// <para>The list of user IDs for the reviewers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("reviewerUserIds")]
            [Validation(Required=false)]
            public List<long?> ReviewerUserIds { get; set; }

            /// <summary>
            /// <para>The step order.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("sortOrder")]
            [Validation(Required=false)]
            public long? SortOrder { get; set; }

            /// <summary>
            /// <para>The processing instructions for the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            /// <summary>
            /// <para>The structured array of processing instructions for the step. This array supports text, mention, skill, app, files, and web_search types. All fragment fields and nested attachments are preserved exactly as returned by the backend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;text&quot;,&quot;content&quot;:&quot;Organize input materials&quot;}]</para>
            /// </summary>
            [NameInMap("specificationJson")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> SpecificationJson { get; set; }

            /// <summary>
            /// <para>The step ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>collect</para>
            /// </summary>
            [NameInMap("stepId")]
            [Validation(Required=false)]
            public string StepId { get; set; }

        }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl_example</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The version number generated by this import.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DRAFT: draft.</description></item>
        /// <item><description>SUBMITTED: submitted.
        /// The status is always set to DRAFT for imported templates.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("versionStatus")]
        [Validation(Required=false)]
        public string VersionStatus { get; set; }

    }

}
