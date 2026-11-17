// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class ExportWorkflowTemplateResponseBody : TeaModel {
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
        /// <para>The error description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource does not exist</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        /// <para>The simplified template definition that can be re-imported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Customer Complaint Handling Process&quot;,&quot;schemaVersion&quot;:2}</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public ExportWorkflowTemplateResponseBodyTemplate Template { get; set; }
        public class ExportWorkflowTemplateResponseBodyTemplate : TeaModel {
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
            /// <para>The node dependency edges. Each item contains from and to fields that reference stable step IDs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("edges")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Edges { get; set; }

            /// <summary>
            /// <para>The optional canvas layout, indexed by step ID. This only affects the display and does not determine dependencies.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;collect&quot;:{&quot;x&quot;:0,&quot;y&quot;:0},&quot;review&quot;:{&quot;x&quot;:240,&quot;y&quot;:0}}</para>
            /// </summary>
            [NameInMap("layout")]
            [Validation(Required=false)]
            public Dictionary<string, object> Layout { get; set; }

            /// <summary>
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer Complaint Handling Process</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The schema version of the template. The current value is 2, which is independent of the business version vN.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("schemaVersion")]
            [Validation(Required=false)]
            public long? SchemaVersion { get; set; }

            /// <summary>
            /// <para>The normalized steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;stepId&quot;:&quot;collect&quot;,&quot;sortOrder&quot;:1,&quot;name&quot;:&quot;Collect customer information&quot;}]</para>
            /// </summary>
            [NameInMap("steps")]
            [Validation(Required=false)]
            public List<ExportWorkflowTemplateResponseBodyTemplateSteps> Steps { get; set; }
            public class ExportWorkflowTemplateResponseBodyTemplateSteps : TeaModel {
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
                /// <para>Customer Complaint Handling Process</para>
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
                /// <item><description>MEMBER: Human.</description></item>
                /// <item><description>AGENT: Agent.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>MEMBER</para>
                /// </summary>
                [NameInMap("ownerType")]
                [Validation(Required=false)]
                public string OwnerType { get; set; }

                /// <summary>
                /// <para>The user ID of the human owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ownerUserId")]
                [Validation(Required=false)]
                public long? OwnerUserId { get; set; }

                /// <summary>
                /// <para>Specifies whether to manually review the output. Default value: false. This can only be enabled for digital workers, and review tasks are automatically sent to the owner.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("reviewOutput")]
                [Validation(Required=false)]
                public bool? ReviewOutput { get; set; }

                /// <summary>
                /// <para>The list of user IDs of the reviewers.</para>
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
                /// <para>The step processing instructions.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collect customer information and submit it to the owner for review</para>
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>An ordered array of segments. Supports text, mention, skill, app, files, and web_search. Preserves reference identities and order.</para>
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

        }

    }

}
