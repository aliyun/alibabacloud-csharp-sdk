// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class CreateTodoRequest : TeaModel {
        /// <summary>
        /// <para>The list of platform user IDs of the assignees. You can specify 1 to 100 IDs. Duplicate IDs are automatically removed.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>43</para>
        /// </summary>
        [NameInMap("assigneeUserIds")]
        [Validation(Required=false)]
        public List<string> AssigneeUserIds { get; set; }

        /// <summary>
        /// <para>The ID of the collaboration workspace. This parameter is optional.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cg_123</para>
        /// </summary>
        [NameInMap("collaborationGroupId")]
        [Validation(Required=false)]
        public string CollaborationGroupId { get; set; }

        /// <summary>
        /// <para>The priority.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MEDIUM</para>
        /// </summary>
        [NameInMap("priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        /// <summary>
        /// <para>The list of questions.</para>
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
            /// <para>Specifies whether custom input is allowed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("allowCustom")]
            [Validation(Required=false)]
            public bool? AllowCustom { get; set; }

            /// <summary>
            /// <para>The text for the custom input item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Other</para>
            /// </summary>
            [NameInMap("customLabel")]
            [Validation(Required=false)]
            public string CustomLabel { get; set; }

            /// <summary>
            /// <para>The maximum length of the custom input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("customMaxLength")]
            [Validation(Required=false)]
            public long? CustomMaxLength { get; set; }

            /// <summary>
            /// <para>The placeholder for the custom input.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please specify</para>
            /// </summary>
            [NameInMap("customPlaceholder")]
            [Validation(Required=false)]
            public string CustomPlaceholder { get; set; }

            /// <summary>
            /// <para>The maximum length for text questions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("maxLength")]
            [Validation(Required=false)]
            public long? MaxLength { get; set; }

            /// <summary>
            /// <para>The response mode. Valid values: SINGLE_CHOICE, MULTI_CHOICE, and TEXT.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SINGLE_CHOICE</para>
            /// </summary>
            [NameInMap("mode")]
            [Validation(Required=false)]
            public string Mode { get; set; }

            /// <summary>
            /// <para>The list of options for the question. This parameter is required for choice questions. Each option includes the option text (label), supplementary description (description), and whether it is recommended (recommended).</para>
            /// </summary>
            [NameInMap("options")]
            [Validation(Required=false)]
            public List<CreateTodoRequestQuestionsOptions> Options { get; set; }
            public class CreateTodoRequestQuestionsOptions : TeaModel {
                /// <summary>
                /// <para>The supplementary description of the option.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Supplementary description of the option</para>
                /// </summary>
                [NameInMap("description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The option text. This is a reference key.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Approve</para>
                /// </summary>
                [NameInMap("label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <para>Specifies whether the option is recommended.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("recommended")]
                [Validation(Required=false)]
                public bool? Recommended { get; set; }

            }

            /// <summary>
            /// <para>The placeholder for text questions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Please enter</para>
            /// </summary>
            [NameInMap("placeholder")]
            [Validation(Required=false)]
            public string Placeholder { get; set; }

            /// <summary>
            /// <para>The question text. This is a reference key and must be unique within the list.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether to approve the request</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

            /// <summary>
            /// <para>Specifies whether the question is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("required")]
            [Validation(Required=false)]
            public bool? Required { get; set; }

        }

        /// <summary>
        /// <para>The source context. The value is passed through and stored in the database as-is without validation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("sourceContext")]
        [Validation(Required=false)]
        public Dictionary<string, object> SourceContext { get; set; }

        /// <summary>
        /// <para>The source of the to-do item. Only OPEN_API is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OPEN_API</para>
        /// </summary>
        [NameInMap("sourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

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
        /// <para>The title of the to-do item. The maximum length is 200 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Governance approval</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
