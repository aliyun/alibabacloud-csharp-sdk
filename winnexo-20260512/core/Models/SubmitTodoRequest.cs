// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SubmitTodoRequest : TeaModel {
        /// <summary>
        /// <para>作答数组（question 原文须与待办问题对齐）</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example</para>
        /// </summary>
        [NameInMap("answers")]
        [Validation(Required=false)]
        public List<SubmitTodoRequestAnswers> Answers { get; set; }
        public class SubmitTodoRequestAnswers : TeaModel {
            /// <summary>
            /// <para>作答值数组</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("answer")]
            [Validation(Required=false)]
            public List<string> Answer { get; set; }

            /// <summary>
            /// <para>对应 questions[].question 原文</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>是否通过审批</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

        }

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
        /// <para>待办ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>todo_abc123</para>
        /// </summary>
        [NameInMap("todoId")]
        [Validation(Required=false)]
        public string TodoId { get; set; }

    }

}
