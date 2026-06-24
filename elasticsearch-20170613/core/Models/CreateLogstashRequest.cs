// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class CreateLogstashRequest : TeaModel {
        /// <summary>
        /// <para>The name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ls-cn-abc</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The network configuration.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("networkConfig")]
        [Validation(Required=false)]
        public CreateLogstashRequestNetworkConfig NetworkConfig { get; set; }
        public class CreateLogstashRequestNetworkConfig : TeaModel {
            /// <summary>
            /// <para>The network type. Currently, only VPC is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp16k1dvzxtmagcva****</para>
            /// </summary>
            [NameInMap("vpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone where the instance is deployed.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-i</para>
            /// </summary>
            [NameInMap("vsArea")]
            [Validation(Required=false)]
            public string VsArea { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp1k4ec6s7sjdbudw****</para>
            /// </summary>
            [NameInMap("vswitchId")]
            [Validation(Required=false)]
            public string VswitchId { get; set; }

        }

        /// <summary>
        /// <para>The number of nodes in the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("nodeAmount")]
        [Validation(Required=false)]
        public int? NodeAmount { get; set; }

        /// <summary>
        /// <para>The configuration of data nodes.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("nodeSpec")]
        [Validation(Required=false)]
        public CreateLogstashRequestNodeSpec NodeSpec { get; set; }
        public class CreateLogstashRequestNodeSpec : TeaModel {
            /// <summary>
            /// <para>The disk size of the node. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>50</para>
            /// </summary>
            [NameInMap("disk")]
            [Validation(Required=false)]
            public long? Disk { get; set; }

            /// <summary>
            /// <para>The disk type of the node. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>cloud_ssd</description></item>
            /// <item><description>cloud_efficiency.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_ssd</para>
            /// </summary>
            [NameInMap("diskType")]
            [Validation(Required=false)]
            public string DiskType { get; set; }

            /// <summary>
            /// <para>The node specifications. For more information about specifications, see <a href="https://help.aliyun.com/document_detail/271718.html">Product specifications</a>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>elasticsearch.ic5.2xlarge</para>
            /// </summary>
            [NameInMap("spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

        }

        /// <summary>
        /// <para>The billing details of the subscription instance. This parameter is required when you create a subscription instance.</para>
        /// </summary>
        [NameInMap("paymentInfo")]
        [Validation(Required=false)]
        public CreateLogstashRequestPaymentInfo PaymentInfo { get; set; }
        public class CreateLogstashRequestPaymentInfo : TeaModel {
            /// <summary>
            /// <para>The auto-renewal epoch. Unit: months. This parameter is required when <b>isAutoRenew</b> is set to <b>true</b>. The valid values are the same as those on the buy page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("autoRenewDuration")]
            [Validation(Required=false)]
            public long? AutoRenewDuration { get; set; }

            /// <summary>
            /// <para>The subscription duration. You can purchase the instance on a monthly or yearly basis. Unit: 1 to 9 months, or 1 to 3 years.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable auto-renewal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Enabled.</description></item>
            /// <item><description>false: Disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("isAutoRenew")]
            [Validation(Required=false)]
            public bool? IsAutoRenew { get; set; }

            /// <summary>
            /// <para>The unit of the subscription duration. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Year: year.</description></item>
            /// <item><description>Month: month.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Month</para>
            /// </summary>
            [NameInMap("pricingCycle")]
            [Validation(Required=false)]
            public string PricingCycle { get; set; }

        }

        /// <summary>
        /// <para>The billing method of the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>prepaid: subscription.</description></item>
        /// <item><description>postpaid: pay-as-you-go.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prepaid</para>
        /// </summary>
        [NameInMap("paymentType")]
        [Validation(Required=false)]
        public string PaymentType { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the instance belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxxkk2p7****</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance version. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>6.7_with_X-Pack</description></item>
        /// <item><description>7.4_with_X-Pack.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6.7_with_X-Pack</para>
        /// </summary>
        [NameInMap("version")]
        [Validation(Required=false)]
        public string Version { get; set; }

        /// <summary>
        /// <para>A unique token that is used to ensure the idempotence of the request. The client generates this value. The value must be unique among different requests and cannot exceed 64 ASCII characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B3FF****</para>
        /// </summary>
        [NameInMap("clientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

    }

}
