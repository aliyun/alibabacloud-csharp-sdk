// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo20220530.Models
{
    public class GetElasticNetworkInterfaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public GetElasticNetworkInterfaceResponseBodyContent Content { get; set; }
        public class GetElasticNetworkInterfaceResponseBodyContent : TeaModel {
            /// <summary>
            /// <para>The time when the data address was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-13 12:51:41</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The instance description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>terraform-example</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>Lingjun Elastic Network Interface ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>leni-1234****</para>
            /// </summary>
            [NameInMap("ElasticNetworkInterfaceId")]
            [Validation(Required=false)]
            public string ElasticNetworkInterfaceId { get; set; }

            /// <summary>
            /// <para>Whether to enable the jumboFrame capability</para>
            /// 
            /// <b>Example:</b>
            /// <para>True</para>
            /// </summary>
            [NameInMap("EnableJumboFrame")]
            [Validation(Required=false)]
            public bool? EnableJumboFrame { get; set; }

            /// <summary>
            /// <para>vswitch gateway address</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.****</para>
            /// </summary>
            [NameInMap("Gateway")]
            [Validation(Required=false)]
            public string Gateway { get; set; }

            /// <summary>
            /// <para>The time when the agent was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-01-13 12:51:41</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>Elastic Network Interface IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>203.107.****</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>IPV6 address</para>
            /// </summary>
            [NameInMap("Ipv6Addresses")]
            [Validation(Required=false)]
            public List<GetElasticNetworkInterfaceResponseBodyContentIpv6Addresses> Ipv6Addresses { get; set; }
            public class GetElasticNetworkInterfaceResponseBodyContentIpv6Addresses : TeaModel {
                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Lingjun Elastic Network Interface ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>leni-1234****</para>
                /// </summary>
                [NameInMap("ElasticNetworkInterfaceId")]
                [Validation(Required=false)]
                public string ElasticNetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1585816811000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the cluster was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1549012834000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>IPV6 unique identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-sg3xabeq</para>
                /// </summary>
                [NameInMap("IpName")]
                [Validation(Required=false)]
                public string IpName { get; set; }

                /// <summary>
                /// <para>IPV6 address</para>
                /// 
                /// <b>Example:</b>
                /// <para>2408:4005:3aa:1000:470d:66fb:56a5:****</para>
                /// </summary>
                [NameInMap("Ipv6Address")]
                [Validation(Required=false)]
                public string Ipv6Address { get; set; }

                /// <summary>
                /// <para>The error message. (If the instance is in the Exception state, the exception cause is prompted.)</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>mac address</para>
            /// 
            /// <b>Example:</b>
            /// <para>00:22:6D:97:<b>:</b></para>
            /// </summary>
            [NameInMap("Mac")]
            [Validation(Required=false)]
            public string Mac { get; set; }

            /// <summary>
            /// <para>vswitch mask bits</para>
            /// 
            /// <b>Example:</b>
            /// <para>24</para>
            /// </summary>
            [NameInMap("Mask")]
            [Validation(Required=false)]
            public string Mask { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>Lingjun Node ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>e01-cn-lbj3aej****</para>
            /// </summary>
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }

            /// <summary>
            /// <para>Secondary private IP address</para>
            /// </summary>
            [NameInMap("PrivateIpAddresses")]
            [Validation(Required=false)]
            public List<GetElasticNetworkInterfaceResponseBodyContentPrivateIpAddresses> PrivateIpAddresses { get; set; }
            public class GetElasticNetworkInterfaceResponseBodyContentPrivateIpAddresses : TeaModel {
                /// <summary>
                /// <para>The instance description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Description</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>Lingjun Elastic Network Interface ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>leni-1234****</para>
                /// </summary>
                [NameInMap("ElasticNetworkInterfaceId")]
                [Validation(Required=false)]
                public string ElasticNetworkInterfaceId { get; set; }

                /// <summary>
                /// <para>The time when the data address was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672971789000</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <para>The time when the cluster was updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1672971789000</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <para>Lingjun Elastic Network Interface Secondary Private IP Unique Identifier</para>
                /// 
                /// <b>Example:</b>
                /// <para>sip-ywz****</para>
                /// </summary>
                [NameInMap("IpName")]
                [Validation(Required=false)]
                public string IpName { get; set; }

                /// <summary>
                /// <para>The returned message.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Successful</para>
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                /// <summary>
                /// <para>Lingjun Elastic Network Interface secondary private IP address</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.****</para>
                /// </summary>
                [NameInMap("PrivateIpAddress")]
                [Validation(Required=false)]
                public string PrivateIpAddress { get; set; }

                /// <summary>
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-wulanchabu</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The status of the intervention entry. Valid value:</para>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>资源组实例ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-acfmzzka6bnjvbi</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-0jl5s4p4laalruk7****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The state of the private gateway.</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>Create Failed: the creation failure.</description></item>
            /// <item><description>Delete Failed: the that failed to be deleted.</description></item>
            /// <item><description>Executing</description></item>
            /// <item><description>Available</description></item>
            /// <item><description>Deleting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The details of the resource tags.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<GetElasticNetworkInterfaceResponseBodyContentTags> Tags { get; set; }
            public class GetElasticNetworkInterfaceResponseBodyContentTags : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testkey</para>
                /// </summary>
                [NameInMap("TagKey")]
                [Validation(Required=false)]
                public string TagKey { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>testValue</para>
                /// </summary>
                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            /// <summary>
            /// <para>NIC Type</para>
            /// <para>Valid value:</para>
            /// <list type="bullet">
            /// <item><description>CUSTOM: custom type.</description></item>
            /// <item><description>DEFAULT: system type.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The ID of the vSwitch.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf6u8473r84e9****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>VPC ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-j6ctp4n75306****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The zone ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-wulanchabu-b</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        /// <summary>
        /// <para>The return message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0901F411-28FA-5B9C-BAEE-7776463FF0DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
