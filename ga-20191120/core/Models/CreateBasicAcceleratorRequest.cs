// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBasicAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false:</b> disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated. This is the default value.</description></item>
        /// <item><description><b>true:</b> enables automatic payment. Payments are automatically completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the basic GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> enables auto-renewal for the basic GA instance.</description></item>
        /// <item><description><b>false:</b> disables auto-renewal for the basic GA instance. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: months.</para>
        /// <para>Valid values: <b>1</b> to <b>12</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>AutoPay</b> parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically apply coupons to your bills. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> automatically applies coupons to your bills.</description></item>
        /// <item><description><b>false:</b> does not automatically apply coupons to your bills. This is the default value.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when the <b>AutoPay</b> parameter is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The bandwidth billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthPackage:</b> billed based on bandwidth plans.</description></item>
        /// <item><description><b>CDT:</b> billed based on data transfer. The bills are managed by using Cloud Data Transfer (CDT).</description></item>
        /// <item><description><b>CDT95:</b> billed based on the 95th percentile bandwidth. The bills are managed by using Cloud Data Transfer (CDT). This bandwidth billing method is not available by default. Contact your Alibaba Cloud account manager for more information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CDT</para>
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b> (default)</description></item>
        /// <item><description><b>POSTPAY</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the <b>request ID</b> as the <b>client token</b>. The <b>request ID</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> performs a dry run. The system checks the required parameters, request syntax, and limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b>: performs a dry run and sends the request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The subscription duration of the GA instance.</para>
        /// <list type="bullet">
        /// <item><description>If you set <b>PricingCycle</b> to <b>Month</b>, the valid values for <b>Duration</b> are <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If you set <b>PricingCycle</b> to <b>Year</b>, the valid values for <b>Duration</b> are <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month</b></description></item>
        /// <item><description><b>Year</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The code of the coupon.</para>
        /// <remarks>
        /// <para> This parameter takes effect only for accounts registered on the international site (alibabacloud.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50003298014****</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The ID of the region where the basic GA instance is deployed. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the basic GA instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxshhcsn****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the basic GA instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBasicAcceleratorRequestTag> Tag { get; set; }
        public class CreateBasicAcceleratorRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. The tag key cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The tag value cannot be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>acs:</c> or <c>aliyun</c>.</para>
            /// <para>You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
