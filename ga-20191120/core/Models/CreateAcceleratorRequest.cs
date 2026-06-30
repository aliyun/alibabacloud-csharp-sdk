// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class CreateAcceleratorRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>false</b> (default): Disables automatic payment. After an order is generated, go to the Order Hub to complete the payment.</para>
        /// </description></item>
        /// <item><description><para><b>true</b>: Enables automatic payment. The system automatically completes the payment.</para>
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
        /// <para>Specifies whether to enable auto-renewal for the instance. Valid values:</para>
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
        /// <para>The auto-renewal duration. Unit: month.</para>
        /// <para>Valid values: <b>1</b> to <b>12</b>. Default value: <b>1</b>.</para>
        /// <remarks>
        /// <para>This parameter is valid only when <b>AutoRenew</b> is set to <b>true</b>.</para>
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
        /// <item><description><para><b>true</b>: Yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): No.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is valid only when <b>AutoPay</b> is set to <b>true</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoUseCoupon")]
        [Validation(Required=false)]
        public string AutoUseCoupon { get; set; }

        /// <summary>
        /// <para>The bandwidth of the standard GA instance. Unit: <b>Mbps</b>.</para>
        /// <para>Valid values: 200 to 5000.</para>
        /// <remarks>
        /// <para>This parameter is required and valid only when the access mode of the acceleration area is Anycast.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The bandwidth billing method.</para>
        /// <list type="bullet">
        /// <item><description><para><b>BandwidthPackage</b>: Billed by bandwidth plan.</para>
        /// </description></item>
        /// <item><description><para><b>CDT</b>: Billed by data transfer.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>BandwidthPackage</para>
        /// </summary>
        [NameInMap("BandwidthBillingType")]
        [Validation(Required=false)]
        public string BandwidthBillingType { get; set; }

        /// <summary>
        /// <para>A client token that is used to ensure the idempotence of the request.</para>
        /// <para>Generate a parameter value from your client to make sure that the value is unique among different requests. The ClientToken parameter can contain only ASCII characters.</para>
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
        /// <para>Specifies whether to perform a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Performs a dry run. The system checks the required parameters, request format, and service limits. If the request fails the dry run, an error message is returned. If the request passes the dry run, the <c>DryRunOperation</c> error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): Sends a normal request. If the request passes the check, a 2xx HTTP status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The subscription duration.</para>
        /// <list type="bullet">
        /// <item><description><para>If <b>PricingCycle</b> is set to <b>Month</b>, the valid values for <b>Duration</b> are <b>1</b> to <b>9</b>.</para>
        /// </description></item>
        /// <item><description><para>If <b>PricingCycle</b> is set to <b>Year</b>, the valid values for <b>Duration</b> are <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if <b>InstanceChargeType</b> (the billing method of the GA instance) is set to <b>PREPAY</b> (subscription).</para>
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
        /// <item><description><para>PREPAY (default): subscription.</para>
        /// </description></item>
        /// <item><description><para>POSTPAY: pay-as-you-go.</para>
        /// </description></item>
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
            /// <item><description><para><b>UserDefine</b>: Custom nearby access mode. Select acceleration areas and regions as needed. Global Accelerator provides a separate elastic IP address (EIP) for each acceleration region.</para>
            /// </description></item>
            /// <item><description><para><b>Anycast</b>: Automatic nearby access mode. You do not need to configure an acceleration area. Global Accelerator provides an Anycast EIP for multiple regions. Users connect to the nearest access point of the Alibaba Cloud network using the Anycast EIP.</para>
            /// </description></item>
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
        /// <para>The name must be 1 to 128 characters in length, start with a letter, and can contain digits, underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The billing cycle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b>: Billed by month.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: Billed by year.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if <b>InstanceChargeType</b> (the billing method of the GA instance) is set to <b>PREPAY</b> (subscription).</para>
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

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The region ID of the GA instance. Set the value to <b>cn-hangzhou</b>.</para>
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
        /// <para>The instance type of the GA instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: Small I</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: Small II</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: Small III</para>
        /// </description></item>
        /// <item><description><para><b>5</b>: Medium I</para>
        /// </description></item>
        /// <item><description><para><b>8</b>: Medium II</para>
        /// </description></item>
        /// <item><description><para><b>10</b>: Medium III</para>
        /// </description></item>
        /// <item><description><para><b>20</b>: Large I</para>
        /// </description></item>
        /// <item><description><para><b>30</b>: Large II</para>
        /// </description></item>
        /// <item><description><para><b>40</b>: Large III</para>
        /// </description></item>
        /// <item><description><para><b>50</b>: Large IV</para>
        /// </description></item>
        /// <item><description><para><b>60</b>: Large V</para>
        /// </description></item>
        /// <item><description><para><b>70</b>: Large VI</para>
        /// </description></item>
        /// <item><description><para><b>80</b>: Large VII</para>
        /// </description></item>
        /// <item><description><para><b>90</b>: Large VIII</para>
        /// </description></item>
        /// <item><description><para><b>100</b>: Super Large I</para>
        /// </description></item>
        /// <item><description><para><b>200</b>: Super Large II</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>Currently, the Large III and higher instance types are available only to users on the whitelist. To use these instance types, contact your account manager.</para>
        /// </description></item>
        /// <item><description><para>This parameter is required if <b>InstanceChargeType</b> (the billing method of the GA instance) is set to <b>PREPAY</b> (subscription).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>The definitions of different instance types are different. For more information, see <a href="https://help.aliyun.com/document_detail/153127.html">Instance types</a>.</para>
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
            /// <para>The tag value of the GA instance. The tag value can be an empty string.</para>
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

    }

}
