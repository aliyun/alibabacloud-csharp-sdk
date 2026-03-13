// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutScalingConfigInput : TeaModel {
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

    }

}
