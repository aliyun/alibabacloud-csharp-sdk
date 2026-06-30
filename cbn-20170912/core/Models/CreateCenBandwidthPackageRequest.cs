// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no.</para>
        /// </description></item>
        /// </list>
        /// <para>If you disable automatic payment, you must go to the Order Hub in the console to complete the payment after you call this operation. Otherwise, the instance cannot be created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth of the bandwidth plan. Unit: Mbps. Valid values: <b>2</b> to <b>10000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth plan. Set the value to <b>PREPAY</b>. This value specifies the subscription billing method.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("BandwidthPackageChargeType")]
        [Validation(Required=false)]
        public string BandwidthPackageChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>Make sure that the client token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the bandwidth plan.</para>
        /// <para>The description can be empty or 1 to 256 characters in length. It cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namedesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The area where the network instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>China</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>North-America</b>: North America.</para>
        /// </description></item>
        /// <item><description><para><b>Asia-Pacific</b>: Asia-Pacific.</para>
        /// </description></item>
        /// <item><description><para><b>Europe</b>: Europe.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("GeographicRegionAId")]
        [Validation(Required=false)]
        public string GeographicRegionAId { get; set; }

        /// <summary>
        /// <para>The other area where the network instance is deployed. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>China</b>: the Chinese mainland.</para>
        /// </description></item>
        /// <item><description><para><b>North-America</b>: North America.</para>
        /// </description></item>
        /// <item><description><para><b>Asia-Pacific</b>: Asia-Pacific.</para>
        /// </description></item>
        /// <item><description><para><b>Europe</b>: Europe.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China</para>
        /// </summary>
        [NameInMap("GeographicRegionBId")]
        [Validation(Required=false)]
        public string GeographicRegionBId { get; set; }

        /// <summary>
        /// <para>The name of the bandwidth plan.</para>
        /// <para>The name can be empty or 1 to 128 characters in length. It cannot start with http\:// or https\://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nametest</para>
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
        /// <para>The subscription duration of the bandwidth plan. Default value: 1.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set <b>PricingCycle</b> to <b>Month</b>, valid values for <b>Period</b> are <b>1</b> to <b>3</b> and <b>6</b>.</para>
        /// </description></item>
        /// <item><description><para>If you set <b>PricingCycle</b> to <b>Year</b>, valid values for <b>Period</b> are <b>1</b> to <b>3</b>.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required if you set <b>BandwidthPackageChargeType</b> to <b>PREPAY</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public int? Period { get; set; }

        /// <summary>
        /// <para>The billing cycle of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Month</b> (default): The bandwidth plan is billed by month.</para>
        /// </description></item>
        /// <item><description><para><b>Year</b>: The bandwidth plan is billed by year.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Month</para>
        /// </summary>
        [NameInMap("PricingCycle")]
        [Validation(Required=false)]
        public string PricingCycle { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// <para>You can specify up to 20 tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCenBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateCenBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag key cannot be an empty string. The tag key can be up to 64 characters in length and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify up to 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be an empty string or a string of up to 128 characters. It cannot start with <c>aliyun</c> or <c>acs:</c> and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key corresponds to a tag value. You can specify up to 20 tag values.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
