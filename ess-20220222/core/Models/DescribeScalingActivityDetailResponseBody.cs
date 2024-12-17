// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ess20220222.Models
{
    public class DescribeScalingActivityDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the scaling activity. The result of a scaling activity is either successful or failed. If the scaling activity is rejected, no scaling activity details are returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new ECS instances \&quot;i-bp16t2cgmiiymeqv****\&quot; are created.</para>
        /// </summary>
        [NameInMap("Detail")]
        [Validation(Required=false)]
        public string Detail { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B13527BF-1FBD-4334-A512-20F5E9D3FB4D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the scaling activity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asa-bp1c9djwrgxjyk31****</para>
        /// </summary>
        [NameInMap("ScalingActivityId")]
        [Validation(Required=false)]
        public string ScalingActivityId { get; set; }

    }

}
