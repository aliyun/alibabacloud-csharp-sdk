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
        /// <item><description><b>false</b> (default): disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.</description></item>
        /// <item><description><b>true</b>: enables automatic payment. Payments are automatically completed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable auto-renewal for the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b> (default): does not enable auto-renewal.</description></item>
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
        /// <para> This parameter is required only if <b>AutoRenew</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically pay bills by using coupons. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter is required only if <b>AutoPay</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The bandwidth of the bandwidth plan. Unit: Mbit/s.</para>
        /// <para>Valid values: <b>2</b> to <b>2000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The type of the bandwidth. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Basic</b>: standard bandwidth</description></item>
        /// <item><description><b>Enhanced</b>: enhanced bandwidth</description></item>
        /// <item><description><b>Advanced</b>: premium bandwidth</description></item>
        /// </list>
        /// <para>If <b>Type</b> is set to <b>Basic</b>, this parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Basic</para>
        /// </summary>
        [NameInMap("BandwidthType")]
        [Validation(Required=false)]
        public string BandwidthType { get; set; }

        /// <summary>
        /// <para>The metering method that is used when you use the pay-as-you-go billing method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PayByTraffic</b> (default)</description></item>
        /// <item><description><b>PayBY95</b> By default, the pay-by-95th-percentile metering method is unavailable. If you want to use the metering method, contact your account manager.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only if you set <b>ChargeType</b> to <b>POSTPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>PayByTraffic</para>
        /// </summary>
        [NameInMap("BillingType")]
        [Validation(Required=false)]
        public string BillingType { get; set; }

        /// <summary>
        /// <para>Area A to be connected. Set the value to <b>China-mainland</b>.</para>
        /// <para>You can set this parameter only if you call this operation on the international site (alibabacloud.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>China-mainland</para>
        /// </summary>
        [NameInMap("CbnGeographicRegionIdA")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdA { get; set; }

        /// <summary>
        /// <para>Area B to be connected. Set the value to <b>Global</b>.</para>
        /// <para>You can set this parameter only if you call this operation on the international site (alibabacloud.com).</para>
        /// 
        /// <b>Example:</b>
        /// <para>Global</para>
        /// </summary>
        [NameInMap("CbnGeographicRegionIdB")]
        [Validation(Required=false)]
        public string CbnGeographicRegionIdB { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b> (default): subscription.</description></item>
        /// <item><description><b>POSTPAY</b>: pay-as-you-go. By default, the pay-as-you-go billing method is unavailable. If you want to use the billing method, contact your account manager.</description></item>
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
        /// <para>The subscription duration.</para>
        /// <list type="bullet">
        /// <item><description>If the <b>PricingCycle</b> parameter is set to <b>Month</b>, the valid values for the <b>Duration</b> parameter are <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If the <b>PricingCycle</b> parameter is set to <b>Year</b>, the valid values for the <b>Duration</b> parameter are <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <para>If <b>ChargeType</b> is set to <b>PREPAY</b>, this parameter is required.</para>
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
        /// <item><description><b>Month</b>: billed on a monthly basis.</description></item>
        /// <item><description><b>Year</b>: billed on an annual basis.</description></item>
        /// </list>
        /// <para>If <b>ChargeType</b> is set to <b>PREPAY</b>, this parameter is required.</para>
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
        /// <para> This parameter is only available on the international site (alibabacloud.com).</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50003298014****</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <summary>
        /// <para>The percentage of the minimum bandwidth guaranteed if the pay-by-95th-percentile-bandwidth metering method is used. Valid values: <b>30</b> to <b>100</b>.</para>
        /// <remarks>
        /// <para> This parameter is required only if <b>BillingType</b> is set to <b>PayBY95</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("Ratio")]
        [Validation(Required=false)]
        public int? Ratio { get; set; }

        /// <summary>
        /// <para>The ID of the region where the GA instance is deployed. <b>cn-hangzhou</b> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzrnd67gq****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags to add to the bandwidth plan.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag keys cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>Each tag key corresponds to a tag value. Valid values of <b>N</b>: <b>1</b> to <b>20</b>.</para>
            /// <para>The value cannot exceed 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description><b>Basic</b>: a basic bandwidth plan</description></item>
        /// <item><description><b>CrossDomain</b>: a cross-region acceleration bandwidth plan</description></item>
        /// </list>
        /// <para>If you call this operation on the Alibaba Cloud China site, only <b>Basic</b> is supported.</para>
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
