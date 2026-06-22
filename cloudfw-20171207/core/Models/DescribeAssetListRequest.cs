// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page in a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The IP version of the assets protected by Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b> (default): IPv4.</description></item>
        /// <item><description><b>6</b>: IPv6.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language type of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b> (default): Chinese.</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The UID of the Cloud Firewall member account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The time when the asset was discovered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>discovered in 1 hour</b>: The asset was discovered within 1 hour.</description></item>
        /// <item><description><b>discovered in 1 day</b>: The asset was discovered within 1 day.</description></item>
        /// <item><description><b>discovered in 7 days</b>: The asset was discovered within 7 days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>discovered in 1 hour</para>
        /// </summary>
        [NameInMap("NewResourceTag")]
        [Validation(Required=false)]
        public string NewResourceTag { get; set; }

        /// <summary>
        /// <para>Specifies whether to query outbound traffic information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutStatistic")]
        [Validation(Required=false)]
        public string OutStatistic { get; set; }

        /// <summary>
        /// <para>The number of Cloud Firewall-protected assets to display on each page in a paginated query.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the Cloud Firewall.</para>
        /// <remarks>
        /// <para>For more information about regions supported by Cloud Firewall, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
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
        /// <item><description><b>BastionHostEgressIP</b>: Bastion host egress IP.</description></item>
        /// <item><description><b>BastionHostIngressIP</b>: Bastion host ingress IP.</description></item>
        /// <item><description><b>EcsEIP</b>: ECS EIP.</description></item>
        /// <item><description><b>EcsPublicIP</b>: ECS public IP.</description></item>
        /// <item><description><b>EIP</b>: Elastic IP address.</description></item>
        /// <item><description><b>EniEIP</b>: Elastic network interface EIP.</description></item>
        /// <item><description><b>NatEIP</b>: NAT EIP.</description></item>
        /// <item><description><b>SlbEIP</b>: SLB EIP (CLB EIP).</description></item>
        /// <item><description><b>SlbPublicIP</b>: SLB public IP (CLB public IP).</description></item>
        /// <item><description><b>NatPublicIP</b>: NAT public IP.</description></item>
        /// <item><description><b>HAVIP</b>: High-availability virtual IP.</description></item>
        /// <item><description><b>NlbEIP</b>: NLB EIP.</description></item>
        /// <item><description><b>ApiGatewayEIP</b>: API Gateway public IP.</description></item>
        /// <item><description><b>AlbEIP</b>: ALB EIP.</description></item>
        /// <item><description><b>AiGatewayEIP</b>: AI Gateway public IP.</description></item>
        /// <item><description><b>GaEIP</b>: GA EIP.</description></item>
        /// <item><description><b>SwasEIP</b>: Simple Application Server public IP.</description></item>
        /// <item><description><b>EcdEIP</b>: Elastic Desktop Service public IP.</description></item>
        /// <item><description><b>BastionHostIP</b>: Bastion host IP.</description></item>
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
        /// <para>The status of data leakage detection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("SensitiveStatus")]
        [Validation(Required=false)]
        public string SensitiveStatus { get; set; }

        /// <summary>
        /// <para>The security group policy status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>pass</b>: Delivered.</description></item>
        /// <item><description><b>block</b>: Not delivered.</description></item>
        /// <item><description><b>unsupport</b>: Not supported.<remarks>
        /// <para>If this parameter is not set, all security group policy statuses are queried.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("SgStatus")]
        [Validation(Required=false)]
        public string SgStatus { get; set; }

        /// <summary>
        /// <para>The Cloud Firewall status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: Protected.</description></item>
        /// <item><description><b>opening</b>: Protection enabling.</description></item>
        /// <item><description><b>closed</b>: Not protected.</description></item>
        /// <item><description><b>closing</b>: Protection disabling.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not set, all firewall statuses are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>open</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <term><b>Obsolete</b></term>
        /// 
        /// <summary>
        /// <para>This parameter is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eip</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        [Obsolete]
        public string Type { get; set; }

        /// <summary>
        /// <para>The user type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>buy</b> (default): Paid user.</description></item>
        /// <item><description><b>free</b>: Free user.</description></item>
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
