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
        /// <para>Standard process for handling customer complaints</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>A node dependency edge, where from is the stepId of the predecessor node and to is the stepId of the successor node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;from&quot;:&quot;collect&quot;,&quot;to&quot;:&quot;deliver&quot;}]</para>
        /// </summary>
        [NameInMap("edges")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Edges { get; set; }

        /// <summary>
        /// <para>The current effective version number of the template. An empty value indicates that only a draft exists and it cannot be used for work items. The value is empty for imported templates because a v1 draft is created by default.</para>
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
        /// <para>2026-11-05T08:00:00Z</para>
        /// </summary>
        [NameInMap("gmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// <para>The modification time in ISO 8601 format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2026-11-05T08:00:00Z</para>
        /// </summary>
        [NameInMap("gmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// <para>The optional canvas layout, indexed by stepId. This parameter only affects the display and does not determine dependencies.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;collect&quot;:{&quot;x&quot;:0,&quot;y&quot;:0},&quot;review&quot;:{&quot;x&quot;:240,&quot;y&quot;:0}}</para>
        /// </summary>
        [NameInMap("layout")]
        [Validation(Required=false)]
        public Dictionary<string, object> Layout { get; set; }

        /// <summary>
        /// <para>The error message.</para>
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
        /// <para>Customer complaint handling process</para>
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
        /// <para>The template structure version. The current value is 2, which is independent of the business version vN.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("schemaVersion")]
        [Validation(Required=false)]
        public long? SchemaVersion { get; set; }

        /// <summary>
        /// <para>The ordered steps.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;stepId&quot;:&quot;collect&quot;,&quot;sortOrder&quot;:1,&quot;name&quot;:&quot;Collect customer information&quot;}]</para>
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
            /// <para>Customer complaint handling process</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The name of the agent owner.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("ownerAgentName")]
            [Validation(Required=false)]
            public string OwnerAgentName { get; set; }

            /// <summary>
            /// <para>The owner type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>USER</b>: User type. This is the default value.</para>
            /// </description></item>
            /// <item><description><para><b>APP</b>: Application type.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>MEMBER</para>
            /// </summary>
            [NameInMap("ownerType")]
            [Validation(Required=false)]
            public string OwnerType { get; set; }

            /// <summary>
            /// <para>The user ID of the employee executor.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("ownerUserId")]
            [Validation(Required=false)]
            public long? OwnerUserId { get; set; }

            /// <summary>
            /// <para>Specifies whether to manually review the deliverables. By default, this feature is disabled. It can be enabled only for digital employees. Review tasks are automatically sent to the person in charge.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("reviewOutput")]
            [Validation(Required=false)]
            public bool? ReviewOutput { get; set; }

            /// <summary>
            /// <para>The list of user IDs of the persons in charge. This parameter is valid only for digital employee executor steps and is always empty for member executor steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[10001]</para>
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
            /// <para>The step processing instructions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collect customer information and submit it to the person in charge for review</para>
            /// </summary>
            [NameInMap("specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            /// <summary>
            /// <para>The ordered array of fragments, which supports text, mention, skill, app, files, and web_search. The referenced identities and order are preserved.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;text&quot;,&quot;content&quot;:&quot;Collect customer information&quot;}]</para>
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
        /// <para>tpl_9401</para>
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
        /// <para>The version status. Valid values: DRAFT and SUBMITTED. The value is fixed to DRAFT for imported templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DRAFT</para>
        /// </summary>
        [NameInMap("versionStatus")]
        [Validation(Required=false)]
        public string VersionStatus { get; set; }

    }

}
