// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IaCService20210806.Models
{
    public class CreateJobRequest : TeaModel {
        /// <summary>
        /// <para>The idempotence token. Format: [0-9a-zA-Z-]{1,64}. We recommend that you use a UUID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2daf4227f747cbf11a5501f18cc5e004</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The job description. Length: 1 to 64 characters.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The operation command. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>plan: performs a preview. This is the default value.</description></item>
        /// <item><description>refresh: refreshes the resource status.</description></item>
        /// <item><description>destroy: destroys resources.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>refresh</para>
        /// </summary>
        [NameInMap("subCommand")]
        [Validation(Required=false)]
        public string SubCommand { get; set; }

        /// <summary>
        /// <para>The task type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Task: regular task. This is the default value.</description></item>
        /// <item><description>SceneTestingTask: scenario-based testing task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Task</para>
        /// </summary>
        [NameInMap("taskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
