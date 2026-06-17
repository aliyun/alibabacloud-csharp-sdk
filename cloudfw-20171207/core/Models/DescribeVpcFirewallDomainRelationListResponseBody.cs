// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallDomainRelationListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of data entries.</para>
        /// </summary>
        [NameInMap("DataList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallDomainRelationListResponseBodyDataList> DataList { get; set; }
        public class DescribeVpcFirewallDomainRelationListResponseBodyDataList : TeaModel {
            /// <summary>
            /// <para>The business category of the website.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Google</para>
            /// </summary>
            [NameInMap("Business")]
            [Validation(Required=false)]
            public string Business { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://www.example.com">www.example.com</a></para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The destination IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("DstIP")]
            [Validation(Required=false)]
            public string DstIP { get; set; }

            /// <summary>
            /// <para>The ID of the destination region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("DstRegionId")]
            [Validation(Required=false)]
            public string DstRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the destination VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp10w5nb30r4jzfyc****</para>
            /// </summary>
            [NameInMap("DstVpcId")]
            [Validation(Required=false)]
            public string DstVpcId { get; set; }

            /// <summary>
            /// <para>The name of the destination VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-****</para>
            /// </summary>
            [NameInMap("DstVpcName")]
            [Validation(Required=false)]
            public string DstVpcName { get; set; }

            /// <summary>
            /// <para>The Unix timestamp for the first access, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767147003</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public long? FirstTime { get; set; }

            /// <summary>
            /// <para>The name of the organization.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Google</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IPS hit count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("IpsHitCnt")]
            [Validation(Required=false)]
            public long? IpsHitCnt { get; set; }

            /// <summary>
            /// <para>The Unix timestamp for the last access, in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1767147003</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public long? LastTime { get; set; }

            /// <summary>
            /// <para>The request traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("RequestBytes")]
            [Validation(Required=false)]
            public long? RequestBytes { get; set; }

            /// <summary>
            /// <para>The response traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10000</para>
            /// </summary>
            [NameInMap("ResponseBytes")]
            [Validation(Required=false)]
            public long? ResponseBytes { get; set; }

            /// <summary>
            /// <para>The total number of sessions.</para>
            /// 
            /// <b>Example:</b>
            /// <para>27</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The source IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.0.XX.XX</para>
            /// </summary>
            [NameInMap("SrcIP")]
            [Validation(Required=false)]
            public string SrcIP { get; set; }

            /// <summary>
            /// <para>The ID of the source region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("SrcRegionId")]
            [Validation(Required=false)]
            public string SrcRegionId { get; set; }

            /// <summary>
            /// <para>The ID of the source VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-t4nlt09olhpazpoeg****</para>
            /// </summary>
            [NameInMap("SrcVpcId")]
            [Validation(Required=false)]
            public string SrcVpcId { get; set; }

            /// <summary>
            /// <para>The name of the source VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-****</para>
            /// </summary>
            [NameInMap("SrcVpcName")]
            [Validation(Required=false)]
            public string SrcVpcName { get; set; }

            /// <summary>
            /// <para>The total traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>16287823</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public long? TotalBytes { get; set; }

        }

        /// <summary>
        /// <para>A list of destination VPCs.</para>
        /// </summary>
        [NameInMap("DstVpcList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallDomainRelationListResponseBodyDstVpcList> DstVpcList { get; set; }
        public class DescribeVpcFirewallDomainRelationListResponseBodyDstVpcList : TeaModel {
            /// <summary>
            /// <para>The ID of the destination VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp10w5nb30r4jzfyc****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the destination VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-****</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C5DDD596-1191-5F36-A504-8733045A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
