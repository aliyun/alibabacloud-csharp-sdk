// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddResolverRuleRequest : TeaModel {
        [NameInMap("EdgeDnsClusters")]
        [Validation(Required=false)]
        public List<AddResolverRuleRequestEdgeDnsClusters> EdgeDnsClusters { get; set; }
        public class AddResolverRuleRequestEdgeDnsClusters : TeaModel {
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

        }

        /// <summary>
        /// <para>The ID of the outbound endpoint. The outbound endpoint forwards DNS queries to the specified destination IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The IP addresses and ports of the destination servers in the external DNS system to which DNS queries are forwarded. You can specify up to <b>6</b> destination servers. Both private and public IP addresses are supported.</para>
        /// <remarks>
        /// <para>If you specify public IP addresses for the external DNS servers, and the Elastic Compute Service (ECS) instances in the VPC of the outbound endpoint do not have public IP addresses, enable a NAT Gateway and configure SNAT entries.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("ForwardIp")]
        [Validation(Required=false)]
        public List<AddResolverRuleRequestForwardIp> ForwardIp { get; set; }
        public class AddResolverRuleRequestForwardIp : TeaModel {
            /// <summary>
            /// <para>The IP address of the destination server.</para>
            /// <remarks>
            /// <para>The IP addresses in the following ranges are reserved by the system and cannot be used as the IP addresses of external DNS systems: 100.100.2.136 to 100.100.2.138 and 100.100.2.116 to 100.100.2.118.</para>
            /// </remarks>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The port number of the destination server.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8080</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

        }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the forwarding rule. Name the rule as needed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the forwarding rule. The only valid value is OUTBOUND. This value indicates that DNS queries are forwarded to an external IP address.</para>
        /// <remarks>
        /// <para>You cannot change this value after the forwarding rule is created.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>OUTBOUND</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public List<AddResolverRuleRequestVpcs> Vpcs { get; set; }
        public class AddResolverRuleRequestVpcs : TeaModel {
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            [NameInMap("VpcType")]
            [Validation(Required=false)]
            public string VpcType { get; set; }

            [NameInMap("VpcUserId")]
            [Validation(Required=false)]
            public long? VpcUserId { get; set; }

        }

        /// <summary>
        /// <para>The domain name (zone) for which you want to forward DNS queries.</para>
        /// <remarks>
        /// <para>You cannot change this value after the forwarding rule is created.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("ZoneName")]
        [Validation(Required=false)]
        public string ZoneName { get; set; }

    }

}
