// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyRCInstanceChargeTypeRequest : TeaModel {
        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the auto-renewal feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter is valid only when you change the billing method from pay-as-you-go to subscription.</para>
        /// </description></item>
        /// <item><description><para>All strings except <b>true</b> are considered <b>false</b>.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default)</description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The additional business information about the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The custom client token that is used to ensure the idempotence of the request.</para>
        /// <remarks>
        /// <para> The value can contain ASCII characters and can be up to 64 characters in length.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("IncludeDataDisks")]
        [Validation(Required=false)]
        public bool? IncludeDataDisks { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrePaid</description></item>
        /// <item><description>PostPaid</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The ID of the instance or disk.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-dh2jf9n6j4s14926****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The reserved parameter. This parameter is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("InstanceIds")]
        [Validation(Required=false)]
        public string InstanceIds { get; set; }

        /// <summary>
        /// <para>The new billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Prepaid</b>: subscription.</description></item>
        /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Postpaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The renewal cycle of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Year</b></description></item>
        /// <item><description><b>Month</b></description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter must be specified if you set the PayType parameter to <b>Prepaid</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72802442****</para>
        /// </summary>
        [NameInMap("PromotionCode")]
        [Validation(Required=false)]
        public string PromotionCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The subscription duration of the instance.</para>
        /// <list type="bullet">
        /// <item><description>**If you set the <b><b>Period</b></b> parameter to **Year, the value of the UsedTime parameter ranges from 1 to 5.</description></item>
        /// <item><description>If the <b>Period</b> parameter is set to <b>Month</b>, the value of the <b>UsedTime</b> parameter ranges from 1 to 11.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you set the PayType parameter to <b>Prepaid</b>, you must also specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public int? UsedTime { get; set; }

    }

}
