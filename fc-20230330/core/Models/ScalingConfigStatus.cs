// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ScalingConfigStatus : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>image not found</para>
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentInstances")]
        [Validation(Required=false)]
        public long? CurrentInstances { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("enableMixMode")]
        [Validation(Required=false)]
        public bool? EnableMixMode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("enableOnDemandScaling")]
        [Validation(Required=false)]
        public bool? EnableOnDemandScaling { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:124:functions/myFunction/prod</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        [NameInMap("horizontalScalingPolicies")]
        [Validation(Required=false)]
        public List<ScalingPolicy> HorizontalScalingPolicies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Balanced</para>
        /// </summary>
        [NameInMap("requestDispatchPolicy")]
        [Validation(Required=false)]
        public string RequestDispatchPolicy { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>fc-pool-a2b664c1f87171j4******</para>
        /// </summary>
        [NameInMap("residentPoolId")]
        [Validation(Required=false)]
        public string ResidentPoolId { get; set; }

        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("targetInstances")]
        [Validation(Required=false)]
        public long? TargetInstances { get; set; }

    }

}
