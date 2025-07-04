// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SchedulerX320240624.Models
{
    public class GetJobExecutionThreadDumpRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>xxl-job-executor-sample</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>xxljob-b6ec1xxxx</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://192.168.0.215:9966/">http://192.168.0.215:9966/</a></para>
        /// </summary>
        [NameInMap("ExecutorAddr")]
        [Validation(Required=false)]
        public string ExecutorAddr { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1310630367761285120</para>
        /// </summary>
        [NameInMap("JobExecutionId")]
        [Validation(Required=false)]
        public string JobExecutionId { get; set; }

    }

}
