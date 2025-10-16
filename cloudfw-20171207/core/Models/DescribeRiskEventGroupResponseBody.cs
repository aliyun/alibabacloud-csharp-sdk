// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventGroupResponseBody : TeaModel {
        /// <summary>
        /// <para>An array that consists of the details of the intrusion events.</para>
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
            /// <para>The attack type of the intrusion event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: suspicious connection</description></item>
            /// <item><description><b>2</b>: command execution</description></item>
            /// <item><description><b>3</b>: brute-force attack</description></item>
            /// <item><description><b>4</b>: scanning</description></item>
            /// <item><description><b>5</b>: others</description></item>
            /// <item><description><b>6</b>: information leak</description></item>
            /// <item><description><b>7</b>: DoS attack</description></item>
            /// <item><description><b>8</b>: buffer overflow attack</description></item>
            /// <item><description><b>9</b>: web attack</description></item>
            /// <item><description><b>10</b>: trojan backdoor</description></item>
            /// <item><description><b>11</b>: computer worm</description></item>
            /// <item><description><b>12</b>: mining</description></item>
            /// <item><description><b>13</b>: reverse shell</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public int? AttackType { get; set; }

            /// <summary>
            /// <para>The description of the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Path traversal attacks are detected in the web access requests over HTTP.</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The direction of the traffic for the intrusion event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>in</b>: inbound</description></item>
            /// <item><description><b>out</b>: outbound</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>in</para>
            /// </summary>
            [NameInMap("Direction")]
            [Validation(Required=false)]
            public string Direction { get; set; }

            /// <summary>
            /// <para>The destination IP address that is included in the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The number of intrusion events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("EventCount")]
            [Validation(Required=false)]
            public int? EventCount { get; set; }

            /// <summary>
            /// <para>The ID of the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2b58efae-4c4b-4d96-9544-a586fb1f****</para>
            /// </summary>
            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            /// <summary>
            /// <para>The name of the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Path traversal attack</para>
            /// </summary>
            [NameInMap("EventName")]
            [Validation(Required=false)]
            public string EventName { get; set; }

            /// <summary>
            /// <para>The time when the intrusion event was first detected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408189</para>
            /// </summary>
            [NameInMap("FirstEventTime")]
            [Validation(Required=false)]
            public int? FirstEventTime { get; set; }

            /// <summary>
            /// <para>The geographical information about the IP address. The value is a struct that contains the following parameters: <b>CityId</b>, <b>CityName</b>, <b>CountryId</b>, and <b>CountryName</b>.\</para>
            /// <hr>
            /// </summary>
            [NameInMap("IPLocationInfo")]
            [Validation(Required=false)]
            public DescribeRiskEventGroupResponseBodyDataListIPLocationInfo IPLocationInfo { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListIPLocationInfo : TeaModel {
                /// <summary>
                /// <para>The ID of the city to which the IP address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>510100</para>
                /// </summary>
                [NameInMap("CityId")]
                [Validation(Required=false)]
                public string CityId { get; set; }

                /// <summary>
                /// <para>The name of the city to which the IP address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Chengdu, Sichuan Province</para>
                /// </summary>
                [NameInMap("CityName")]
                [Validation(Required=false)]
                public string CityName { get; set; }

                /// <summary>
                /// <para>The ID of the country to which the IP address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CN</para>
                /// </summary>
                [NameInMap("CountryId")]
                [Validation(Required=false)]
                public string CountryId { get; set; }

                /// <summary>
                /// <para>The name of the country to which the IP address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>China</para>
                /// </summary>
                [NameInMap("CountryName")]
                [Validation(Required=false)]
                public string CountryName { get; set; }

            }

            /// <summary>
            /// <para>The time when the intrusion event was last detected. The value is a UNIX timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1534408267</para>
            /// </summary>
            [NameInMap("LastEventTime")]
            [Validation(Required=false)]
            public int? LastEventTime { get; set; }

            /// <summary>
            /// <para>The information about the private IP address in the intrusion event. The value is an array that contains the following parameters: <b>RegionNo</b>, <b>ResourceInstanceId</b>, <b>ResourceInstanceName</b>, and <b>ResourcePrivateIP</b>.\</para>
            /// <hr>
            /// </summary>
            [NameInMap("ResourcePrivateIPList")]
            [Validation(Required=false)]
            public List<DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList> ResourcePrivateIPList { get; set; }
            public class DescribeRiskEventGroupResponseBodyDataListResourcePrivateIPList : TeaModel {
                /// <summary>
                /// <para>The ID of the region to which the private IP address belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <para>The ID of the instance that uses the private IP address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>i-wz92jf4scg2zb74p****</para>
                /// </summary>
                [NameInMap("ResourceInstanceId")]
                [Validation(Required=false)]
                public string ResourceInstanceId { get; set; }

                /// <summary>
                /// <para>The name of the instance that uses the private IP address.</para>
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
            /// <para>The type of the public IP address in the intrusion event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>EIP</b>: the elastic IP address (EIP)</description></item>
            /// <item><description><b>EcsPublicIP</b>: the public IP address of an Elastic Compute Service (ECS) instance</description></item>
            /// <item><description><b>EcsEIP</b>: the EIP of an ECS instance</description></item>
            /// <item><description><b>NatPublicIP</b>: the public IP address of a NAT gateway</description></item>
            /// <item><description><b>NatEIP</b>: the EIP of a NAT gateway</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>EcsPublicIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ID of the rule that is used to detect the intrusion event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1000****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The status of the firewall. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: alerting</description></item>
            /// <item><description><b>2</b>: blocking</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("RuleResult")]
            [Validation(Required=false)]
            public int? RuleResult { get; set; }

            /// <summary>
            /// <para>The module of the rule that is used to detect the intrusion event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: basic protection</description></item>
            /// <item><description><b>2</b>: virtual patching</description></item>
            /// <item><description><b>4</b>: threat intelligence</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("RuleSource")]
            [Validation(Required=false)]
            public int? RuleSource { get; set; }

            /// <summary>
            /// <para>The source IP address that is included in the intrusion event.</para>
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
            /// <para>The tag added to the source IP address. The tag helps identify whether the source IP address is a back-to-origin IP address for a cloud service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>WAF Back-to-origin Address</para>
            /// </summary>
            [NameInMap("SrcIPTag")]
            [Validation(Required=false)]
            [Obsolete]
            public string SrcIPTag { get; set; }

            [NameInMap("SrcIPTags")]
            [Validation(Required=false)]
            public List<string> SrcIPTags { get; set; }

            /// <summary>
            /// <para>An array that consists of the source private IP addresses in the intrusion event.</para>
            /// </summary>
            [NameInMap("SrcPrivateIPList")]
            [Validation(Required=false)]
            public List<string> SrcPrivateIPList { get; set; }

            /// <summary>
            /// <para>The tag added to the threat intelligence that is provided for major events.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Threat intelligence provided for major events</para>
            /// </summary>
            [NameInMap("Tag")]
            [Validation(Required=false)]
            public string Tag { get; set; }

            /// <summary>
            /// <para>The information about the destination VPC of the intrusion event. The value is a struct that contains the following parameters: <b>EcsInstanceId</b>, <b>EcsInstanceName</b>, <b>NetworkInstanceId</b>, <b>NetworkInstanceName</b>, and <b>RegionNo</b>.\</para>
            /// <hr>
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
                /// <para>The ID of the region in which the destination VPC resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The information about the source VPC of the intrusion event. The value is a struct that contains the following parameters: <b>EcsInstanceId</b>, <b>EcsInstanceName</b>, <b>NetworkInstanceId</b>, <b>NetworkInstanceName</b>, and <b>RegionNo</b>.\</para>
            /// <hr>
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
                /// <para>The ID of the region in which the source VPC resides.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

            }

            /// <summary>
            /// <para>The risk level of the intrusion event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: low</description></item>
            /// <item><description><b>2</b>: medium</description></item>
            /// <item><description><b>3</b>: high</description></item>
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
