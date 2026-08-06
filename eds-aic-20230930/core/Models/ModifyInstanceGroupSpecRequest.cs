// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyInstanceGroupSpecRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b> (default): Only generates an order without deducting fees.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If your payment method balance is insufficient, set this parameter to false. An unpaid order is generated, and you can log on to the Cloud Phone console to complete the payment.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The list of instance group IDs.</para>
        /// </summary>
        [NameInMap("InstanceGroupIds")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIds { get; set; }

        /// <summary>
        /// <para>The instance group specification. You can call <a href="~~DescribeSpec~~">DescribeSpec</a> to query the specifications available for purchase for cloud phones.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>acp.basic.small</para>
        /// </summary>
        [NameInMap("InstanceGroupSpec")]
        [Validation(Required=false)]
        public string InstanceGroupSpec { get; set; }

        /// <summary>
        /// <para>The promotion ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003308011****</para>
        /// </summary>
        [NameInMap("PromotionId")]
        [Validation(Required=false)]
        public string PromotionId { get; set; }

    }

}
