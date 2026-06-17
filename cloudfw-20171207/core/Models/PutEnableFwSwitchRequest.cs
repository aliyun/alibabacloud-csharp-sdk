// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutEnableFwSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The IP version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The list of IP addresses.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>IpaddrList</c>, <c>RegionList</c>, and <c>ResourceTypeList</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;192.0.X.X&quot;,&quot;192.0.X.X&quot;]</para>
        /// </summary>
        [NameInMap("IpaddrList")]
        [Validation(Required=false)]
        public List<string> IpaddrList { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The list of regions.</para>
        /// <remarks>
        /// <para>You must specify at least one of the <c>IpaddrList</c>, <c>RegionList</c>, and <c>ResourceTypeList</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;,&quot;cn-shanghai&quot;]</para>
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// <para>The list of asset types.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BastionHostEgressIP</b>: the egress IP address of a bastion host.</para>
        /// </description></item>
        /// <item><description><para><b>BastionHostIngressIP</b>: the ingress IP address of a bastion host.</para>
        /// </description></item>
        /// <item><description><para><b>EcsEIP</b>: the EIP of an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>EcsPublicIP</b>: the public IP address of an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>EIP</b>: an EIP.</para>
        /// </description></item>
        /// <item><description><para><b>EniEIP</b>: the EIP of an ENI.</para>
        /// </description></item>
        /// <item><description><para><b>NatEIP</b>: the EIP of a NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>SlbEIP</b>: the EIP of an SLB instance or a CLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>SlbPublicIP</b>: the public IP address of an SLB instance or a CLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>NatPublicIP</b>: the public IP address of a NAT gateway.</para>
        /// </description></item>
        /// <item><description><para><b>HAVIP</b>: an HAVIP.</para>
        /// </description></item>
        /// <item><description><para><b>NlbEIP</b>: the EIP of an NLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>ApiGatewayEIP</b>: the public IP address of an API gateway.</para>
        /// </description></item>
        /// <item><description><para><b>AlbEIP</b>: the EIP of an ALB instance.</para>
        /// </description></item>
        /// <item><description><para><b>AiGatewayEIP</b>: the public IP address of an AI gateway.</para>
        /// </description></item>
        /// <item><description><para><b>GaEIP</b>: the EIP of a GA instance.</para>
        /// </description></item>
        /// <item><description><para><b>SwasEIP</b>: the public IP address of a Simple Application Server instance.</para>
        /// </description></item>
        /// <item><description><para><b>EcdEIP</b>: the public IP address of an Elastic Desktop Service instance.</para>
        /// </description></item>
        /// <item><description><para><b>BastionHostIP</b>: the IP address of a bastion host.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least one of the <c>IpaddrList</c>, <c>RegionList</c>, and <c>ResourceTypeList</c> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;EcsPublicIp&quot;,&quot;NatEip&quot;]</para>
        /// </summary>
        [NameInMap("ResourceTypeList")]
        [Validation(Required=false)]
        public List<string> ResourceTypeList { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
