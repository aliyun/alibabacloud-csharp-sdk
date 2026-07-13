// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResumeAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>The additional prompt to append. This parameter takes effect only when the task is passively paused, such as when the task is paused and waiting for user confirmation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码为***。</para>
        /// </summary>
        [NameInMap("AdditionalPrompt")]
        [Validation(Required=false)]
        public string AdditionalPrompt { get; set; }

        [NameInMap("ClarificationAnswers")]
        [Validation(Required=false)]
        public List<ResumeAgentTaskRequestClarificationAnswers> ClarificationAnswers { get; set; }
        public class ResumeAgentTaskRequestClarificationAnswers : TeaModel {
            [NameInMap("CustomValue")]
            [Validation(Required=false)]
            public string CustomValue { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

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

        [NameInMap("ToolCallId")]
        [Validation(Required=false)]
        public string ToolCallId { get; set; }

    }

}
