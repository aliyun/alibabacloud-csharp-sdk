// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vpc20160428.Models
{
    public class ModifyNatGatewayAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The description of the NAT gateway that you want to modify.</para>
        /// <para>The description must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The EIP attach mode of the NAT gateway. Valid values: Leave this parameter empty or set it to <b>NAT</b>, which indicates the standard EIP mode.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>You can only change the mode from <b>MULTI_BINDED</b> to <b>NAT</b>. You cannot change the mode from <b>NAT</b> to <b>MULTI_BINDED</b>. For more information about the <b>MULTI_BINDED</b> mode, see <a href="https://help.aliyun.com/document_detail/120219.html">CreateNatGateway</a>.</description></item>
        /// </list>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description>During the EIP attach mode switch procedure, network connectivity may experience a transient connection that lasts for a few seconds (the duration of the transient connection increases with the number of EIPs. Currently, configuration changes are supported only for NAT gateways with up to five EIPs attached). We recommend that you execute the switch operation during off-peak hours.</description></item>
        /// <item><description>After the EIP attach mode is changed to <b>NAT</b>, the Internet NAT gateway becomes compatible with the IPv4 gateway. However, attaching a public EIP consumes a private IP address from the vSwitch where the NAT gateway resides. Ensure that the vSwitch has sufficient private IP addresses. If no idle private IP address is available in the vSwitch, you cannot attach new EIPs.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>NAT</para>
        /// </summary>
        [NameInMap("EipBindMode")]
        [Validation(Required=false)]
        public string EipBindMode { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the session log feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The session log feature is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The session log feature is disabled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSessionLog")]
        [Validation(Required=false)]
        public bool? EnableSessionLog { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable ICMP echo reply. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b> (default): Enabled.</description></item>
        /// <item><description><b>false</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IcmpReplyEnabled")]
        [Validation(Required=false)]
        public bool? IcmpReplyEnabled { get; set; }

        /// <summary>
        /// <para>The IPv6 configuration.</para>
        /// </summary>
        [NameInMap("Ipv6Config")]
        [Validation(Required=false)]
        public ModifyNatGatewayAttributeRequestIpv6Config Ipv6Config { get; set; }
        public class ModifyNatGatewayAttributeRequestIpv6Config : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable IPv6. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Enabled.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: Disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Ipv6Enabled")]
            [Validation(Required=false)]
            public bool? Ipv6Enabled { get; set; }

        }

        /// <summary>
        /// <para>The session log configuration.</para>
        /// </summary>
        [NameInMap("LogDelivery")]
        [Validation(Required=false)]
        public ModifyNatGatewayAttributeRequestLogDelivery LogDelivery { get; set; }
        public class ModifyNatGatewayAttributeRequestLogDelivery : TeaModel {
            /// <summary>
            /// <para>The destination type for session logs. Valid value: <b>sls</b>, which indicates Simple Log Service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sls</para>
            /// </summary>
            [NameInMap("LogDeliveryType")]
            [Validation(Required=false)]
            public string LogDeliveryType { get; set; }

            /// <summary>
            /// <para>The destination address for session logs. Format: acs:log:${regionName}:${projectOwnerAliUid}:project/${projectName}/logstore/${logstoreName}.</para>
            /// 
            /// <b>Example:</b>
            /// <para>acs:log:cn-hangzhou:0000:project/nat_session_log_project/logstore/session_log_test</para>
            /// </summary>
            [NameInMap("LogDestination")]
            [Validation(Required=false)]
            public string LogDestination { get; set; }

        }

        /// <summary>
        /// <para>The name of the NAT gateway that you want to modify.</para>
        /// <para>The name must be 1 to 128 characters in length, and cannot start with <c>http://</c> or <c>https://</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nat123</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the NAT gateway that you want to modify.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ngw-2ze0dcn4mq31qx2jc****</para>
        /// </summary>
        [NameInMap("NatGatewayId")]
        [Validation(Required=false)]
        public string NatGatewayId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID of the NAT gateway that you want to modify. </para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/36063.html">DescribeRegions</a> operation to query region IDs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
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

    }

}
