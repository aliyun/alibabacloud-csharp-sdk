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
        /// <para>example</para>
        /// </summary>
        [NameInMap("template")]
        [Validation(Required=false)]
        public ExportWorkflowTemplateResponseBodyTemplate Template { get; set; }
        public class ExportWorkflowTemplateResponseBodyTemplate : TeaModel {
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
            /// <para>The template name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The normalization steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
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
                /// <para>example</para>
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The array of structured segments for the step instructions. Supported types include text, mention, skill, app, files, and web_search. All segment fields and nested attachments are preserved exactly as returned by the backend.</para>
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
