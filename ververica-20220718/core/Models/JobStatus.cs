// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class JobStatus : TeaModel {
        /// <summary>
        /// <para>The status of the current job. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>STARTING</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>CANCELLING</description></item>
        /// <item><description>FAILED</description></item>
        /// <item><description>CANCELLED</description></item>
        /// <item><description>FINISHED</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("currentJobStatus")]
        [Validation(Required=false)]
        public string CurrentJobStatus { get; set; }

        /// <summary>
        /// <para>The information about the job failure. This parameter is valid when the value of the currentJobStatus parameter is FAILED.</para>
        /// </summary>
        [NameInMap("failure")]
        [Validation(Required=false)]
        public JobFailure Failure { get; set; }

        [NameInMap("healthScore")]
        [Validation(Required=false)]
        public int? HealthScore { get; set; }

        [NameInMap("riskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The details of the job. This parameter is valid when the value of the currentJobStatus parameter is RUNNING.</para>
        /// </summary>
        [NameInMap("running")]
        [Validation(Required=false)]
        public JobStatusRunning Running { get; set; }

    }

}
