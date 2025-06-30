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
        /// <para>The outbound endpoint ID. The outbound endpoint is used to forward the DNS requests to the specified destination IP addresses.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>The IP addresses and ports of the external DNS servers. Enter the IP addresses and ports of the destination servers to which the DNS requests are forwarded. You can enter up to <b>six</b> IP addresses and ports. Both private and public IP addresses are supported.</para>
        /// <remarks>
        /// <para> If you specify public IP addresses as the IP addresses of the external DNS servers and Elastic Compute Service (ECS) instances in the outbound VPC are not assigned public IP addresses, you need to activate NAT Gateway for the VPC and create and manage SNAT entries on a NAT gateway.</para>
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
            /// <para> The following CIDR blocks are reserved by the system: 100.100.2.136 to 100.100.2.138 and 100.100.2.116 to 100.100.2.118. You cannot specify the IP addresses within these CIDR blocks for the external DNS servers.</para>
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
            /// <para>The port of the destination server.</para>
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
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
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
        /// <para>The name of the forwarding rule. You can name the rule based on your business requirements.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The type of the forwarding rule. The parameter value can only be OUTBOUND, which indicates that DNS requests are forwarded to one or more external IP addresses.</para>
        /// <remarks>
        /// <para> You cannot change the value of Type after you create the forwarding rule.</para>
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
        /// <para>The zone for which you want to forward DNS requests.</para>
        /// <remarks>
        /// <para> You cannot change the value of ZoneName after you create the forwarding rule.</para>
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
