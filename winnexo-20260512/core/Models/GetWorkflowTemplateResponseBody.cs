// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetWorkflowTemplateResponseBody : TeaModel {
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
        /// <para>The description of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard process for handling customer complaints</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>节点依赖边；每项包含from/to，引用稳定stepId；显式空数组表示没有依赖</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;from&quot;:&quot;collect&quot;,&quot;to&quot;:&quot;deliver&quot;}]</para>
        /// </summary>
        [NameInMap("edges")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Edges { get; set; }

        /// <summary>
        /// <para>The current effective version number of the template. An empty value indicates that only a draft exists and it cannot be used for work items.</para>
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
        /// <para>可选画布布局，按stepId索引；只影响展示，不决定依赖</para>
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
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Customer complaint handling process</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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
        public List<GetWorkflowTemplateResponseBodySteps> Steps { get; set; }
        public class GetWorkflowTemplateResponseBodySteps : TeaModel {
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
            /// <para>The processing instructions for the step.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Collect customer information and submit it to the owner for review</para>
            /// </summary>
            [NameInMap("specification")]
            [Validation(Required=false)]
            public string Specification { get; set; }

            /// <summary>
            /// <para>The array of structured segments for the step instructions. Supported types include text, mention, skill, app, files, and web_search. The fields and nested attachments of each segment are preserved exactly as returned by the backend.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{&quot;type&quot;:&quot;text&quot;,&quot;content&quot;:&quot;整理输入资料&quot;}]</para>
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

        /// <summary>
        /// <para>The ID of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl_9401</para>
        /// </summary>
        [NameInMap("templateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The optimistic version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>The version description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Added a review step</para>
        /// </summary>
        [NameInMap("versionDescription")]
        [Validation(Required=false)]
        public string VersionDescription { get; set; }

        /// <summary>
        /// <para>The version status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>DRAFT: Draft.</description></item>
        /// <item><description>SUBMITTED: Submitted.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SUBMITTED</para>
        /// </summary>
        [NameInMap("versionStatus")]
        [Validation(Required=false)]
        public string VersionStatus { get; set; }

    }

}
