// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class CreateIPv6TranslatorRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether automatic payment is enabled for subscription bills. Valid values: <b>true</b> and <b>false</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>The bandwidth of the IPv6 Translation Service instance. Unit: Mbit/s. Valid values: <b>1</b> to <b>200</b>. If you do not specify the bandwidth for an IPv6 translation mapping entry, all IPv6 translation mapping entries in the instance share this bandwidth. </para>
        /// <remarks>
        /// <para>If you do not specify the bandwidth, the default value is 10 Mbit/s.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. The client token must be unique across different requests and can contain a maximum of 64 ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha111</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The subscription duration. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If the billing cycle is <b>Month</b>, valid values are <b>1</b> to <b>9</b>.  </description></item>
        /// <item><description>If the billing cycle is <b>Year</b>, the valid value is <b>3</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Duration")]
        [Validation(Required=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// <para>The name of the IPv6 Translation Service instance. Default value: the instance ID. The name must be 2 to 100 characters in length, and must start with a letter or a Chinese character. It can contain digits, periods (.), underscores (_), and hyphens (-). It cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ipv6_1</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The billing method of the IPv6 Translation Service instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>PREPAY</b>: subscription.</para>
        /// </description></item>
        /// <item><description><para><b>POSTPAY</b>: pay-as-you-go.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("PayType")]
        [Validation(Required=false)]
        public string PayType { get; set; }

        /// <summary>
        /// <para>The billing cycle of the subscription instance. Valid values: </para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b> (default): billed on a monthly basis.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: billed on a yearly basis.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        /// <summary>
        /// <para>The region of the IPv6 Translation Service instance. You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cm-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The specification of the IPv6 Translation Service instance. Valid value: <b>small</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>small</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

    }

}
