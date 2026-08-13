// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class GetScheduledTaskUnderstandDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>业务状态码：成功为 200，失败为后端错误码（ERR.* / InvalidParameter.*）</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>错误描述，成功时为空</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("relatedObjects")]
        [Validation(Required=false)]
        public List<GetScheduledTaskUnderstandDetailResponseBodyRelatedObjects> RelatedObjects { get; set; }
        public class GetScheduledTaskUnderstandDetailResponseBodyRelatedObjects : TeaModel {
            /// <summary>
            /// <para>提及类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("mentionType")]
            [Validation(Required=false)]
            public string MentionType { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>对象 ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>exampleObjectId</para>
            /// </summary>
            [NameInMap("objectId")]
            [Validation(Required=false)]
            public string ObjectId { get; set; }

            /// <summary>
            /// <para>对象类型</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("objectType")]
            [Validation(Required=false)]
            public string ObjectType { get; set; }

        }

        [NameInMap("relatedSemantics")]
        [Validation(Required=false)]
        public List<GetScheduledTaskUnderstandDetailResponseBodyRelatedSemantics> RelatedSemantics { get; set; }
        public class GetScheduledTaskUnderstandDetailResponseBodyRelatedSemantics : TeaModel {
            /// <summary>
            /// <para>语义属性（JSON 字符串），用于语义检索时过滤</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;level&quot;: &quot;VIP&quot;}</para>
            /// </summary>
            [NameInMap("attributes")]
            [Validation(Required=false)]
            public string Attributes { get; set; }

            /// <summary>
            /// <para>语义实体名，如客户/机会</para>
            /// 
            /// <b>Example:</b>
            /// <para>customer</para>
            /// </summary>
            [NameInMap("entity")]
            [Validation(Required=false)]
            public string Entity { get; set; }

        }

        [NameInMap("relatedSkills")]
        [Validation(Required=false)]
        public List<GetScheduledTaskUnderstandDetailResponseBodyRelatedSkills> RelatedSkills { get; set; }
        public class GetScheduledTaskUnderstandDetailResponseBodyRelatedSkills : TeaModel {
            /// <summary>
            /// <para>技能展示名称</para>
            /// 
            /// <b>Example:</b>
            /// <para>string_value</para>
            /// </summary>
            [NameInMap("displayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }

            /// <summary>
            /// <para>文件名</para>
            /// 
            /// <b>Example:</b>
            /// <para>示例名称.pdf</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>技能代码</para>
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
        /// <para>请求追踪 ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FF406-1B10-0065-A97D-2D1920C2A03D</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>润色后的任务理解</para>
        /// 
        /// <b>Example:</b>
        /// <para>string_value</para>
        /// </summary>
        [NameInMap("taskUnderstand")]
        [Validation(Required=false)]
        public string TaskUnderstand { get; set; }

    }

}
