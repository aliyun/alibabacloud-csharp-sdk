// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The IP version of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>4</b> (default): IPv4</para>
        /// </description></item>
        /// <item><description><para><b>6</b>: IPv6</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

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
        /// <para>The UID of the member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>Filters for assets discovered within a specific time window. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>discovered in 1 hour</b>: The asset was added within the last hour.</para>
        /// </description></item>
        /// <item><description><para><b>discovered in 1 day</b>: The asset was added within the last day.</para>
        /// </description></item>
        /// <item><description><para><b>discovered in 7 days</b>: The asset was added within the last 7 days.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>discovered in 1 hour</para>
        /// </summary>
        [NameInMap("NewResourceTag")]
        [Validation(Required=false)]
        public string NewResourceTag { get; set; }

        /// <summary>
        /// <para>Specifies whether to query information about outbound traffic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutStatistic")]
        [Validation(Required=false)]
        public string OutStatistic { get; set; }

        /// <summary>
        /// <para>The number of assets to return per page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of your Cloud Firewall instance.</para>
        /// <remarks>
        /// <para>For more information about the regions that Cloud Firewall supports, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The asset type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>BastionHostEgressIP</b>: The egress IP address of a Bastionhost instance.</para>
        /// </description></item>
        /// <item><description><para><b>BastionHostIngressIP</b>: The ingress IP address of a Bastionhost instance.</para>
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
        /// <item><description><para><b>SlbPublicIP</b>: The public IP address of a Server Load Balancer (SLB) or Classic Load Balancer (CLB) instance.</para>
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
        /// <item><description><para><b>EcdEIP</b>: The public IP address of a Wuying instance.</para>
        /// </description></item>
        /// <item><description><para><b>BastionHostIP</b>: The IP address of a Bastionhost instance.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EIP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The IP address or instance ID of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// <para>The status of the data leak detection feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("SensitiveStatus")]
        [Validation(Required=false)]
        public string SensitiveStatus { get; set; }

        /// <summary>
        /// <para>The status of the security group policy. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>pass</b>: The security group policy is enforced.</para>
        /// </description></item>
        /// <item><description><para><b>block</b>: The security group policy is not enforced.</para>
        /// </description></item>
        /// <item><description><para><b>unsupport</b>: The asset does not support security group policies.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, assets are queried regardless of the security group policy status.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("SgStatus")]
        [Validation(Required=false)]
        public string SgStatus { get; set; }

        /// <summary>
        /// <para>The protection status of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>open</b>: Protection is enabled.</para>
        /// </description></item>
        /// <item><description><para><b>opening</b>: Protection is being enabled.</para>
        /// </description></item>
        /// <item><description><para><b>closed</b>: Protection is disabled.</para>
        /// </description></item>
        /// <item><description><para><b>closing</b>: Protection is being disabled.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, assets are queried regardless of their protection status.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The type of the user. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>buy</b> (default): A user with a paid subscription.</para>
        /// </description></item>
        /// <item><description><para><b>free</b>: A user on the free tier.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>buy</para>
        /// </summary>
        [NameInMap("UserType")]
        [Validation(Required=false)]
        public string UserType { get; set; }

    }

}
