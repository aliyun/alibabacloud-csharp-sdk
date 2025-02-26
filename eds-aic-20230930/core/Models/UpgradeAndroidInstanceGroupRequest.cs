// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UpgradeAndroidInstanceGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the auto-payment feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: enables the auto-payment feature. Make sure that your Alibaba Cloud account has sufficient balance.</description></item>
        /// <item><description>false: disables the auto-payment feature. You need to manually complete the payment process.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The number of instances that you want to increase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("IncreaseNumberOfInstance")]
        [Validation(Required=false)]
        public int? IncreaseNumberOfInstance { get; set; }

        /// <summary>
        /// <para>The ID of the instance group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ag-asguicdjh****</para>
        /// </summary>
        [NameInMap("InstanceGroupId")]
        [Validation(Required=false)]
        public string InstanceGroupId { get; set; }

    }

}
