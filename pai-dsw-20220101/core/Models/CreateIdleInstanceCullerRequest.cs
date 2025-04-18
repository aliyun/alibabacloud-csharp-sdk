// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dsw20220101.Models
{
    public class CreateIdleInstanceCullerRequest : TeaModel {
        /// <summary>
        /// <para>The CPU utilization threshold. Unit: percentage. Valid values: 1 to 100. If the CPU utilization of the instance is lower than this threshold, the instance is considered idle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("CpuPercentThreshold")]
        [Validation(Required=false)]
        public int? CpuPercentThreshold { get; set; }

        /// <summary>
        /// <para>The GPU utilization threshold. Unit: percentage. Valid values: 1 to 100. This parameter takes effect only if the instance is of the GPU instance type. If both CPU and GPU utilization is lower than the thresholds, the instance is considered idle.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("GpuPercentThreshold")]
        [Validation(Required=false)]
        public int? GpuPercentThreshold { get; set; }

        /// <summary>
        /// <para>The maximum time duration for which the instance is idle. Unit: minutes. If the time duration for which the instance is idle exceeds this value, the system automatically stops the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("MaxIdleTimeInMinutes")]
        [Validation(Required=false)]
        public int? MaxIdleTimeInMinutes { get; set; }

    }

}
