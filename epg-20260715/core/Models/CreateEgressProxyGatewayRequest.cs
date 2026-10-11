// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class CreateEgressProxyGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// <para>You can use the client to generate the value, but you must ensure that it is unique among different requests. The client token can contain only ASCII characters.</para>
        /// <remarks>
        /// <para>Note If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request is unique.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>5A2CFF0E-5718-45B5-9D4D-70B******</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the egress proxy gateway instance.</para>
        /// <para>The description must be 2 to 256 characters in length, and can contain Chinese characters, letters, digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to only precheck the request. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: prechecks the request without creating the egress proxy gateway instance. The system checks whether required parameters are specified, the request format, and service limits. If the request fails the precheck, the corresponding error is returned. If the request passes the precheck, the DryRunOperation error code is returned.</para>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): sends the request. If the request passes the precheck, the HTTP 2xx status code is returned and the operation is performed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the egress proxy configuration that is associated with the egress proxy gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-uf609a6a8fdf9f4****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

        /// <summary>
        /// <para>The name of the egress proxy gateway instance.</para>
        /// <para>The name must be 2 to 128 characters in length, and must start with a letter or a Chinese character. It can contain Chinese characters, letters, digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayName")]
        [Validation(Required=false)]
        public string EgressProxyGatewayName { get; set; }

        /// <summary>
        /// <para>The listener configurations of the egress proxy gateway instance.</para>
        /// <para>Listeners in the same gateway instance cannot use the same port.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ListenerProperties")]
        [Validation(Required=false)]
        public List<CreateEgressProxyGatewayRequestListenerProperties> ListenerProperties { get; set; }
        public class CreateEgressProxyGatewayRequestListenerProperties : TeaModel {
            /// <summary>
            /// <para>The listener port.</para>
            /// <para>Valid values: <b>1</b> to <b>65535</b>.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The protocol type of the listener. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>HTTP</b>: HTTP.</para>
            /// </description></item>
            /// <item><description><para><b>HTTPS</b>: HTTPS.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tags.</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public List<CreateEgressProxyGatewayRequestTag> Tag { get; set; }
        public class CreateEgressProxyGatewayRequestTag : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters in length. It cannot start with <c>aliyun</c> or <c>acs:</c>, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 256 characters in length, and cannot contain <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The TLS interception configuration of the egress proxy gateway instance.</para>
        /// </summary>
        [NameInMap("TlsInterceptProperties")]
        [Validation(Required=false)]
        public CreateEgressProxyGatewayRequestTlsInterceptProperties TlsInterceptProperties { get; set; }
        public class CreateEgressProxyGatewayRequestTlsInterceptProperties : TeaModel {
            /// <summary>
            /// <para>The ID of the private CA certificate.</para>
            /// <list type="bullet">
            /// <item><description>This parameter is required when <b>TlsInterceptMode</b> is set to <b>enable</b>.</description></item>
            /// <item><description>Do not specify this parameter when <b>TlsInterceptMode</b> is set to <b>disable</b>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1f01a6f9-a0e7-64e5-9d3c-29c056bf****</para>
            /// </summary>
            [NameInMap("PrivateCaCertificateId")]
            [Validation(Required=false)]
            public string PrivateCaCertificateId { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable TLS interception. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: enables TLS interception.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: disables TLS interception.</para>
            /// </description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("TlsInterceptMode")]
            [Validation(Required=false)]
            public string TlsInterceptMode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC) to which the egress proxy gateway instance belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-zm0ejg5unozkhvuhd****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The zone and vSwitch mappings of the egress proxy gateway instance.</para>
        /// <para>If the current region supports two or more zones, add at least two zones to improve availability.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<CreateEgressProxyGatewayRequestZoneMappings> ZoneMappings { get; set; }
        public class CreateEgressProxyGatewayRequestZoneMappings : TeaModel {
            /// <summary>
            /// <para>The ID of the vSwitch that corresponds to the zone.</para>
            /// <para>The vSwitch must belong to the specified VPC and match the zone specified by ZoneId.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-wz9aejevoin852mo****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// <para>You can call the DescribeZones operation to query information about zones in a region.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-m</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
