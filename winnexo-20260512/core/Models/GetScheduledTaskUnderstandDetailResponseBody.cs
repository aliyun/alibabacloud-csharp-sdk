// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskUnderstandDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The description of the status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ok</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The related objects.</para>
        /// </summary>
        [NameInMap("relatedObjects")]
        [Validation(Required=false)]
        public List<GetScheduledTaskUnderstandDetailResponseBodyRelatedObjects> RelatedObjects { get; set; }
        public class GetScheduledTaskUnderstandDetailResponseBodyRelatedObjects : TeaModel {
            /// <summary>
            /// <para>The mention type, such as objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("mentionType")]
            [Validation(Required=false)]
            public string MentionType { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The object ID. Pass the project task ID.</para>
            /// <list type="bullet">
            /// <item><description><para>For internal enterprise applications, this is the taskId obtained by calling the <a href="https://open.dingtalk.com/document/orgapp-server/create-a-project-task">Create a project task</a> operation.</para>
            /// </description></item>
            /// <item><description><para>For third-party enterprise applications, this is the taskId obtained by calling the <a href="https://open.dingtalk.com/document/isvapp-server/create-a-project-task">Create a project task</a> operation.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>The object type, such as customer. This parameter has a value when type is set to mention.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        /// <summary>
        /// <para>The related semantics.</para>
        /// </summary>
        [NameInMap("relatedSemantics")]
        [Validation(Required=false)]
        public List<GetScheduledTaskUnderstandDetailResponseBodyRelatedSemantics> RelatedSemantics { get; set; }
        public class GetScheduledTaskUnderstandDetailResponseBodyRelatedSemantics : TeaModel {
            /// <summary>
            /// <para>The information type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;level&quot;: &quot;VIP&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>The semantic entity name, such as customer or opportunity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("entity")]
            [Validation(Required=false)]
            public string Entity { get; set; }

        }

        /// <summary>
        /// <para>The related skills.</para>
        /// </summary>
        [NameInMap("relatedSkills")]
        [Validation(Required=false)]
        public List<GetScheduledTaskUnderstandDetailResponseBodyRelatedSkills> RelatedSkills { get; set; }
        public class GetScheduledTaskUnderstandDetailResponseBodyRelatedSkills : TeaModel {
            /// <summary>
            /// <para>The display name of the MCP service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SampleName.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The skill code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("skillCode")]
            [Validation(Required=false)]
            public string SkillCode { get; set; }

            /// <summary>
            /// <para>sourceIds</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("sourceIds")]
            [Validation(Required=false)]
            public List<string> SourceIds { get; set; }

        }

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
        /// <para>The task understanding description polished by the LLM.</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("taskUnderstand")]
        [Validation(Required=false)]
        public string TaskUnderstand { get; set; }

    }

}
