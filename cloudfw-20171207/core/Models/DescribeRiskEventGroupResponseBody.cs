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
            /// <para>The type of the attack. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: abnormal connection</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: command execution</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: brute-force attack</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: scan</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: other</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: information leakage</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: DoS attack</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: overflow attack</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: web attack</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: backdoor trojan</para>
            /// </description></item>
            /// <item><description><para><b>11</b>: virus or worm</para>
            /// </description></item>
            /// <item><description><para><b>12</b>: mining behavior</para>
            /// </description></item>
            /// <item><description><para><b>13</b>: reverse shell</para>
            /// </description></item>
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
            /// <item><description><para><b>in</b>: inbound</para>
            /// </description></item>
            /// <item><description><para><b>out</b>: outbound</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The destination IP address. The intrusion prevention event contains this destination IP address.</para>
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
            /// <para>The time when the intrusion event first occurred. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408189</para>
            /// </summary>
            [NameInMap("FirstEventTime")]
            [Validation(Required=false)]
            public int? FirstEventTime { get; set; }

            /// <summary>
            /// <para>The geolocation information of the IP address. This struct contains the <b>CityId</b>, <b>CityName</b>, <b>CountryId</b>, and <b>CountryName</b> parameters.<br>
            /// <b>CityId</b> indicates the city ID of the IP address. <b>CityName</b> indicates the city name of the IP address. <b>CountryId</b> indicates the country ID of the IP address. <b>CountryName</b> indicates the country name of the IP address.<br></para>
            /// </summary>
            [NameInMap("IPLocationInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListIPLocationInfo IPLocationInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListIPLocationInfo : TeaModel {
                /// <summary>
                /// <para>The city ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>510100</para>
                /// </summary>
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public string CityId { get; set; }

                /// <summary>
                /// <para>The city name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chengdu</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The country ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryId")]
                [Validation(Required=false)]
                public string CountryId { get; set; }

                /// <summary>
                /// <para>The country name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

            }

            /// <summary>
            /// <para>The time when the intrusion prevention event last occurred. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408267</para>
            /// </summary>
            [NameInMap("LastEventTime")]
            [Validation(Required=false)]
            public int? LastEventTime { get; set; }

            /// <summary>
            /// <para>The information about the private IP address in the intrusion prevention event. The value is an array that consists of the <b>RegionNo</b>, <b>ResourceInstanceId</b>, <b>ResourceInstanceName</b>, and <b>ResourcePrivateIP</b> parameters.<br>
            /// <b>RegionNo</b> indicates the region ID of the IP address. <b>ResourceInstanceId</b> indicates the ID of the instance to which the IP address belongs. <b>ResourceInstanceName</b> indicates the name of the instance to which the IP address belongs. <b>ResourcePrivateIP</b> indicates the IP address.<br></para>
            /// </summary>
            [NameInMap("ResourcePrivateIPList")]
            [Validation(Required=false)]
            public List<DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList> ResourcePrivateIPList { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList : TeaModel {
                /// <summary>
                /// <para>The region ID. This parameter indicates the region ID of the private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The ID of the instance.</para>
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
            /// <para>The type of the public IP address. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>EIP</b>: an elastic IP address (EIP)</para>
            /// </description></item>
            /// <item><description><para><b>EcsPublicIP</b>: an ECS public IP address</para>
            /// </description></item>
            /// <item><description><para><b>EcsEIP</b>: an ECS EIP</para>
            /// </description></item>
            /// <item><description><para><b>NatPublicIP</b>: a NAT public IP address</para>
            /// </description></item>
            /// <item><description><para><b>NatEIP</b>: a NAT EIP</para>
            /// </description></item>
            /// <item><description><para><b>SlbPublicIp</b>: an SLB public IP address</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the rule that is used to defend against the intrusion prevention event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The handling status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: Alert</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: Block</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// <para>The source of the rule that is used to detect the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: basic protection</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: virtual patching</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: threat intelligence</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public int? RuleSource { get; set; }

            /// <summary>
            /// <para>The source IP address. The intrusion prevention event contains this source IP address.</para>
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
            /// <para>The tag of the source IP address. This tag is used to identify whether the IP address is a back-to-origin IP address of an Alibaba Cloud service.</para>
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
            /// <para>The list of source private IP addresses in the intrusion prevention event.</para>
            /// </summary>
            [NameInMap("SrcPrivateIPList")]
            [Validation(Required=false)]
            public List<string> SrcPrivateIPList { get; set; }

            /// <summary>
            /// <para>The tag for major event support.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test-tag</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The information about the destination VPC of the intrusion prevention event. This struct contains the <b>EcsInstanceId</b>, <b>EcsInstanceName</b>, <b>NetworkInstanceId</b>, <b>NetworkInstanceName</b>, and <b>RegionNo</b> parameters.<br>
            /// <b>EcsInstanceId</b> indicates the ID of the ECS instance in the VPC. <b>EcsInstanceName</b> indicates the name of the ECS instance in the VPC. <b>NetworkInstanceId</b> indicates the ID of the VPC. <b>NetworkInstanceName</b> indicates the name of the VPC. <b>RegionNo</b> indicates the region ID of the VPC.<br></para>
            /// </summary>
            [NameInMap("VpcDstInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcDstInfo VpcDstInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcDstInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the ECS instance.</para>
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
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC-SH-TX****</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The region ID. This parameter indicates the region ID of the destination VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The information about the source VPC of the intrusion prevention event. This struct contains the <b>EcsInstanceId</b>, <b>EcsInstanceName</b>, <b>NetworkInstanceId</b>, <b>NetworkInstanceName</b>, and <b>RegionNo</b> parameters.<br>
            /// <b>EcsInstanceId</b> indicates the ID of the ECS instance in the VPC. <b>EcsInstanceName</b> indicates the name of the ECS instance in the VPC. <b>NetworkInstanceId</b> indicates the ID of the VPC. <b>NetworkInstanceName</b> indicates the name of the VPC. <b>RegionNo</b> indicates the region ID of the VPC.<br></para>
            /// </summary>
            [NameInMap("VpcSrcInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo VpcSrcInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListVpcSrcInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the ECS instance.</para>
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
                /// <para>The ID of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vpc-uf6e9a9zyokj2ywuo****</para>
                /// </summary>
                [NameInMap("NetworkInstanceId")]
                [Validation(Required=false)]
                public string NetworkInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>VPC-SH-TX****</para>
                /// </summary>
                [NameInMap("NetworkInstanceName")]
                [Validation(Required=false)]
                public string NetworkInstanceName { get; set; }

                /// <summary>
                /// <para>The region ID. This parameter indicates the region ID of the source VPC.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The risk level of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: low</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: medium</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: high</para>
            /// </description></item>
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
