// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateTodoRequest : TeaModel {
        /// <summary>
        /// <para>处理人平台用户ID列表（1~100，去重后生效）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("assigneeUserIds")]
        [Validation(Required=false)]
        public List<string> AssigneeUserIds { get; set; }

        /// <summary>
        /// <para>协作空间 ID（可选）</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>优先级</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>问题清单（1~N）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("questions")]
        [Validation(Required=false)]
        public List<CreateTodoRequestQuestions> Questions { get; set; }
        public class CreateTodoRequestQuestions : TeaModel {
            /// <summary>
            /// <para>是否允许自定义输入</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowCustom")]
            [Validation(Required=false)]
            public bool? AllowCustom { get; set; }

            /// <summary>
            /// <para>自定义输入项文案</para>
            /// 
            /// <b>Example:</b>
            /// <para>其他</para>
            /// </summary>
            [NameInMap("customLabel")]
            [Validation(Required=false)]
            public string CustomLabel { get; set; }

            /// <summary>
            /// <para>自定义输入长度上限</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("customMaxLength")]
            [Validation(Required=false)]
            public long? CustomMaxLength { get; set; }

            /// <summary>
            /// <para>自定义输入占位符</para>
            /// 
            /// <b>Example:</b>
            /// <para>请说明</para>
            /// </summary>
            [NameInMap("customPlaceholder")]
            [Validation(Required=false)]
            public string CustomPlaceholder { get; set; }

            /// <summary>
            /// <para>TEXT 题长度上限</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("maxLength")]
            [Validation(Required=false)]
            public long? MaxLength { get; set; }

            /// <summary>
            /// <para>作答形态：SINGLE_CHOICE/MULTI_CHOICE/TEXT</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_CHOICE</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>问题的选项列表；选择题必填，每项含选项文案（label）、补充说明（description）与是否推荐（recommended）</para>
            /// </summary>
            [NameInMap("options")]
            [Validation(Required=false)]
            public List<CreateTodoRequestQuestionsOptions> Options { get; set; }
            public class CreateTodoRequestQuestionsOptions : TeaModel {
                /// <summary>
                /// <para>选项补充说明</para>
                /// 
                /// <b>Example:</b>
                /// <para>选项补充说明</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>选项文案（引用键）</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>通过</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>是否推荐</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("recommended")]
                [Validation(Required=false)]
                public bool? Recommended { get; set; }

            }

            /// <summary>
            /// <para>TEXT 题占位符</para>
            /// 
            /// <b>Example:</b>
            /// <para>请输入</para>
            /// </summary>
            [NameInMap("placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            /// <summary>
            /// <para>问题正文（引用键，清单内唯一）</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>是否通过审批</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <para>是否必答</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <para>来源上下文（原样透传落库，不校验）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceContext { get; set; }

        /// <summary>
        /// <para>待办来源（仅 OPEN_API）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN_API</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>租户ID，公共参数；缺省时使用调用方默认租户</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>待办标题（≤200 字）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>治理审批</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
