// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>false:</b> disables automatic payment. If you select this option, you must go to the Order Center to complete the payment after an order is generated.</description></item>
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
        /// <para>Specifies whether to enable auto-renewal for the GA instance. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> enables auto-renewal.</description></item>
        /// <item><description><b>false:</b> disables auto-renewal.</description></item>
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
        /// <para> This parameter takes effect only when <b>AutoRenew</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>Specifies whether to automatically use coupons when making payments. Default value: false. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> automatically pays bill by using coupons.</description></item>
        /// <item><description><b>false:</b> does not automatically pay bills by using coupons.</description></item>
        /// </list>
        /// <remarks>
        /// <para> This parameter takes effect only when <b>AutoPay</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth billing method.</para>
        /// <list type="bullet">
        /// <item><description><b>BandwidthPackage:</b> billed based on bandwidth plans.</description></item>
        /// <item><description><b>CDT:</b> billed based on data transfer.</description></item>
        /// <item><description><b>CDT95:</b> billed based on the 95th percentile bandwidth. The billing is managed by Cloud Data Transfer (CDT). This bandwidth billing method is not available by default. Contact your Alibaba Cloud account manager for more information.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthPackage</para>
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The client token can contain only ASCII characters.</para>
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
        /// <para>Specifies whether to perform only a dry run, without performing the actual request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true:</b> performs only a dry run. The system checks the request for potential issues, including missing parameter values, incorrect request syntax, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</description></item>
        /// <item><description><b>false</b> (default): performs a dry run and performs the actual request. If the request passes the dry run, a 2xx HTTP status code is returned and the operation is performed.</description></item>
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
        /// <item><description>If the <b>PricingCycle</b> parameter is set to <b>Month</b>, the valid values for the <b>Duration</b> parameter are <b>1</b> to <b>9</b>.</description></item>
        /// <item><description>If the <b>PricingCycle</b> parameter is set to <b>Year</b>, the valid values for the <b>Duration</b> parameter are <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the <b>InstanceChargeType</b> parameter is set to <b>PREPAY</b>, you must configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The billing method of the GA instance.</para>
        /// <list type="bullet">
        /// <item><description>PREPAY (default): subscription</description></item>
        /// <item><description>POSTPAY: pay-as-you-go</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("InstanceChargeType")]
        [Validation(Required=false)]
        public string InstanceChargeType { get; set; }

        /// <summary>
        /// <para>The configurations of the acceleration area.</para>
        /// </summary>
        [NameInMap("IpSetConfig")]
        [Validation(Required=false)]
        public CreateAcceleratorRequestIpSetConfig IpSetConfig { get; set; }
        public class CreateAcceleratorRequestIpSetConfig : TeaModel {
            /// <summary>
            /// <para>The access mode of the acceleration area. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>UserDefine:</b> custom nearby access mode. You can select acceleration areas and regions based on your business requirements. GA allocates a separate EIP to each acceleration region.</description></item>
            /// <item><description><b>Anycast:</b> automatic nearby access mode. You do not need to specify an acceleration area. GA allocates an Anycast EIP to multiple regions across the globe. Users can connect to the nearest access point of the Alibaba Cloud global transmission network by sending requests to the Anycast EIP.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>UserDefine</para>
            /// </summary>
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public string AccessMode { get; set; }

        }

        /// <summary>
        /// <para>The name of the GA instance.</para>
        /// <para>The name must be 2 to 128 characters in length and can contain digits, underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The billing cycle of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Month:</b> billed on a monthly basis.</description></item>
        /// <item><description><b>Year:</b> billed on an annual basis.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If the <b>InstanceChargeType</b> parameter is set to <b>PREPAY</b>, you must configure this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The coupon code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50003298014****</para>
        /// </summary>
        [NameInMap("PromotionOptionNo")]
        [Validation(Required=false)]
        public string PromotionOptionNo { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The ID of the region in which to create the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        [Obsolete]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the standard GA instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekzrnd67gq****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The type of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Small Ⅰ.</description></item>
        /// <item><description><b>2</b>: Small Ⅱ.</description></item>
        /// <item><description><b>3</b>: Small Ⅲ.</description></item>
        /// <item><description><b>5</b>: Medium Ⅰ.</description></item>
        /// <item><description><b>8</b>: Medium Ⅱ.</description></item>
        /// <item><description><b>10</b>: Medium Ⅲ.</description></item>
        /// <item><description><b>20</b>: Large Ⅰ.</description></item>
        /// <item><description><b>30</b>: Large Ⅱ.</description></item>
        /// <item><description><b>40</b>: Large Ⅲ.</description></item>
        /// <item><description><b>50</b>: Large IV.</description></item>
        /// <item><description><b>60</b>: Large V.</description></item>
        /// <item><description><b>70</b>: Large VI.</description></item>
        /// <item><description><b>80</b>: Large VII.</description></item>
        /// <item><description><b>90</b>: Large VIII.</description></item>
        /// <item><description><b>100</b>: Super Large Ⅰ.</description></item>
        /// <item><description><b>200</b>: Super Large Ⅱ.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>GA instances Large III and above are not available by default. To use these instances, contact your Alibaba Cloud account manager.</description></item>
        /// <item><description>If the <b>InstanceChargeType</b> parameter is set to <b>PREPAY</b>, you must configure this parameter.</description></item>
        /// </list>
        /// </remarks>
        /// <para>Different specifications provide different capabilities. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Instance type</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The tags of the GA instance.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateAcceleratorRequestTag> Tag { get; set; }
        public class CreateAcceleratorRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the GA instance. The tag key cannot be an empty string.</para>
            /// <para>The tag key can be up to 64 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tag-key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the GA instance. The tag value cannot be an empty string.</para>
            /// <para>The tag value can be up to 128 characters in length and cannot contain <c>http://</c> or <c>https://</c>. It cannot start with <c>aliyun</c> or <c>acs:</c>.</para>
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
