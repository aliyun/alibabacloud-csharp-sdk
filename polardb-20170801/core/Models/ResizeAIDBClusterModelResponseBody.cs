// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class ResizeAIDBClusterModelResponseBody : TeaModel {
        /// <summary>
        /// <para>The current measured capacity of the instance. This parameter is returned only when DryRun is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("CurrentCapacity")]
        [Validation(Required=false)]
        public long? CurrentCapacity { get; set; }

        /// <summary>
        /// <para>The ID of the PolarDB AI 3.0 logical instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pm-2ze4x2mwo81knj08a</para>
        /// </summary>
        [NameInMap("DBClusterId")]
        [Validation(Required=false)]
        public string DBClusterId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request performs a capacity dry run only.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The capacity that can be directly borrowed from the large pool without reshaping. This parameter is returned only when DryRun is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("PoolHitCapacity")]
        [Validation(Required=false)]
        public long? PoolHitCapacity { get; set; }

        /// <summary>
        /// <para>The direct hit ratio of the large pool. Valid values: 0 to 1. This parameter is returned only when DryRun is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.75</para>
        /// </summary>
        [NameInMap("PoolHitRatio")]
        [Validation(Required=false)]
        public double? PoolHitRatio { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>3AA6E0E4-1234-5678-90AB-1234567890AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The positive difference between the target capacity and the current capacity. This parameter is returned only when DryRun is set to true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4000</para>
        /// </summary>
        [NameInMap("RequiredDelta")]
        [Validation(Required=false)]
        public long? RequiredDelta { get; set; }

        /// <summary>
        /// <para>The target total capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12000</para>
        /// </summary>
        [NameInMap("TargetCapacity")]
        [Validation(Required=false)]
        public long? TargetCapacity { get; set; }

    }

}
