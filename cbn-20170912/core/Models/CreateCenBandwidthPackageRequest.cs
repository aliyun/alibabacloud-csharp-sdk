// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class CreateCenBandwidthPackageRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable automatic payment for the bill of the bandwidth plan instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: yes.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): no.</para>
        /// </description></item>
        /// </list>
        /// <para>If you choose not to use automatic payment, after you invoke this operation, you must go to the Order Center in the console to complete the payment. Otherwise, the instance cannot be created.</para>
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
        /// <para>The maximum bandwidth of the bandwidth plan. Unit: Mbit/s. Valid values: <b>2</b> to <b>10000</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Bandwidth")]
        [Validation(Required=false)]
        public int? Bandwidth { get; set; }

        /// <summary>
        /// <para>The billing method of the bandwidth plan. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>PREPAY</b>: subscription.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PREPAY</para>
        /// </summary>
        [NameInMap("BandwidthPackageChargeType")]
        [Validation(Required=false)]
        public string BandwidthPackageChargeType { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>02fb3da4-130e-11e9-8e44-001****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the bandwidth plan.</para>
        /// <para>The description must be 1 to 256 characters in length, and can be left empty. It cannot start with http:// or https://.</para>
        /// 
        /// <b>Example:</b>
        /// <para>namedesc</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The area to which the network instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>China</b>: the Chinese mainland.</description></item>
        /// <item><description><b>North-America</b>: North America.</description></item>
        /// <item><description><b>Asia-Pacific</b>: Asia-Pacific.</description></item>
        /// <item><description><b>Europe</b>: Europe.</description></item>
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
        /// <para>The area to which the other network instance belongs. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>China</b>: the Chinese mainland.</description></item>
        /// <item><description><b>North-America</b>: North America.</description></item>
        /// <item><description><b>Asia-Pacific</b>: Asia-Pacific.</description></item>
        /// <item><description><b>Europe</b>: Europe.</description></item>
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
        /// <para>The name must be 1 to 128 characters in length, and can be left empty. It cannot start with http:// or https://.</para>
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
        /// <item><description>If <b>PricingCycle</b> is set to <b>Month</b>, valid values of <b>Period</b> are <b>1</b> to <b>3</b> and <b>6</b>.</description></item>
        /// <item><description>If <b>PricingCycle</b> is set to <b>Year</b>, valid values of <b>Period</b> are <b>1</b> to <b>3</b>.</description></item>
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

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The tag information.</para>
        /// <para>You can specify up to 20 tags at a time.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateCenBandwidthPackageRequestTag> Tag { get; set; }
        public class CreateCenBandwidthPackageRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key of the resource.</para>
            /// <para>The tag key cannot be an empty string. It can be up to 64 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>You can specify up to 20 tag keys at a time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tagtest</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value of the resource.</para>
            /// <para>The tag value cannot be empty. It can be up to 128 characters in length, and cannot start with aliyun or acs:. It cannot contain http:// or https://.</para>
            /// <para>Each tag key corresponds to a tag value. You can specify up to 20 tag values at a time.</para>
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
