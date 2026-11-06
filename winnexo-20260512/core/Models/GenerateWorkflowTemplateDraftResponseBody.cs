// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GenerateWorkflowTemplateDraftResponseBody : TeaModel {
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
        /// <para>The generated non-persistent template draft.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;schemaVersion\&quot;:2,\&quot;steps\&quot;:[]}</para>
        /// </summary>
        [NameInMap("draft")]
        [Validation(Required=false)]
        public GenerateWorkflowTemplateDraftResponseBodyDraft Draft { get; set; }
        public class GenerateWorkflowTemplateDraftResponseBodyDraft : TeaModel {
            /// <summary>
            /// <para>The description of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Standard process for handling customer complaints</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>节点依赖边；每项包含from/to，引用稳定stepId</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("edges")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Edges { get; set; }

            /// <summary>
            /// <para>可选画布布局，按stepId索引；只影响展示，不决定依赖</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;collect&quot;:{&quot;x&quot;:0,&quot;y&quot;:0},&quot;review&quot;:{&quot;x&quot;:240,&quot;y&quot;:0}}</para>
            /// </summary>
            [NameInMap("layout")]
            [Validation(Required=false)]
            public Dictionary<string, object> Layout { get; set; }

            /// <summary>
            /// <para>The name of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Customer complaint handling process</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>模板结构版本，当前为2，与业务版本vN独立</para>
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
            /// <para>[{\&quot;stepId\&quot;:\&quot;collect\&quot;,\&quot;sortOrder\&quot;:1,\&quot;name\&quot;:\&quot;收集客户信息\&quot;}]</para>
            /// </summary>
            [NameInMap("steps")]
            [Validation(Required=false)]
            public List<GenerateWorkflowTemplateDraftResponseBodyDraftSteps> Steps { get; set; }
            public class GenerateWorkflowTemplateDraftResponseBodyDraftSteps : TeaModel {
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
                /// <para>The name of the step.</para>
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
                /// <para>The type of the owner. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>MEMBER: human</description></item>
                /// <item><description>AGENT: agent</description></item>
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
                /// <para>是否人工审核产出物，默认关闭；仅数字员工可开启，审核待办自动发负责人</para>
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
                /// <para>The sort order of the step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("sortOrder")]
                [Validation(Required=false)]
                public long? SortOrder { get; set; }

                /// <summary>
                /// <para>The processing instructions of the step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Collect customer information and submit it to the owner for review</para>
                /// </summary>
                [NameInMap("specification")]
                [Validation(Required=false)]
                public string Specification { get; set; }

                /// <summary>
                /// <para>The ordered array of fragments. Supported types include text, mention, skill, app, files, and web_search. The referenced identities and order are preserved.</para>
                /// 
                /// <b>Example:</b>
                /// <para>[{\&quot;type\&quot;:\&quot;text\&quot;,\&quot;text\&quot;:\&quot;收集客户信息\&quot;}]</para>
                /// </summary>
                [NameInMap("specificationJson")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> SpecificationJson { get; set; }

                /// <summary>
                /// <para>The ID of the step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>collect</para>
                /// </summary>
                [NameInMap("stepId")]
                [Validation(Required=false)]
                public string StepId { get; set; }

            }

        }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
