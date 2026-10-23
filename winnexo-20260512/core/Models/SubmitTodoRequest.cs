// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WinNexo20260512.Models
{
    public class SubmitTodoRequest : TeaModel {
        /// <summary>
        /// <para>The array of answers. The original text of the question must match the to-do question.</para>
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
            /// <para>The array of answer values.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example</para>
            /// </summary>
            [NameInMap("answer")]
            [Validation(Required=false)]
            public List<string> Answer { get; set; }

            /// <summary>
            /// <para>The original text that corresponds to questions[].question.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Whether to approve</para>
            /// </summary>
            [NameInMap("question")]
            [Validation(Required=false)]
            public string Question { get; set; }

        }

        /// <summary>
        /// <para>The tenant ID. This is a common parameter. If this parameter is not specified, the default tenant of the caller is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The ID of the to-do item.</para>
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
