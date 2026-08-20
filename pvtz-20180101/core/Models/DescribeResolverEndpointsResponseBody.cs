// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of endpoints.</para>
        /// </summary>
        [NameInMap("Endpoints")]
        [Validation(Required=false)]
        public List<DescribeResolverEndpointsResponseBodyEndpoints> Endpoints { get; set; }
        public class DescribeResolverEndpointsResponseBodyEndpoints : TeaModel {
            /// <summary>
            /// <para>The time when the endpoint was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:36:26</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was created. This is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594607786000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The list of source IP addresses for outbound traffic.</para>
            /// </summary>
            [NameInMap("IpConfigs")]
            [Validation(Required=false)]
            public List<DescribeResolverEndpointsResponseBodyEndpointsIpConfigs> IpConfigs { get; set; }
            public class DescribeResolverEndpointsResponseBodyEndpointsIpConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the zone where the vSwitch is located.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou-a</para>
                /// </summary>
                [NameInMap("AzId")]
                [Validation(Required=false)]
                public string AzId { get; set; }

                /// <summary>
                /// <para>The subnet mask, which is the IPv4 CIDR block of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The IP address within the CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The ID of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>vsw-0jlgeyq4oazkh5xue****</para>
                /// </summary>
                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

            }

            /// <summary>
            /// <para>The name of the endpoint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Endpoint-test</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the security group.</para>
            /// 
            /// <b>Example:</b>
            /// <para>sg-0jld3m9yq7l2cw12****</para>
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// <para>The status of the endpoint. Description:</para>
            /// <list type="bullet">
            /// <item><description><para>SUCCESS: The endpoint is working as expected.</para>
            /// </description></item>
            /// <item><description><para>INIT: The endpoint is being created.</para>
            /// </description></item>
            /// <item><description><para>FAILED: The endpoint failed to be created.</para>
            /// </description></item>
            /// <item><description><para>CHANGE_INIT: The endpoint is being modified.</para>
            /// </description></item>
            /// <item><description><para>CHANGE_FAILED: The endpoint failed to be modified.</para>
            /// </description></item>
            /// <item><description><para>EXCEPTION: The endpoint is not working as expected.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was last updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:38:24</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was last updated. This is a UNIX timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594607904000</para>
            /// </summary>
            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the outbound VPC. All outbound DNS query traffic from the Resolver is forwarded through this VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-0jlxhpfnj5bfu0bsd****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

            /// <summary>
            /// <para>The name of the outbound VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-test-name</para>
            /// </summary>
            [NameInMap("VpcName")]
            [Validation(Required=false)]
            public string VpcName { get; set; }

            /// <summary>
            /// <para>The ID of the region where the outbound VPC is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the outbound VPC is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Hangzhou VPC test</para>
            /// </summary>
            [NameInMap("VpcRegionName")]
            [Validation(Required=false)]
            public string VpcRegionName { get; set; }

        }

        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The unique ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>83D1682B-B69A-4060-9FA8-2907C2A35600</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of endpoints.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalItems")]
        [Validation(Required=false)]
        public int? TotalItems { get; set; }

        /// <summary>
        /// <para>The total number of pages returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
