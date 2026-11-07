// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese.</description></item>
        /// <item><description>en: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// <para>The billing method. This parameter is specified when you purchase a traditional instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("ChargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The network type of the pay-by-LCU Classic Load Balancer (CLB) to be purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pubnet: Internet.</description></item>
        /// <item><description>privatenet: Internal network.</description></item>
        /// <item><description>privatepubnet: Internet and internal network.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Traditional instance: When you create a traditional instance, you can purchase only one of the following load balancers: an NLB, a pay-by-LCU CLB, or a pay-by-specification CLB.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Serverless instance: When you create a Serverless instance, you can purchase only one of the following load balancers: an NLB or a pay-by-LCU CLB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pubnet</para>
        /// </summary>
        [NameInMap("ClbNetworkType")]
        [Validation(Required=false)]
        public string ClbNetworkType { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable hardware acceleration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableHardwareAcceleration")]
        [Validation(Required=false)]
        public bool? EnableHardwareAcceleration { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable log delivery to Simple Log Service (SLS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableSls")]
        [Validation(Required=false)]
        public bool? EnableSls { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable Tracing Analysis.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableXtrace")]
        [Validation(Required=false)]
        public bool? EnableXtrace { get; set; }

        /// <summary>
        /// <para>Specifies whether the security group is an advanced security group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnterpriseSecurityGroup")]
        [Validation(Required=false)]
        public bool? EnterpriseSecurityGroup { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The specifications of the Internet-facing SLB instance. This parameter is applicable to traditional instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Basic (slb.s1.small)</description></item>
        /// <item><description>Standard 1 (slb.s2.small)</description></item>
        /// <item><description>Standard I (slb.s2.medium)</description></item>
        /// <item><description>Advanced 1 (slb.s3.small)</description></item>
        /// <item><description>Advanced I (slb.s3.medium)</description></item>
        /// <item><description>Ultra-high I (slb.s3.large)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Traditional instance: When you create a traditional instance, you can purchase only one of the following load balancers: an NLB, a pay-by-LCU CLB, or a pay-by-specification CLB.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Serverless instance: When you create a Serverless instance, you can purchase only one of the following load balancers: an NLB or a pay-by-LCU CLB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s2.small</para>
        /// </summary>
        [NameInMap("InternetSlbSpec")]
        [Validation(Required=false)]
        [Obsolete]
        public string InternetSlbSpec { get; set; }

        /// <summary>
        /// <para>The gateway ingress type. This parameter is applicable to the Professional Edition of a standard instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pubnet: Internet.</description></item>
        /// <item><description>privatenet: Internal network.</description></item>
        /// <item><description>privatepubnet: Internet and internal network.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pubnet</para>
        /// </summary>
        [NameInMap("ManagedEntryNetworkType")]
        [Validation(Required=false)]
        public string ManagedEntryNetworkType { get; set; }

        /// <summary>
        /// <para>The gateway product type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>mse_premium: Professional Edition of a standard instance.</description></item>
        /// <item><description>mse_pro: Standard Edition of a standard instance.</description></item>
        /// <item><description>mse_serverless: Serverless.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>mse_pro</para>
        /// </summary>
        [NameInMap("MserVersion")]
        [Validation(Required=false)]
        public string MserVersion { get; set; }

        /// <summary>
        /// <para>The name of the gateway.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ceshi</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network type of the Network Load Balancer (NLB) to be purchased. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>pubnet: Internet.</description></item>
        /// <item><description>privatenet: Internal network.</description></item>
        /// <item><description>privatepubnet: Internet and internal network.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Traditional instance: When you create a traditional instance, you can purchase only one of the following load balancers: an NLB, a pay-by-LCU Classic Load Balancer (CLB), or a pay-by-specification CLB.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Serverless instance: When you create a Serverless instance, you can purchase only one of the following load balancers: an NLB or a pay-by-LCU CLB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pubnet</para>
        /// </summary>
        [NameInMap("NlbNetworkType")]
        [Validation(Required=false)]
        public string NlbNetworkType { get; set; }

        /// <summary>
        /// <para>The region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The number of nodes. This parameter is specified when you purchase a traditional instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Replica")]
        [Validation(Required=false)]
        public int? Replica { get; set; }

        /// <summary>
        /// <para>The extended fields.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("RequestPars")]
        [Validation(Required=false)]
        public string RequestPars { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfm34x43l*****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The specifications of the internal-facing Server Load Balancer (SLB) instance. This parameter is applicable to traditional instances. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Basic (slb.s1.small)</description></item>
        /// <item><description>Standard 1 (slb.s2.small)</description></item>
        /// <item><description>Standard I (slb.s2.medium)</description></item>
        /// <item><description>Advanced 1 (slb.s3.small)</description></item>
        /// <item><description>Advanced I (slb.s3.medium)</description></item>
        /// <item><description>Ultra-high I (slb.s3.large)</description></item>
        /// </list>
        /// <remarks>
        /// <para>Traditional instance: When you create a traditional instance, you can purchase only one of the following load balancers: an NLB, a pay-by-LCU CLB, or a pay-by-specification CLB.</para>
        /// </remarks>
        /// <remarks>
        /// <para>Serverless instance: When you create a Serverless instance, you can purchase only one of the following load balancers: an NLB or a pay-by-LCU CLB.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>slb.s2.small</para>
        /// </summary>
        [NameInMap("SlbSpec")]
        [Validation(Required=false)]
        [Obsolete]
        public string SlbSpec { get; set; }

        /// <summary>
        /// <para>The node specifications. This parameter is specified when you purchase a traditional instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>MSE_GTW_16_32_200_c(16C32G)</description></item>
        /// <item><description>MSE_GTW_2_4_200_c(2C4G)</description></item>
        /// <item><description>MSE_GTW_4_8_200_c(4C8G)</description></item>
        /// <item><description>MSE_GTW_8_16_200_c(8C16G)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>MSE_GTW_2_4_200_c</para>
        /// </summary>
        [NameInMap("Spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The tags of the gateway.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<AddGatewayRequestTag> Tag { get; set; }
        public class AddGatewayRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the primary vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-bp1q8th57frl5khj2li43</para>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The ID of the secondary vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-wz9bu6o5vsvitt5mrxo6s</para>
        /// </summary>
        [NameInMap("VSwitchId2")]
        [Validation(Required=false)]
        public string VSwitchId2 { get; set; }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-bp15mncnrtm83uauxd1xb</para>
        /// </summary>
        [NameInMap("Vpc")]
        [Validation(Required=false)]
        public string Vpc { get; set; }

        /// <summary>
        /// <para>The sampling rate for Tracing Analysis. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("XtraceRatio")]
        [Validation(Required=false)]
        public string XtraceRatio { get; set; }

        /// <summary>
        /// <para>The zone information.</para>
        /// </summary>
        [NameInMap("ZoneInfo")]
        [Validation(Required=false)]
        public List<AddGatewayRequestZoneInfo> ZoneInfo { get; set; }
        public class AddGatewayRequestZoneInfo : TeaModel {
            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-bp*****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-e</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
