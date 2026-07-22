// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class CreateScheduledTaskRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0 0 * * *</para>
        /// </summary>
        [NameInMap("CronExpression")]
        [Validation(Required=false)]
        public string CronExpression { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;ai-instance-001&quot;]</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public List<string> InstanceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MaxExecutions")]
        [Validation(Required=false)]
        public int? MaxExecutions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;maxSteps&quot;:10,&quot;timeoutSeconds&quot;:3600}</para>
        /// </summary>
        [NameInMap("RunConfig")]
        [Validation(Required=false)]
        public CreateScheduledTaskRequestRunConfig RunConfig { get; set; }
        public class CreateScheduledTaskRequestRunConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;batchSize&quot;:&quot;1000&quot;}</para>
            /// </summary>
            [NameInMap("ExtraParams")]
            [Validation(Required=false)]
            public string ExtraParams { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("MaxSteps")]
            [Validation(Required=false)]
            public int? MaxSteps { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>3600</para>
            /// </summary>
            [NameInMap("TimeoutSeconds")]
            [Validation(Required=false)]
            public int? TimeoutSeconds { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>自动回复钉钉消息</para>
        /// </summary>
        [NameInMap("TaskName")]
        [Validation(Required=false)]
        public string TaskName { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>打开钉钉，回复前5个未读消息</para>
        /// </summary>
        [NameInMap("UserPrompt")]
        [Validation(Required=false)]
        public string UserPrompt { get; set; }

    }

}
