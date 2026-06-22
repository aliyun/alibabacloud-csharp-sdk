// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about assets protected by Cloud Firewall.</para>
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetListResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetListResponseBodyAssets : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <remarks>
            /// <para>The primary account of the Cloud Firewall member account.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>158039427902****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the bound asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdrjrxzt78****</para>
            /// </summary>
            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the bound asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance01</para>
            /// </summary>
            [NameInMap("BindInstanceName")]
            [Validation(Required=false)]
            public string BindInstanceName { get; set; }

            /// <summary>
            /// <para>The time when Cloud Firewall discovered the asset. Time format: YYYY-MM-DD HH:mm:ss.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-28 10:29:58</para>
            /// </summary>
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }

            /// <summary>
            /// <para>The public IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// <para>The private IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The IP address version of the asset protected by Cloud Firewall.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>4</b>: Indicates an IPv4 address.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: Indicates an IPv6 address.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            /// <summary>
            /// <para>The outbound traffic in the last 7 days.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Last7DayOutTrafficBytes")]
            [Validation(Required=false)]
            public long? Last7DayOutTrafficBytes { get; set; }

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
            /// <para>The instance name of the asset protected by Cloud Firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The remarks of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>REGION_NOT_SUPPORT</b>: Region not supported.</description></item>
            /// <item><description><b>NETWORK_NOT_SUPPORT</b>: Network not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGION_NOT_SUPPORT</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The firewall status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>open</b>: Protected.</description></item>
            /// <item><description><b>opening</b>: Protection enabling.</description></item>
            /// <item><description><b>closed</b>: Not protected.</description></item>
            /// <item><description><b>closing</b>: Protection disabling.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("ProtectStatus")]
            [Validation(Required=false)]
            public string ProtectStatus { get; set; }

            /// <summary>
            /// <para>The region ID of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>Indicates whether the region of the asset supports enabling Cloud Firewall protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: Supported.</description></item>
            /// <item><description><b>disable</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The asset instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdrjrxzt78****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

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
            /// <para>The risk level of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>low</b>: Low risk.</para>
            /// </description></item>
            /// <item><description><para><b>middle</b>: Medium risk.</para>
            /// </description></item>
            /// <item><description><para><b>hight</b>: High risk.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only when the value of UserType is free.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>The status of data leakage detection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("SensitiveDataStatus")]
            [Validation(Required=false)]
            public string SensitiveDataStatus { get; set; }

            /// <summary>
            /// <para>The security group policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pass</b>: Delivered.</description></item>
            /// <item><description><b>block</b>: Not delivered.</description></item>
            /// <item><description><b>unsupport</b>: Not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

            /// <summary>
            /// <para>The last security group status detection time, in timestamp format. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615082937</para>
            /// </summary>
            [NameInMap("SgStatusTime")]
            [Validation(Required=false)]
            public long? SgStatusTime { get; set; }

            /// <summary>
            /// <para>The traffic diversion support status of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: Traffic diversion supported.</description></item>
            /// <item><description><b>disable</b>: Traffic diversion not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("SyncStatus")]
            [Validation(Required=false)]
            public string SyncStatus { get; set; }

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

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of assets protected by Cloud Firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
