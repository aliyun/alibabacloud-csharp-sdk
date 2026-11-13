// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of returned data.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeRiskEventGroupResponseBodyDataList> DataList { get; set; }
        public class DescribeRiskEventGroupResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The name of the attacked application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>MySql</para>
            /// </summary>
            [NameInMap("AttackApp")]
            [Validation(Required=false)]
            public string AttackApp { get; set; }

            /// <summary>
            /// <para>The attack type of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Abnormal connection.</description></item>
            /// <item><description><b>2</b>: Execute commands.</description></item>
            /// <item><description><b>3</b>: Brute-force attacks.</description></item>
            /// <item><description><b>4</b>: Scan.</description></item>
            /// <item><description><b>5</b>: Other.</description></item>
            /// <item><description><b>6</b>: Information leak.</description></item>
            /// <item><description><b>7</b>: DoS attack.</description></item>
            /// <item><description><b>8</b>: Overflow attack.</description></item>
            /// <item><description><b>9</b>: Web attack.</description></item>
            /// <item><description><b>10</b>: Trojan backdoor.</description></item>
            /// <item><description><b>11</b>: Virus and worm.</description></item>
            /// <item><description><b>12</b>: Mining behavior.</description></item>
            /// <item><description><b>13</b>: Reverse shell.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// <para>The description of the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>A directory traversal attack was detected in Web access for HTTP requests</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The traffic direction of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: Inbound.</description></item>
            /// <item><description><b>out</b>: Outbound.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The queried destination IP address. This indicates that the intrusion prevention event includes this destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The number of intrusion prevention events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// <para>The ID of the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2b58efae-4c4b-4d96-9544-a586fb1f****</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The name of the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Web Directory Traversal Attack</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The time when the intrusion event first occurred. The value is a UNIX timestamp accurate to seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408189</para>
            /// </summary>
            [NameInMap("FirstEventTime")]
            [Validation(Required=false)]
            public int? FirstEventTime { get; set; }

            /// <summary>
            /// <para>The IP geolocation information. The struct includes the <b>CityId</b>, <b>CityName</b>, <b>CountryId</b>, and <b>CountryName</b> parameters.<br><b>CityId</b> indicates the ID of the city to which the IP address belongs. <b>CityName</b> indicates the name of the city to which the IP address belongs. <b>CountryId</b> indicates the ID of the country to which the IP address belongs. <b>CountryName</b> indicates the name of the country to which the IP address belongs.</para>
            /// </summary>
            [NameInMap("IPLocationInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListIPLocationInfo IPLocationInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListIPLocationInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>510100</para>
                /// </summary>
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public string CityId { get; set; }

                /// <summary>
                /// <para>The name of the city.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chengdu</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The ID of the country.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryId")]
                [Validation(Required=false)]
                public string CountryId { get; set; }

                /// <summary>
                /// <para>The name of the country.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

            }

            /// <summary>
            /// <para>The time when the intrusion prevention event last occurred. The value is a UNIX timestamp accurate to seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408267</para>
            /// </summary>
            [NameInMap("LastEventTime")]
            [Validation(Required=false)]
            public int? LastEventTime { get; set; }

            /// <summary>
            /// <para>The private IP address information of the intrusion prevention event. The IP address information is returned as an array that includes the <b>RegionNo</b>, <b>ResourceInstanceId</b>, <b>ResourceInstanceName</b>, and <b>ResourcePrivateIP</b> parameters.<br><b>RegionNo</b> indicates instance ID of the region to which the IP address belongs. <b>ResourceInstanceId</b> indicates instance ID of the instance to which the IP address belongs. <b>ResourceInstanceName</b> indicates the name of the instance to which the IP address belongs. <b>ResourcePrivateIP</b> indicates the IP address.</para>
            /// </summary>
            [NameInMap("ResourcePrivateIPList")]
            [Validation(Required=false)]
            public List<DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList> ResourcePrivateIPList { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList : TeaModel {
                /// <summary>
                /// <para>The region ID. This parameter indicates the ID of the region to which the private IP address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz92jf4scg2zb74p****</para>
                /// </summary>
                [NameInMap("ResourceInstanceId")]
                [Validation(Required=false)]
                public string ResourceInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD-shenzhen-zy****</para>
                /// </summary>
                [NameInMap("ResourceInstanceName")]
                [Validation(Required=false)]
                public string ResourceInstanceName { get; set; }

                /// <summary>
                /// <para>The private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10.255.XX.XX</para>
                /// </summary>
                [NameInMap("ResourcePrivateIP")]
                [Validation(Required=false)]
                public string ResourcePrivateIP { get; set; }

            }

            /// <summary>
            /// <para>The public IP address type of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EIP</b>: Elastic IP address.</description></item>
            /// <item><description><b>EcsPublicIP</b>: The public IP addresses of Elastic Compute Service (ECS) instances.</description></item>
            /// <item><description><b>EcsEIP</b>: EIP of an ECS instance.</description></item>
            /// <item><description><b>NatPublicIP</b>: Public IP address of a NAT gateway.</description></item>
            /// <item><description><b>NatEIP</b>: EIP of a NAT gateway.</description></item>
            /// <item><description><b>SlbPublicIp</b>: Public IP address of an SLB instance.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the protection rule for the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The defense status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Alert.</description></item>
            /// <item><description><b>2</b>: Block.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// <para>The source of the detection rule for the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Basic protection.</description></item>
            /// <item><description><b>2</b>: Virtual Patches.</description></item>
            /// <item><description><b>4</b>: Threat intelligence.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public int? RuleSource { get; set; }

            /// <summary>
            /// <para>The queried source IP address. This indicates that the intrusion prevention event includes this source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The source IP address label, which serves as the identity indicating whether the IP address is one of the back-to-origin IP addresses of a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAF Back-to-origin Address</para>
            /// </summary>
            [NameInMap("SrcIPTag")]
            [Validation(Required=false)]
            [Obsolete]
            public string SrcIPTag { get; set; }

            /// <summary>
            /// <para>The list of IP address tags.</para>
            /// </summary>
            [NameInMap("SrcIPTags")]
            [Validation(Required=false)]
            public List<string> SrcIPTags { get; set; }

            /// <summary>
            /// <para>The list of source private IP addresses for the intrusion prevention event.</para>
            /// </summary>
            [NameInMap("SrcPrivateIPList")]
            [Validation(Required=false)]
            public List<string> SrcPrivateIPList { get; set; }

            /// <summary>
            /// <para>The label of intelligence tags for critical event protection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-tag</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The destination VPC information of the intrusion prevention event. The structure includes the <b>EcsInstanceId</b>, <b>EcsInstanceName</b>, <b>NetworkInstanceId</b>, <b>NetworkInstanceName</b>, and <b>RegionNo</b> parameters.<br><b>EcsInstanceId</b> indicates the instance ID of the ECS instance in the VPC. <b>EcsInstanceName</b> indicates the name of the ECS instance in the VPC. <b>NetworkInstanceId</b> indicates the instance ID of the VPC-connected instance. <b>NetworkInstanceName</b> indicates the name of the VPC-connected instance. <b>RegionNo</b> indicates the ID of the region to which the VPC-connected instance belongs.</para>
            /// </summary>
            [NameInMap("VpcDstInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcDstInfo VpcDstInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcDstInfo : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz92jf4scg2zb74p****</para>
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD-shenzhen-zy****</para>
                /// </summary>
                [NameInMap("EcsInstanceName")]
                [Validation(Required=false)]
                public string EcsInstanceName { get; set; }

                /// <summary>
                /// <para>The instance ID of the VPC-connected instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the VPC-connected instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC-SH-TX****</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The region ID. This parameter indicates the ID of the region to which the destination VPC-connected instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The source VPC information of the intrusion prevention event. The structure includes the <b>EcsInstanceId</b>, <b>EcsInstanceName</b>, <b>NetworkInstanceId</b>, <b>NetworkInstanceName</b>, and <b>RegionNo</b> parameters.<br><b>EcsInstanceId</b> indicates the instance ID of the ECS instance in the VPC. <b>EcsInstanceName</b> indicates the name of the ECS instance in the VPC. <b>NetworkInstanceId</b> indicates the instance ID of the VPC-connected instance. <b>NetworkInstanceName</b> indicates the name of the VPC-connected instance. <b>RegionNo</b> indicates the ID of the region to which the VPC-connected instance belongs.</para>
            /// </summary>
            [NameInMap("VpcSrcInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo VpcSrcInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo : TeaModel {
                /// <summary>
                /// <para>The instance ID of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz92jf4scg2zb74p****</para>
                /// </summary>
                [NameInMap("EcsInstanceId")]
                [Validation(Required=false)]
                public string EcsInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the ECS instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>LD-shenzhen-zy****</para>
                /// </summary>
                [NameInMap("EcsInstanceName")]
                [Validation(Required=false)]
                public string EcsInstanceName { get; set; }

                /// <summary>
                /// <para>The instance ID of the VPC-connected instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the VPC-connected instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC-SH-TX****</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The region ID. This parameter indicates the ID of the region to which the source VPC-connected instance belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The security level of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Low-risk.</description></item>
            /// <item><description><b>2</b>: Medium-risk.</description></item>
            /// <item><description><b>3</b>: High-risk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("VulLevel")]
            [Validation(Required=false)]
            public int? VulLevel { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B14757D0-4640-4B44-AC67-7F558FE7E6EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of risk events.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
