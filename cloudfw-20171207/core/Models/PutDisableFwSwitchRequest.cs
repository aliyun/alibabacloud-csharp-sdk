// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutDisableFwSwitchRequest : TeaModel {
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
        /// <para>The IP addresses.</para>
        /// <remarks>
        /// <para>You must specify a value for at least one of the following parameters: <c>IpaddrList</c>, <c>RegionList</c>, and <c>ResourceTypeList</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;192.0.XX.XX&quot;,&quot;192.0.XX.XX&quot;]</para>
        /// </summary>
        [NameInMap("IpaddrList")]
        [Validation(Required=false)]
        public List<string> IpaddrList { get; set; }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b> (default): Chinese</para>
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
        /// <para>The unique identifier of the member.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The regions.</para>
        /// <remarks>
        /// <para>You must specify a value for at least one of the following parameters: <c>IpaddrList</c>, <c>RegionList</c>, and <c>ResourceTypeList</c>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;,&quot;cn-shanghai&quot;]</para>
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// <para>The asset types. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BastionHostEgressIP</b>: The egress IP address of a bastion host.</para>
        /// </description></item>
        /// <item><description><para><b>BastionHostIngressIP</b>: The ingress IP address of a bastion host.</para>
        /// </description></item>
        /// <item><description><para><b>EcsEIP</b>: The Elastic IP Address (EIP) of an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>EcsPublicIP</b>: The public IP address of an ECS instance.</para>
        /// </description></item>
        /// <item><description><para><b>EIP</b>: An Elastic IP Address (EIP).</para>
        /// </description></item>
        /// <item><description><para><b>EniEIP</b>: The EIP of an elastic network interface (ENI).</para>
        /// </description></item>
        /// <item><description><para><b>NatEIP</b>: The EIP of a NAT Gateway instance.</para>
        /// </description></item>
        /// <item><description><para><b>SlbEIP</b>: The EIP of a Server Load Balancer (SLB) or Classic Load Balancer (CLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>SlbPublicIP</b>: The public IP address of an SLB or CLB instance.</para>
        /// </description></item>
        /// <item><description><para><b>NatPublicIP</b>: The public IP address of a NAT Gateway instance.</para>
        /// </description></item>
        /// <item><description><para><b>HAVIP</b>: A High-availability Virtual IP (HAVIP).</para>
        /// </description></item>
        /// <item><description><para><b>NlbEIP</b>: The EIP of a Network Load Balancer (NLB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>ApiGatewayEIP</b>: The public IP address of an API Gateway instance.</para>
        /// </description></item>
        /// <item><description><para><b>AlbEIP</b>: The EIP of an Application Load Balancer (ALB) instance.</para>
        /// </description></item>
        /// <item><description><para><b>AiGatewayEIP</b>: The public IP address of an AI Gateway instance.</para>
        /// </description></item>
        /// <item><description><para><b>GaEIP</b>: The EIP of a Global Accelerator (GA) instance.</para>
        /// </description></item>
        /// <item><description><para><b>SwasEIP</b>: The public IP address of a Simple Application Server instance.</para>
        /// </description></item>
        /// <item><description><para><b>EcdEIP</b>: The public IP address of an Elastic Desktop Service (ECD) instance.</para>
        /// </description></item>
        /// <item><description><para><b>BastionHostIP</b>: The IP address of a bastion host.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify a value for at least one of the following parameters: <c>IpaddrList</c>, <c>RegionList</c>, and <c>ResourceTypeList</c>.</para>
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
