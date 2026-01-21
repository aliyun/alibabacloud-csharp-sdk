// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class PutEnableFwSwitchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The IP addresses.</para>
        /// <remarks>
        /// <para>You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;192.0.X.X&quot;,&quot;192.0.X.X&quot;]</para>
        /// </summary>
        [NameInMap("IpaddrList")]
        [Validation(Required=false)]
        public List<string> IpaddrList { get; set; }

        /// <summary>
        /// <para>The language of the content within the response.</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1234</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public string MemberUid { get; set; }

        /// <summary>
        /// <para>The regions.</para>
        /// <remarks>
        /// <para>You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;cn-hangzhou&quot;,&quot;cn-shanghai&quot;]</para>
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<string> RegionList { get; set; }

        /// <summary>
        /// <para>The types of the assets.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>BastionHostIP: the egress IP address of a bastion host</description></item>
        /// <item><description>BastionHostIngressIP: the ingress IP address of a bastion host</description></item>
        /// <item><description>EcsEIP: the elastic IP address (EIP) of an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description>EcsPublicIP: the public IP address of an ECS instance</description></item>
        /// <item><description>EIP: the EIP</description></item>
        /// <item><description>EniEIP: the EIP of an elastic network interface (ENI)</description></item>
        /// <item><description>NatEIP: the EIP of a NAT gateway</description></item>
        /// <item><description>SlbEIP: the EIP of a Server Load Balancer (SLB) instance</description></item>
        /// <item><description>SlbPublicIP: the public IP address of an SLB instance</description></item>
        /// <item><description>NatPublicIP: the public IP address of a NAT gateway</description></item>
        /// <item><description>HAVIP: the high-availability virtual IP address (HAVIP)</description></item>
        /// </list>
        /// <remarks>
        /// <para>You must specify at least one of the IpaddrList, RegionList, and ResourceTypeList parameters.</para>
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
        /// <para>192.0.X.X</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        [Obsolete]
        public string SourceIp { get; set; }

    }

}
