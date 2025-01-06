// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to automatically complete the payment of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: yes</description></item>
        /// <item><description><b>false</b> (default): no</description></item>
        /// </list>
        /// <para>If you set the parameter to false, go to Billing Management to complete the payment after you call this operation. The instance is created only after you complete the payment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoPay")]
        [Validation(Required=false)]
        public bool? AutoPay { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the auto-renewal feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: enables auto-renewal.</description></item>
        /// <item><description><b>false</b> (default): disables auto-renewal.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Only subscription bandwidth plans support auto-renewal.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("AutoRenew")]
        [Validation(Required=false)]
        public bool? AutoRenew { get; set; }

        /// <summary>
        /// <para>The auto-renewal duration. Unit: months. Valid values: <b>0</b> to <b>2147483647</b>. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AutoRenewDuration")]
        [Validation(Required=false)]
        public int? AutoRenewDuration { get; set; }

        /// <summary>
        /// <para>The maximum bandwidth value of the bandwidth plan. Unit: Mbit/s. Valid values: <b>2</b> to <b>10000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth plan. Set the value to <b>PREPAY</b>, which indicates that the billing method is pay-as-you-go.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("BandwidthPackageChargeType")]
        [Validation(Required=false)]
        public string BandwidthPackageChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the token, but you must make sure that the token is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the bandwidth plan.</para>
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
        /// <item><description><b>China</b>: Chinese mainland</description></item>
        /// <item><description><b>North-America</b>: North America</description></item>
        /// <item><description><b>Asia-Pacific</b>: Asia Pacific</description></item>
        /// <item><description><b>Europe</b>: Europe</description></item>
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
        /// <para>The area where the other network instance is deployed. Valid values: Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>China</b>: Chinese mainland</description></item>
        /// <item><description><b>North-America</b>: North America</description></item>
        /// <item><description><b>Asia-Pacific</b>: Asia Pacific</description></item>
        /// <item><description><b>Europe</b>: Europe</description></item>
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
        /// <para>The name must be 2 to 128 characters in length, and can contain letters, digits, underscores (_), and hyphens (-). The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</para>
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
        /// <item><description>If <b>PricingCycle</b> is set to <b>Month</b>, set <b>Period</b> to a value from <b>1</b> to <b>3</b> or <b>6</b>.</description></item>
        /// <item><description>If <b>PricingCycle</b> is set to <b>Year</b>, set <b>Period</b> to a value from <b>1</b> to <b>3</b>.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>BandwidthPackageChargeType</b> is set to <b>PREPAY</b>.</para>
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
        /// <item><description><b>Month</b> (default): billed on a monthly basis.</description></item>
        /// <item><description><b>Year</b>: billed on an annual basis.</description></item>
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
        /// <para>The information about the tags.</para>
        /// <para>You can specify at most 20 tags in each call.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCenBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateCenBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// <para>The tag keys cannot be an empty string. The tag key can be up to 64 characters in length, and cannot start with <c>acs:</c> or <c>aliyun</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>You can specify at most 20 tag keys.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// <para>The tag value can be 0 to 128 characters in length, and cannot start with <c>aliyun</c> or <c>acs:</c>. It cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// <para>Each tag key must have a unique tag value. You can specify at most 20 tag values in each call.</para>
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
