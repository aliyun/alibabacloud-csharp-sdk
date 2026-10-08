// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class RenewRCInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Automatic payment is enabled. Make sure that your account balance is sufficient.</description></item>
        /// <item><description><b>false</b>: Only an order is generated. No payment is made.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Default value: true. If your payment method has insufficient balance, set AutoPay to false. In this case, an unpaid order is generated. You can log on to the ApsaraDB RDS console to pay for the order.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Auto-renewal is enabled.</description></item>
        /// <item><description><b>false</b> (default): Auto-renewal is disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public string AutoRenew { get; set; }

        /// <summary>
        /// <para>Specifies whether to use coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Coupons are used.</description></item>
        /// <item><description><b>false</b>: Coupons are not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public bool? AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The additional information about the order.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;promotion_input_param\&quot;:\&quot;{\\\&quot;promotionFilter\\\&quot;:{},\\\&quot;promotionOptionCode\\\&quot;:\\\&quot;youhui_quan\\\&quot;}\&quot;}</para>
        /// </summary>
        [NameInMap("BusinessInfo")]
        [Validation(Required=false)]
        public string BusinessInfo { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotency of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOC****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The commodity code.</para>
        /// <para>&lt;props=&quot;china&quot;&gt;Default value: <b>rds_customprepaid_public_cn</b>.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;Default value: <b>rds_customprepaid_public_intl</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds_customprepaid_public_**</para>
        /// </summary>
        [NameInMap("CommodityCode")]
        [Validation(Required=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// <para>The ID of the RDS Custom instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rc-dh2jf9n6j4s14926****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the target instance. Only <b>Prepaid</b> (upfront, subscription) is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Prepaid</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>Specifies whether to use annual subscription. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Annual subscription is used.</description></item>
        /// <item><description><b>false</b> (default): Annual subscription is not used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PeriodAlign")]
        [Validation(Required=false)]
        public bool? PeriodAlign { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>72329885****</para>
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
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource.</para>
        /// 
        /// <b>Example:</b>
        /// <para>buy</para>
        /// </summary>
        [NameInMap("Resource")]
        [Validation(Required=false)]
        public string Resource { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        /// <summary>
        /// <para>The unit of the renewal duration specified by the <b>UsedTime</b> parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: year</description></item>
        /// <item><description><b>2</b> (default): month</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TimeType")]
        [Validation(Required=false)]
        public string TimeType { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>TimeType</b> is set to <b>1</b> (year), the valid values of UsedTime are <b>1 to 5</b>.</description></item>
        /// <item><description>If <b>TimeType</b> is set to <b>2</b> (month), the valid values of UsedTime are <b>1 to 11</b>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("UsedTime")]
        [Validation(Required=false)]
        public string UsedTime { get; set; }

    }

}
