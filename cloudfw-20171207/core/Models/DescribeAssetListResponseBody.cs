// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the assets protected by Cloud Firewall.</para>
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetListResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetListResponseBodyAssets : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <remarks>
            /// <para>The UID of the management account to which the member account belongs.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>158039427902****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the instance that is associated with the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdrjrxzt78****</para>
            /// </summary>
            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            /// <summary>
            /// <para>The name of the instance that is associated with the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance01</para>
            /// </summary>
            [NameInMap("BindInstanceName")]
            [Validation(Required=false)]
            public string BindInstanceName { get; set; }

            /// <summary>
            /// <para>The time when the asset was discovered by Cloud Firewall, in YYYY-MM-DD HH:mm:ss format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-02-28 10:29:58</para>
            /// </summary>
            [NameInMap("CreateTimeStamp")]
            [Validation(Required=false)]
            public string CreateTimeStamp { get; set; }

            /// <summary>
            /// <para>The public IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("InternetAddress")]
            [Validation(Required=false)]
            public string InternetAddress { get; set; }

            /// <summary>
            /// <para>The private IP address of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The IP version of the asset. Valid values:</para>
            /// <para>Values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>4</b>: An IPv4 address.</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: An IPv6 address.</para>
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
            /// <para>The amount of outbound traffic from the asset in the last 7 days, in bytes.</para>
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
            /// <para>The name of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>A tag that indicates how recently the asset was discovered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>discovered in 1 hour</b>: The asset was discovered within the last hour.</para>
            /// </description></item>
            /// <item><description><para><b>discovered in 1 day</b>: The asset was discovered within the last 24 hours.</para>
            /// </description></item>
            /// <item><description><para><b>discovered in 7 days</b>: The asset was discovered within the last 7 days.</para>
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
            /// <para>Additional information about the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>REGION_NOT_SUPPORT</b>: The region is not supported.</para>
            /// </description></item>
            /// <item><description><para><b>NETWORK_NOT_SUPPORT</b>: The network type is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGION_NOT_SUPPORT</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The protection status of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>open</b>: Protected.</para>
            /// </description></item>
            /// <item><description><para><b>opening</b>: Enabling protection.</para>
            /// </description></item>
            /// <item><description><para><b>closed</b>: Not protected.</para>
            /// </description></item>
            /// <item><description><para><b>closing</b>: Disabling protection.</para>
            /// </description></item>
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
            /// <para>Indicates whether the asset\&quot;s region supports Cloud Firewall protection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: Supported.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The ID of the asset instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdrjrxzt78****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The type of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>BastionHostEgressIP</b>: The egress IP address of a bastion host.</para>
            /// </description></item>
            /// <item><description><para><b>BastionHostIngressIP</b>: The ingress IP address of a bastion host.</para>
            /// </description></item>
            /// <item><description><para><b>EcsEIP</b>: The EIP of an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>EcsPublicIP</b>: The public IP address of an ECS instance.</para>
            /// </description></item>
            /// <item><description><para><b>EIP</b>: A standalone EIP.</para>
            /// </description></item>
            /// <item><description><para><b>EniEIP</b>: The EIP of an elastic network interface (ENI).</para>
            /// </description></item>
            /// <item><description><para><b>NatEIP</b>: The EIP of a NAT gateway.</para>
            /// </description></item>
            /// <item><description><para><b>SlbEIP</b>: The EIP of a Classic Load Balancer (CLB) instance.</para>
            /// </description></item>
            /// <item><description><para><b>SlbPublicIP</b>: The public IP address of a Classic Load Balancer (CLB) instance.</para>
            /// </description></item>
            /// <item><description><para><b>NatPublicIP</b>: The public IP address of a NAT gateway.</para>
            /// </description></item>
            /// <item><description><para><b>HAVIP</b>: A high-availability virtual IP (HAVIP).</para>
            /// </description></item>
            /// <item><description><para><b>NlbEIP</b>: The EIP of a Network Load Balancer (NLB) instance.</para>
            /// </description></item>
            /// <item><description><para><b>ApiGatewayEIP</b>: The EIP of an API Gateway instance.</para>
            /// </description></item>
            /// <item><description><para><b>AlbEIP</b>: The EIP of an Application Load Balancer (ALB) instance.</para>
            /// </description></item>
            /// <item><description><para><b>AiGatewayEIP</b>: The EIP of an AI Gateway instance.</para>
            /// </description></item>
            /// <item><description><para><b>GaEIP</b>: The EIP of a Global Accelerator (GA) instance.</para>
            /// </description></item>
            /// <item><description><para><b>SwasEIP</b>: The public IP address of a Simple Application Server instance.</para>
            /// </description></item>
            /// <item><description><para><b>EcdEIP</b>: The public IP address of an Elastic Desktop Service (EDS) instance.</para>
            /// </description></item>
            /// <item><description><para><b>BastionHostIP</b>: The IP address of a bastion host.</para>
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
            /// <para>The risk level of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>low</b>: Low risk.</para>
            /// </description></item>
            /// <item><description><para><b>middle</b>: Medium risk.</para>
            /// </description></item>
            /// <item><description><para><b>high</b>: High risk.</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>This parameter is returned only if the <c>UserType</c> parameter is set to <c>free</c>.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            /// <summary>
            /// <para>Indicates whether data leak prevention is enabled.</para>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("SensitiveDataStatus")]
            [Validation(Required=false)]
            public string SensitiveDataStatus { get; set; }

            /// <summary>
            /// <para>The status of the security group policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>pass</b>: The policy is applied.</para>
            /// </description></item>
            /// <item><description><para><b>block</b>: The policy is not applied.</para>
            /// </description></item>
            /// <item><description><para><b>unsupport</b>: Not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

            /// <summary>
            /// <para>The timestamp of the last security group status check. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615082937</para>
            /// </summary>
            [NameInMap("SgStatusTime")]
            [Validation(Required=false)]
            public long? SgStatusTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the asset supports traffic redirection. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>enable</b>: Traffic redirection is supported.</para>
            /// </description></item>
            /// <item><description><para><b>disable</b>: Traffic redirection is not supported.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("SyncStatus")]
            [Validation(Required=false)]
            public string SyncStatus { get; set; }

            /// <summary>
            /// <para>This parameter is deprecated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>eip</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
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
