// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EPG20260715.Models
{
    public class GetEgressProxyGatewayAttributeResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the egress proxy gateway was created. The time is displayed in UTC and follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-07-02T02:49:05Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The ID of the default egress IP pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eppool-gw80d96a96ca0b00****</para>
        /// </summary>
        [NameInMap("DefaultEgressProxyIpPoolId")]
        [Validation(Required=false)]
        public string DefaultEgressProxyIpPoolId { get; set; }

        /// <summary>
        /// <para>The description of the egress proxy gateway instance. The description must be 2 to 256 characters in length and can contain Chinese characters and English letters. It can also contain digits, commas (,), periods (.), semicolons (;), forward slashes (/), at signs (@), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The DNS domain name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-gw80bb6a94f835****.cn-shanghai.epg.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DnsName")]
        [Validation(Required=false)]
        public string DnsName { get; set; }

        /// <summary>
        /// <para>The ID of the associated egress proxy configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epc-uf609a6a8fdf9f4d****</para>
        /// </summary>
        [NameInMap("EgressProxyConfigurationId")]
        [Validation(Required=false)]
        public string EgressProxyConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the egress proxy gateway instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>epg-gw80bb6a94f835db****</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayId")]
        [Validation(Required=false)]
        public string EgressProxyGatewayId { get; set; }

        /// <summary>
        /// <para>The name of the egress proxy gateway. The name must be 2 to 128 characters in length and can contain English letters and Chinese characters. It must start with a letter or a Chinese character and can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>testEpg</para>
        /// </summary>
        [NameInMap("EgressProxyGatewayName")]
        [Validation(Required=false)]
        public string EgressProxyGatewayName { get; set; }

        /// <summary>
        /// <para>The list of listener properties.</para>
        /// </summary>
        [NameInMap("ListenerProperties")]
        [Validation(Required=false)]
        public List<GetEgressProxyGatewayAttributeResponseBodyListenerProperties> ListenerProperties { get; set; }
        public class GetEgressProxyGatewayAttributeResponseBodyListenerProperties : TeaModel {
            /// <summary>
            /// <para>The listener port. Valid values: 1 to 65535.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The listener protocol. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>HTTP</b></description></item>
            /// <item><description><b>HTTPS</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>HTTP</para>
            /// </summary>
            [NameInMap("Protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>01A05AB7-6C14-5A12-94E7-F20F9F69AE3D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aek2zye42m****</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The instance status of the egress proxy gateway. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Provisioning</b>: The instance is being created.</description></item>
        /// <item><description><b>Active</b>: The instance is running.</description></item>
        /// <item><description><b>Configuring</b>: The instance is being reconfigured.</description></item>
        /// <item><description><b>Inactive</b>: The instance is stopped.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetEgressProxyGatewayAttributeResponseBodyTags> Tags { get; set; }
        public class GetEgressProxyGatewayAttributeResponseBodyTags : TeaModel {
            /// <summary>
            /// <para>The tag key. The key can be up to 128 characters in length. It cannot start with aliyun or acs: and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value. The value can be up to 256 characters in length and cannot contain http:// or https://.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The TLS interception properties.</para>
        /// </summary>
        [NameInMap("TlsInterceptProperties")]
        [Validation(Required=false)]
        public GetEgressProxyGatewayAttributeResponseBodyTlsInterceptProperties TlsInterceptProperties { get; set; }
        public class GetEgressProxyGatewayAttributeResponseBodyTlsInterceptProperties : TeaModel {
            /// <summary>
            /// <para>The ID of the private CA certificate.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1f01a6f9-a0e7-64e5-9d3c-29c056bf****</para>
            /// </summary>
            [NameInMap("PrivateCaCertificateId")]
            [Validation(Required=false)]
            public string PrivateCaCertificateId { get; set; }

            /// <summary>
            /// <para>The TLS Block Mode. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: Enables the TLS Block Mode.</description></item>
            /// <item><description><b>disable</b>: Disables the TLS Block Mode.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("TlsInterceptMode")]
            [Validation(Required=false)]
            public string TlsInterceptMode { get; set; }

        }

        /// <summary>
        /// <para>The ID of the virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-n4appznmjjr362yd3****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The list of zone and vSwitch mappings. If the current region supports two or more zones, at least two zones must be returned.</para>
        /// </summary>
        [NameInMap("ZoneMappings")]
        [Validation(Required=false)]
        public List<GetEgressProxyGatewayAttributeResponseBodyZoneMappings> ZoneMappings { get; set; }
        public class GetEgressProxyGatewayAttributeResponseBodyZoneMappings : TeaModel {
            /// <summary>
            /// <para>The zone status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Provisioning</b>: The zone is being created.</description></item>
            /// <item><description><b>Available</b>: The zone is available.</description></item>
            /// <item><description><b>Configuring</b>: The zone is being reconfigured.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch that corresponds to the zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-f8zvrktbjs9hh3xqz****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shanghai-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

    }

}
