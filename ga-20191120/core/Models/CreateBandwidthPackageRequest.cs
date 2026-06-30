// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Disables automatic payment. After an order is generated, go to the Order Hub to complete the payment.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Enables automatic payment. Payments are automatically completed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): No.</para>
        /// </description></item>
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
        /// <para>This parameter takes effect only if <b>AutoRenew</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to use a coupon to automatically pay for the bill. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): No.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if <b>AutoPay</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The bandwidth of the bandwidth plan. Unit: Mbps.
        /// Valid values: <b>2</b> to <b>2000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The type of bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: Basic bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>Enhanced</b>: Enhanced bandwidth.</para>
        /// </description></item>
        /// <item><description><para><b>Advanced</b>: Advanced bandwidth.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if you set <b>Type</b> to <b>Basic</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The billing method for a pay-as-you-go bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PayByTraffic</b> (default): pay-by-traffic.</para>
        /// </description></item>
        /// <item><description><para><b>PayBY95</b>: pay-by-95th-percentile. This billing method is not available by default. Contact your account manager to use this billing method.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter takes effect only if <b>ChargeType</b> is set to <b>POSTPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>Connected area A of the cross-region acceleration bandwidth plan. Set the value to <b>China-mainland</b>.</para>
        /// <para>This parameter is available only on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>China-mainland</para>
        /// </summary>
        [NameInMap("CbnGeographicRegionIdA")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdA { get; set; }

        /// <summary>
        /// <para>Connected area B of the cross-region acceleration bandwidth plan. Set the value to <b>Global</b>.</para>
        /// <para>This parameter is available only on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("CbnGeographicRegionIdB")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdB { get; set; }

        /// <summary>
        /// <para>The billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>PREPAY</b> (default): subscription.</para>
        /// </description></item>
        /// <item><description><para><b>POSTPAY</b>: pay-as-you-go. The pay-as-you-go billing method is not available by default. Contact your account manager to use this billing method.</para>
        /// </description></item>
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
        /// <para>Generate a client token from your client to make sure that the token is unique among different requests. The token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the <b>RequestId</b> of the request as the <b>ClientToken</b>. The <b>RequestId</b> may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>PricingCycle</b> to <b>Month</b>, valid values for <b>Duration</b> are <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>PricingCycle</b> to <b>Year</b>, valid values for <b>Duration</b> are <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if you set <b>ChargeType</b> to <b>PREPAY</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public string Duration { get; set; }

        /// <summary>
        /// <para>The billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b>: monthly billing.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: yearly billing.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required if you set <b>ChargeType</b> to <b>PREPAY</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// <remarks>
        /// <para>This parameter is available only on the Alibaba Cloud International Website (www\.alibabacloud.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50003298014****</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The percentage of the guaranteed minimum bandwidth if you use the pay-by-95th-percentile metering method. Valid values: <b>30</b> to <b>100</b>.</para>
        /// <remarks>
        /// <para>This parameter takes effect only if <b>BillingType</b> is set to <b>PayBY95</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzrnd67gq****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags of the bandwidth plan.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the bandwidth plan. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the bandwidth plan. The tag value can be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The type of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Basic</b>: a basic bandwidth plan.</para>
        /// </description></item>
        /// <item><description><para><b>CrossDomain</b>: a cross-region acceleration bandwidth plan.</para>
        /// </description></item>
        /// </list>
        /// <para>Only <b>Basic</b> is supported on the Alibaba Cloud China Website (www\.aliyun.com).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
