// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class ScalingConfigStatus : TeaModel {
        /// <summary>
        /// <para>The error message that is returned when an instance fails to be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image not found</para>
        /// </summary>
        [NameInMap("currentError")]
        [Validation(Required=false)]
        public string CurrentError { get; set; }

        /// <summary>
        /// <para>The current number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("currentInstances")]
        [Validation(Required=false)]
        public long? CurrentInstances { get; set; }

        /// <summary>
        /// <para>Specifies whether mix mode is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("enableMixMode")]
        [Validation(Required=false)]
        public bool? EnableMixMode { get; set; }

        /// <summary>
        /// <para>Specifies whether on-demand scaling is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("enableOnDemandScaling")]
        [Validation(Required=false)]
        public bool? EnableOnDemandScaling { get; set; }

        /// <summary>
        /// <para>The resource identifier of the function.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acs:fc:cn-shanghai:124:functions/myFunction/prod</para>
        /// </summary>
        [NameInMap("functionArn")]
        [Validation(Required=false)]
        public string FunctionArn { get; set; }

        /// <summary>
        /// <para>The horizontal scaling policies.</para>
        /// </summary>
        [NameInMap("horizontalScalingPolicies")]
        [Validation(Required=false)]
        public List<ScalingPolicy> HorizontalScalingPolicies { get; set; }

        /// <summary>
        /// <para>The minimum number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("minInstances")]
        [Validation(Required=false)]
        public long? MinInstances { get; set; }

        /// <summary>
        /// <para>The request dispatch policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Balanced</para>
        /// </summary>
        [NameInMap("requestDispatchPolicy")]
        [Validation(Required=false)]
        public string RequestDispatchPolicy { get; set; }

        /// <summary>
        /// <para>The ID of the resident resource pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fc-pool-a2b664c1f87171j4******</para>
        /// </summary>
        [NameInMap("residentPoolId")]
        [Validation(Required=false)]
        public string ResidentPoolId { get; set; }

        /// <summary>
        /// <para>The scheduled scaling policies.</para>
        /// </summary>
        [NameInMap("scheduledPolicies")]
        [Validation(Required=false)]
        public List<ScheduledPolicy> ScheduledPolicies { get; set; }

        /// <summary>
        /// <para>The target number of instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("targetInstances")]
        [Validation(Required=false)]
        public long? TargetInstances { get; set; }

    }

}
