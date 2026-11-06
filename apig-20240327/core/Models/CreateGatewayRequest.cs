// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The billing method. This parameter is required for the Serverless edition and must be set to POSTPAY.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <para>The gateway instance edition:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard instance: Professional</para>
        /// </description></item>
        /// <item><description><para>Serverless: Serverless</para>
        /// </description></item>
        /// <item><description><para>Multi-tenant Serverless: MultiTenantServerless</para>
        /// </description></item>
        /// <item><description><para>Unknown: Unknown</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Professional</para>
        /// </summary>
        [NameInMap("gatewayEdition")]
        [Validation(Required=false)]
        public string GatewayEdition { get; set; }

        /// <summary>
        /// <para>The operation mode for AI multi-tenant V2. The default value is ENTERPRISE. This parameter is only allowed for AI and MultiTenantServerless.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ENTERPRISE</para>
        /// </summary>
        [NameInMap("gatewayMode")]
        [Validation(Required=false)]
        public string GatewayMode { get; set; }

        /// <summary>
        /// <para>The gateway type. This parameter must be explicitly set to AI for AI Serverless or multi-tenant gateways.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        /// <summary>
        /// <para>The log configuration for the gateway.</para>
        /// </summary>
        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public CreateGatewayRequestLogConfig LogConfig { get; set; }
        public class CreateGatewayRequestLogConfig : TeaModel {
            /// <summary>
            /// <para>The Simple Log Service (SLS) configuration used to control gateway log collection.</para>
            /// </summary>
            [NameInMap("sls")]
            [Validation(Required=false)]
            public CreateGatewayRequestLogConfigSls Sls { get; set; }
            public class CreateGatewayRequestLogConfigSls : TeaModel {
                /// <summary>
                /// <para>Specifies whether to enable SLS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

        }

        /// <summary>
        /// <para>The name of the gateway. This parameter is required for all editions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ceshi</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The network access configuration. This parameter is actually required. If it is not provided, the service returns InvalidParameter.IsEmpty (400).</para>
        /// </summary>
        [NameInMap("networkAccessConfig")]
        [Validation(Required=false)]
        public CreateGatewayRequestNetworkAccessConfig NetworkAccessConfig { get; set; }
        public class CreateGatewayRequestNetworkAccessConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the endpoint security group. This parameter is required when a multi-tenant API gateway or multi-tenant AI gateway Enterprise Edition selects private network or dual-entry access. It must be an unmanaged security group in the user VPC. Do not pass this parameter for public network requests.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-bp1example123456789</para>
            /// </summary>
            [NameInMap("endpointSecurityGroupId")]
            [Validation(Required=false)]
            public string EndpointSecurityGroupId { get; set; }

            /// <summary>
            /// <para>The network access type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-ahr5uil8raz0rq3b</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The node specifications. This parameter is required for the Serverless edition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apigw.dev.x1</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<CreateGatewayRequestTag> Tag { get; set; }
        public class CreateGatewayRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the VPC. This parameter is required for all editions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-zm0x16tomfiat1mk9f6rs</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone configuration. This parameter is required for all editions.</para>
        /// </summary>
        [NameInMap("zoneConfig")]
        [Validation(Required=false)]
        public CreateGatewayRequestZoneConfig ZoneConfig { get; set; }
        public class CreateGatewayRequestZoneConfig : TeaModel {
            /// <summary>
            /// <para>The zone option.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("selectOption")]
            [Validation(Required=false)]
            public string SelectOption { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The list of supported zones. At least two zones are required.</para>
            /// </summary>
            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<CreateGatewayRequestZoneConfigZones> Zones { get; set; }
            public class CreateGatewayRequestZoneConfigZones : TeaModel {
                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-xx</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-j</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
