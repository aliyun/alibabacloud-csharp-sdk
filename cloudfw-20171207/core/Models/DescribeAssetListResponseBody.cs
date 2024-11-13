// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeAssetListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the assets that are protected by Cloud Firewall.</para>
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeAssetListResponseBodyAssets> Assets { get; set; }
        public class DescribeAssetListResponseBodyAssets : TeaModel {
            /// <summary>
            /// <para>The UID of the Alibaba Cloud account.</para>
            /// <remarks>
            /// <para> The value of this parameter indicates the management account to which the member is added.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>158039427902****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The ID of the cloud resource with which the asset is associated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-8vbdrjrxzt78****</para>
            /// </summary>
            [NameInMap("BindInstanceId")]
            [Validation(Required=false)]
            public string BindInstanceId { get; set; }

            /// <summary>
            /// <para>The instance name of the asset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance01</para>
            /// </summary>
            [NameInMap("BindInstanceName")]
            [Validation(Required=false)]
            public string BindInstanceName { get; set; }

            /// <summary>
            /// <para>The timestamp when the asset is added to Cloud Firewall.</para>
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
            /// <para>The internal IP address of the server.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.XX.XX</para>
            /// </summary>
            [NameInMap("IntranetAddress")]
            [Validation(Required=false)]
            public string IntranetAddress { get; set; }

            /// <summary>
            /// <para>The IP version of the asset that is protected by Cloud Firewall.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>4</b>: IPv4</description></item>
            /// <item><description><b>6</b>: IPv6</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("IpVersion")]
            [Validation(Required=false)]
            public int? IpVersion { get; set; }

            [NameInMap("Last7DayOutTrafficBytes")]
            [Validation(Required=false)]
            public long? Last7DayOutTrafficBytes { get; set; }

            /// <summary>
            /// <para>The UID of the member.</para>
            /// 
            /// <b>Example:</b>
            /// <para>258039427902****</para>
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public long? MemberUid { get; set; }

            /// <summary>
            /// <para>The instance name of the asset that is protected by Cloud Firewall.</para>
            /// 
            /// <b>Example:</b>
            /// <para>instance01</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

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
            /// <para>The remarks of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>REGION_NOT_SUPPORT</b>: The region is not supported.</description></item>
            /// <item><description><b>NETWORK_NOT_SUPPORT</b>: The network is not supported.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>REGION_NOT_SUPPORT</para>
            /// </summary>
            [NameInMap("Note")]
            [Validation(Required=false)]
            public string Note { get; set; }

            /// <summary>
            /// <para>The status of the firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>open</b>: enabled.</description></item>
            /// <item><description><b>opening</b>: being enabled.</description></item>
            /// <item><description><b>closed</b>: disabled.</description></item>
            /// <item><description><b>closing</b>: being disabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>open</para>
            /// </summary>
            [NameInMap("ProtectStatus")]
            [Validation(Required=false)]
            public string ProtectStatus { get; set; }

            /// <summary>
            /// <para>The ID of the region in which the asset resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionID")]
            [Validation(Required=false)]
            public string RegionID { get; set; }

            /// <summary>
            /// <para>Indicates whether the firewall is supported in the region in which the asset resides. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: yes</description></item>
            /// <item><description><b>disable</b>: no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enable</para>
            /// </summary>
            [NameInMap("RegionStatus")]
            [Validation(Required=false)]
            public string RegionStatus { get; set; }

            /// <summary>
            /// <para>The instance ID of the asset.</para>
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
            /// <item><description><b>BastionHostEgressIP</b>: the egress IP address of a bastion host</description></item>
            /// <item><description><b>BastionHostIngressIP</b>: the ingress IP address of a bastion host</description></item>
            /// <item><description><b>EcsEIP</b>: the elastic IP address (EIP) of an Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>EcsPublicIP</b>: the public IP address of an ECS instance</description></item>
            /// <item><description><b>EIP</b>: the EIP</description></item>
            /// <item><description><b>EniEIP</b>: the EIP of an elastic network interface (ENI)</description></item>
            /// <item><description><b>NatEIP</b>: the EIP of a NAT gateway</description></item>
            /// <item><description><b>SlbEIP</b>: the EIP of a Server Load Balancer (SLB) instance</description></item>
            /// <item><description><b>SlbPublicIP</b>: the public IP address of an SLB instance</description></item>
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
            /// <para>The risk level of the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>low</b>: low</description></item>
            /// <item><description><b>middle</b>: medium</description></item>
            /// <item><description><b>hight</b>: high</description></item>
            /// </list>
            /// <remarks>
            /// <para> The value of this parameter is returned only when the UserType parameter is set to free.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>low</para>
            /// </summary>
            [NameInMap("RiskLevel")]
            [Validation(Required=false)]
            public string RiskLevel { get; set; }

            [NameInMap("SensitiveDataStatus")]
            [Validation(Required=false)]
            public string SensitiveDataStatus { get; set; }

            /// <summary>
            /// <para>The status of the security group policy. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>pass</b>: applied</description></item>
            /// <item><description><b>block</b>: not applied</description></item>
            /// <item><description><b>unsupport</b>: unsupported</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>block</para>
            /// </summary>
            [NameInMap("SgStatus")]
            [Validation(Required=false)]
            public string SgStatus { get; set; }

            /// <summary>
            /// <para>The time when the status of the security group was last checked. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1615082937</para>
            /// </summary>
            [NameInMap("SgStatusTime")]
            [Validation(Required=false)]
            public long? SgStatusTime { get; set; }

            /// <summary>
            /// <para>Indicates whether traffic redirection is supported for the asset. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enable</b>: yes</description></item>
            /// <item><description><b>disable</b>: no</description></item>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CBF1E9B7-D6A0-4E9E-AD3E-2B47E6C2837D</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of the assets that are protected by Cloud Firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
