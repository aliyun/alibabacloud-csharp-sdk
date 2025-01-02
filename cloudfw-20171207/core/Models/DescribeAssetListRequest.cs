// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListRequest : TeaModel {
        /// <summary>
        /// <para>The page number. Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public string CurrentPage { get; set; }

        /// <summary>
        /// <para>The IP version of the asset that is protected by Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>4</b>: IPv4 (default)</description></item>
        /// <item><description><b>6</b>: IPv6</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("IpVersion")]
        [Validation(Required=false)]
        public string IpVersion { get; set; }

        /// <summary>
        /// <para>The language of the content within the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese (default)</description></item>
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
        /// <para>The UID of the member that is added to Cloud Firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>258039427902****</para>
        /// </summary>
        [NameInMap("MemberUid")]
        [Validation(Required=false)]
        public long? MemberUid { get; set; }

        /// <summary>
        /// <para>The time when the asset was added. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>discovered in 1 hour</b>: within one hour.</description></item>
        /// <item><description><b>discovered in 1 day</b>: within one day.</description></item>
        /// <item><description><b>discovered in 7 days</b>: within seven days.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>discovered in 1 hour</para>
        /// </summary>
        [NameInMap("NewResourceTag")]
        [Validation(Required=false)]
        public string NewResourceTag { get; set; }

        /// <summary>
        /// <para>Whether to query external traffic information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OutStatistic")]
        [Validation(Required=false)]
        public string OutStatistic { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 50.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public string PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of your Cloud Firewall.</para>
        /// <remarks>
        /// <para>For more information about the regions, see <a href="https://help.aliyun.com/document_detail/195657.html">Supported regions</a>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionNo")]
        [Validation(Required=false)]
        public string RegionNo { get; set; }

        /// <summary>
        /// <para>The type of the asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>BastionHostEgressIP</b>: the egress IP address of a bastion host</description></item>
        /// <item><description><b>BastionHostIngressIP</b>: the ingress IP address of a bastion host</description></item>
        /// <item><description><b>EcsEIP</b>: the elastic IP address (EIP) of an Elastic Compute Service (ECS) instance</description></item>
        /// <item><description><b>EcsPublicIP</b>: the public IP address of an ECS instance</description></item>
        /// <item><description><b>EIP</b>: the EIP</description></item>
        /// <item><description><b>EniEIP</b>: the EIP of an elastic network interface (ENI)</description></item>
        /// <item><description><b>NatEIP</b>: the EIP of a NAT gateway</description></item>
        /// <item><description><b>SlbEIP</b>: the EIP of a Server Load Balancer (SLB) instance or a Classic Load Balancer (CLB) instance</description></item>
        /// <item><description><b>SlbPublicIP</b>: the public IP address of an SLB instance or a CLB instance</description></item>
        /// <item><description><b>NatPublicIP</b>: the public IP address of a NAT gateway</description></item>
        /// <item><description><b>HAVIP</b>: the high-availability virtual IP address (HAVIP)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EIP</para>
        /// </summary>
        [NameInMap("ResourceType")]
        [Validation(Required=false)]
        public string ResourceType { get; set; }

        /// <summary>
        /// <para>The instance ID or IP address of the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.0.XX.XX</para>
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// <para>Data leakage detection activation status.</para>
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
        /// <item><description><b>pass</b>: delivered</description></item>
        /// <item><description><b>block</b>: undelivered</description></item>
        /// <item><description><b>unsupport</b>: unsupported</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the assets on which security group policies in all states take effect are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("SgStatus")]
        [Validation(Required=false)]
        public string SgStatus { get; set; }

        /// <summary>
        /// <para>The status of the firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>open</b>: The firewall is enabled.</description></item>
        /// <item><description><b>opening</b>: The firewall is being enabled.</description></item>
        /// <item><description><b>closed</b>: The firewall is disabled.</description></item>
        /// <item><description><b>closing</b>: The firewall is being disabled.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, the assets that are configured for firewalls in all states are queried.</para>
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
        /// <para>The edition of Cloud Firewall. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>buy</b>: a paid edition (default)</description></item>
        /// <item><description><b>free</b>: Free Edition</description></item>
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
