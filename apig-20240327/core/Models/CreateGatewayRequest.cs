// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class CreateGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The logging configurations.</para>
        /// 
        /// <b>Example:</b>
        /// <para>POSTPAY</para>
        /// </summary>
        [NameInMap("chargeType")]
        [Validation(Required=false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Professional</para>
        /// </summary>
        [NameInMap("gatewayEdition")]
        [Validation(Required=false)]
        public string GatewayEdition { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>API</para>
        /// </summary>
        [NameInMap("gatewayType")]
        [Validation(Required=false)]
        public string GatewayType { get; set; }

        [NameInMap("logConfig")]
        [Validation(Required=false)]
        public CreateGatewayRequestLogConfig LogConfig { get; set; }
        public class CreateGatewayRequestLogConfig : TeaModel {
            [NameInMap("sls")]
            [Validation(Required=false)]
            public CreateGatewayRequestLogConfigSls Sls { get; set; }
            public class CreateGatewayRequestLogConfigSls : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("enable")]
                [Validation(Required=false)]
                public bool? Enable { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the vSwitch.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-ceshi</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The gateway edition.</para>
        /// </summary>
        [NameInMap("networkAccessConfig")]
        [Validation(Required=false)]
        public CreateGatewayRequestNetworkAccessConfig NetworkAccessConfig { get; set; }
        public class CreateGatewayRequestNetworkAccessConfig : TeaModel {
            /// <summary>
            /// <list type="bullet">
            /// <item><description></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Internet</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>rg-ahr5uil8raz0rq3b</para>
        /// </summary>
        [NameInMap("resourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>apigw.dev.x2</para>
        /// </summary>
        [NameInMap("spec")]
        [Validation(Required=false)]
        public string Spec { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public List<CreateGatewayRequestTag> Tag { get; set; }
        public class CreateGatewayRequestTag : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>key</para>
            /// </summary>
            [NameInMap("key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>value</para>
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The tag value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-zm0x16tomfiat1mk9f6rs</para>
        /// </summary>
        [NameInMap("vpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The status message.</para>
        /// </summary>
        [NameInMap("zoneConfig")]
        [Validation(Required=false)]
        public CreateGatewayRequestZoneConfig ZoneConfig { get; set; }
        public class CreateGatewayRequestZoneConfig : TeaModel {
            /// <summary>
            /// <para>The response payload.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Manual</para>
            /// </summary>
            [NameInMap("selectOption")]
            [Validation(Required=false)]
            public string SelectOption { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>vsw-xxx</para>
            /// </summary>
            [NameInMap("vSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            [NameInMap("zones")]
            [Validation(Required=false)]
            public List<CreateGatewayRequestZoneConfigZones> Zones { get; set; }
            public class CreateGatewayRequestZoneConfigZones : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>vsw-xx</para>
                /// </summary>
                [NameInMap("vSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-wulanchabu-a</para>
                /// </summary>
                [NameInMap("zoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

    }

}
