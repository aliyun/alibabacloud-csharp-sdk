// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ResumeAgentTaskRequest : TeaModel {
        /// <summary>
        /// <para>An additional prompt to guide the task. This parameter applies only when a task is in the <c>PAUSED</c> state, for example, while waiting for user input.</para>
        /// 
        /// <b>Example:</b>
        /// <para>验证码为***。</para>
        /// </summary>
        [NameInMap("AdditionalPrompt")]
        [Validation(Required=false)]
        public string AdditionalPrompt { get; set; }

        /// <summary>
        /// <para>A list of task IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<string> TaskIds { get; set; }

    }

}
