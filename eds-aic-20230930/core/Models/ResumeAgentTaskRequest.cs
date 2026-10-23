// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResumeAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The additional prompt. This parameter takes effect only when the task is passively paused, such as pausing to wait for user confirmation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The verification code is ***</para>
        /// </summary>
        [NameInMap("AdditionalPrompt")]
        [Validation(Required=false)]
        public string AdditionalPrompt { get; set; }

        /// <summary>
        /// <para>The list of clarification answers submitted when resuming the task.</para>
        /// </summary>
        [NameInMap("ClarificationAnswers")]
        [Validation(Required=false)]
        public List<ResumeAgentTaskRequestClarificationAnswers> ClarificationAnswers { get; set; }
        public class ResumeAgentTaskRequestClarificationAnswers : TeaModel {
            /// <summary>
            /// <para>The custom input content in the clarification answer.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Simply ****</para>
            /// </summary>
            [NameInMap("CustomValue")]
            [Validation(Required=false)]
            public string CustomValue { get; set; }

            /// <summary>
            /// <para>The ID of the clarification item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cl*****-1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The list of selected option IDs in the clarification answer.</para>
            /// </summary>
            [NameInMap("SelectedIds")]
            [Validation(Required=false)]
            public List<string> SelectedIds { get; set; }

        }

        /// <summary>
        /// <para>The list of task IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

        /// <summary>
        /// <para>The ID of the tool invoke to resume.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ca*****01</para>
        /// </summary>
        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

    }

}
