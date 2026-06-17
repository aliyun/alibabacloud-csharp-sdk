// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeOutgoingDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of application names.</para>
        /// </summary>
        [NameInMap("ApplicationNameList")]
        [Validation(Required=false)]
        public List<string> ApplicationNameList { get; set; }

        /// <summary>
        /// <para>The list of assets.</para>
        /// </summary>
        [NameInMap("AssetList")]
        [Validation(Required=false)]
        public List<DescribeOutgoingDomainDetailResponseBodyAssetList> AssetList { get; set; }
        public class DescribeOutgoingDomainDetailResponseBodyAssetList : TeaModel {
            /// <summary>
            /// <para>The policy coverage status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>FullCoverage</para>
            /// </summary>
            [NameInMap("AclCoverage")]
            [Validation(Required=false)]
            public string AclCoverage { get; set; }

            /// <summary>
            /// <para>The domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// <para>The first access time, as a Unix timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1738548990</para>
            /// </summary>
            [NameInMap("FirstTime")]
            [Validation(Required=false)]
            public int? FirstTime { get; set; }

            /// <summary>
            /// <para>The inbound traffic (response traffic), in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>244438.0</para>
            /// </summary>
            [NameInMap("InBytes")]
            [Validation(Required=false)]
            public long? InBytes { get; set; }

            /// <summary>
            /// <para>The IPS hit count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>32</para>
            /// </summary>
            [NameInMap("IpsHitCnt")]
            [Validation(Required=false)]
            public long? IpsHitCnt { get; set; }

            /// <summary>
            /// <para>The last access time, as a Unix timestamp in seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1739326614</para>
            /// </summary>
            [NameInMap("LastTime")]
            [Validation(Required=false)]
            public int? LastTime { get; set; }

            /// <summary>
            /// <para>The NAT Gateway ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-bp1utx6wj4x9qu9tl****</para>
            /// </summary>
            [NameInMap("NatGatewayId")]
            [Validation(Required=false)]
            public string NatGatewayId { get; set; }

            /// <summary>
            /// <para>The NAT Gateway name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ngw-test</para>
            /// </summary>
            [NameInMap("NatGatewayName")]
            [Validation(Required=false)]
            public string NatGatewayName { get; set; }

            /// <summary>
            /// <para>The outbound traffic (request traffic), in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("OutBytes")]
            [Validation(Required=false)]
            public long? OutBytes { get; set; }

            /// <summary>
            /// <para>The private IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10.21.242XXX</para>
            /// </summary>
            [NameInMap("PrivateIP")]
            [Validation(Required=false)]
            public string PrivateIP { get; set; }

            /// <summary>
            /// <para>The public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.96.181.XXX</para>
            /// </summary>
            [NameInMap("PublicIP")]
            [Validation(Required=false)]
            public string PublicIP { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-beijing</para>
            /// </summary>
            [NameInMap("RegionNo")]
            [Validation(Required=false)]
            public string RegionNo { get; set; }

            /// <summary>
            /// <para>The asset instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>i-uf63wjhyoohc1g4z****</para>
            /// </summary>
            [NameInMap("ResourceInstanceId")]
            [Validation(Required=false)]
            public string ResourceInstanceId { get; set; }

            /// <summary>
            /// <para>The asset instance name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ResourceInstanceName")]
            [Validation(Required=false)]
            public string ResourceInstanceName { get; set; }

            /// <summary>
            /// <para>The type of the asset\&quot;s public IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NatEIP</para>
            /// </summary>
            [NameInMap("ResourceType")]
            [Validation(Required=false)]
            public string ResourceType { get; set; }

            /// <summary>
            /// <para>The ACL rule ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>08a58465-ff4d-4c47-8782-eb008301****</para>
            /// </summary>
            [NameInMap("RuleId")]
            [Validation(Required=false)]
            public string RuleId { get; set; }

            /// <summary>
            /// <para>The rule name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            /// <summary>
            /// <para>The session count.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("SessionCount")]
            [Validation(Required=false)]
            public long? SessionCount { get; set; }

            /// <summary>
            /// <para>The list of tags.</para>
            /// </summary>
            [NameInMap("TagList")]
            [Validation(Required=false)]
            public List<DescribeOutgoingDomainDetailResponseBodyAssetListTagList> TagList { get; set; }
            public class DescribeOutgoingDomainDetailResponseBodyAssetListTagList : TeaModel {
                /// <summary>
                /// <para>The risk classification ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ClassId")]
                [Validation(Required=false)]
                public string ClassId { get; set; }

                /// <summary>
                /// <para>The risk level.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RiskLevel")]
                [Validation(Required=false)]
                public int? RiskLevel { get; set; }

                /// <summary>
                /// <para>The tag description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagDescribe")]
                [Validation(Required=false)]
                public string TagDescribe { get; set; }

                /// <summary>
                /// <para>The tag ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>FirstFlow</para>
                /// </summary>
                [NameInMap("TagId")]
                [Validation(Required=false)]
                public string TagId { get; set; }

                /// <summary>
                /// <para>The tag name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

            }

            /// <summary>
            /// <para>The total traffic, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>321120825843</para>
            /// </summary>
            [NameInMap("TotalBytes")]
            [Validation(Required=false)]
            public string TotalBytes { get; set; }

            /// <summary>
            /// <para>The VPC ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-9dp16jgwgyvn****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>98AF5888-9606-59CF-888F-032A9ED0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
