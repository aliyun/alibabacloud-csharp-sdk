// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScheduledTaskRequest : TeaModel {
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
        public CreateScheduledTaskRequestRunConfig RunConfig { get; set; }
        public class CreateScheduledTaskRequestRunConfig : TeaModel {
            /// <summary>
            /// <para>The extended parameters as a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;batchSize&quot;:&quot;1000&quot;}</para>
            /// </summary>
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public string ExtraParams { get; set; }

            /// <summary>
            /// <para>The maximum number of execution steps.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxSteps")]
            [Validation(Required=false)]
            public int? MaxSteps { get; set; }

            /// <summary>
            /// <para>The list of skill IDs, up to 1. Written to aim_task_config.run_config when the scheduled task is created and read when the callback is delivered.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;sk-abc&quot;]</para>
            /// </summary>
            [NameInMap("Skills")]
            [Validation(Required=false)]
            public List<string> Skills { get; set; }

            /// <summary>
            /// <para>The timeout in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("TimeoutSeconds")]
            [Validation(Required=false)]
            public int? TimeoutSeconds { get; set; }

        }

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
