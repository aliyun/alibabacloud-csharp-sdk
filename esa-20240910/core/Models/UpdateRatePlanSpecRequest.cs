// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateRatePlanSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The billing type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PREPAY: Subscription.</description></item>
        /// <item><description>POSTPAY: Pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xcdn-91fknmb80f0g</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The type of specification change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>UPGRADE: Upgrade.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UPGRADE</para>
        /// </summary>
        [NameInMap("OrderType")]
        [Validation(Required=false)]
        public string OrderType { get; set; }

        /// <summary>
        /// <para>The code of the target plan.</para>
        /// <para>Alibaba Cloud China Website (<a href="http://www.aliyun.com">www.aliyun.com</a>)</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic Edition: basicplan</description></item>
        /// <item><description>Standard Edition: standardplan</description></item>
        /// <item><description>Premium Edition: advancedplan</description></item>
        /// </list>
        /// <para>Alibaba Cloud International Website (<a href="http://www.alibabacloud.com">www.alibabacloud.com</a>)</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan</description></item>
        /// <item><description>Pro: standardplan</description></item>
        /// <item><description>Premium: advancedpla.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>entranceplan</para>
        /// </summary>
        [NameInMap("TargetPlanCode")]
        [Validation(Required=false)]
        public string TargetPlanCode { get; set; }

        /// <summary>
        /// <para>The name of the target plan.</para>
        /// <para>Alibaba Cloud China Website (<a href="http://www.aliyun.com">www.aliyun.com</a>)</para>
        /// <list type="bullet">
        /// <item><description>Free Edition: entranceplan</description></item>
        /// <item><description>Basic Edition: basic</description></item>
        /// <item><description>Standard Edition: medium</description></item>
        /// <item><description>Premium Edition: high</description></item>
        /// </list>
        /// <para>Alibaba Cloud International Website (<a href="http://www.alibabacloud.com">www.alibabacloud.com</a>)</para>
        /// <list type="bullet">
        /// <item><description>Entrance: entranceplan_intl</description></item>
        /// <item><description>Pro: basicplan_intl</description></item>
        /// <item><description>Premium: vipplan_intl.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("TargetPlanName")]
        [Validation(Required=false)]
        public string TargetPlanName { get; set; }

    }

}
