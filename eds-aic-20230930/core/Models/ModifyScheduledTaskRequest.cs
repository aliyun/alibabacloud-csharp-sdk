// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>The cron expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 30 * * *</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>The list of instance IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;acp-5hh431emkt6u*****&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <para>The run configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;maxSteps&quot;:10,&quot;timeoutSeconds&quot;:3600}</para>
        /// </summary>
        [NameInMap("RunConfig")]
        [Validation(Required=false)]
        public ModifyScheduledTaskRequestRunConfig RunConfig { get; set; }
        public class ModifyScheduledTaskRequestRunConfig : TeaModel {
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
        /// <para>The scheduled task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sch-260705-agb*****</para>
        /// </summary>
        [NameInMap("ScheduledId")]
        [Validation(Required=false)]
        public string ScheduledId { get; set; }

        /// <summary>
        /// <para>The status switch: ACTIVE/DISABLED.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACTIVE</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The task name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NewTaskName.</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>The CAS version number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TaskVersion")]
        [Validation(Required=false)]
        public int? TaskVersion { get; set; }

        /// <summary>
        /// <para>The user prompt.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Execute daily data synchronization task.</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
