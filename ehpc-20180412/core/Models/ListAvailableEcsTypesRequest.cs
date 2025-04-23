// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListAvailableEcsTypesRequest : TeaModel {
        /// <summary>
        /// <para>The billing method of the ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PostPaid: pay-as-you-go</description></item>
        /// <item><description>PrePaid: subscription</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PostPaid</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>Specifies whether the ECS instances are sold out. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: available</description></item>
        /// <item><description>true: sold out</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowSoldOut")]
        [Validation(Required=false)]
        public bool? ShowSoldOut { get; set; }

        /// <summary>
        /// <para>The preemption policy of the ECS instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>NoSpot: The ECS instances are pay-as-you-go instances.</description></item>
        /// <item><description>SpotWithPriceLimit: The ECS instances are preemptible instances that have a user-defined maximum hourly price.</description></item>
        /// <item><description>SpotAsPriceGo: The compute nodes are preemptible instances for which the market price at the time of purchase is used as the bid price.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NoSpot</para>
        /// </summary>
        [NameInMap("SpotStrategy")]
        [Validation(Required=false)]
        public string SpotStrategy { get; set; }

        /// <summary>
        /// <para>The zone ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
