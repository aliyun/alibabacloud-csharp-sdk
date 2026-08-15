// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScheduledTaskShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 * * *</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ai-instance-001&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The maximum number of executions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxExecutions")]
        [Validation(Required=false)]
        public int? MaxExecutions { get; set; }

        /// <summary>
        /// <para>The run configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxSteps&quot;:10,&quot;timeoutSeconds&quot;:3600}</para>
        /// </summary>
        [NameInMap("RunConfig")]
        [Validation(Required=false)]
        public string RunConfigShrink { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Auto-reply to DingTalk messages</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The user prompt.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open DingTalk and reply to the first 5 unread messages</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
