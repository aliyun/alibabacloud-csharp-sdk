// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverEndpointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The endpoints.</para>
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
            /// <para>The time when the endpoint was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594607786000</para>
            /// </summary>
            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            /// <summary>
            /// <para>The endpoint ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>hr****</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The source IP addresses of outbound traffic.</para>
            /// </summary>
            [NameInMap("IpConfigs")]
            [Validation(Required=false)]
            public List<DescribeResolverEndpointsResponseBodyEndpointsIpConfigs> IpConfigs { get; set; }
            public class DescribeResolverEndpointsResponseBodyEndpointsIpConfigs : TeaModel {
                /// <summary>
                /// <para>The ID of the zone to which the vSwitch belongs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-zhangjiakou-a</para>
                /// </summary>
                [NameInMap("AzId")]
                [Validation(Required=false)]
                public string AzId { get; set; }

                /// <summary>
                /// <para>The IPv4 CIDR block of the vSwitch.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <para>The source IP address of outbound traffic. The IP address must be within the specified CIDR block.</para>
                /// 
                /// <b>Example:</b>
                /// <para>172.16.XX.XX</para>
                /// </summary>
                [NameInMap("Ip")]
                [Validation(Required=false)]
                public string Ip { get; set; }

                /// <summary>
                /// <para>The vSwitch ID.</para>
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
            /// <para>endpoint-test</para>
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
            /// <para>The state of the endpoint that you queried. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUCCESS: The endpoint works as expected.</description></item>
            /// <item><description>INIT: The endpoint is being created.</description></item>
            /// <item><description>FAILED: The endpoint failed to be created.</description></item>
            /// <item><description>CHANGE_INIT: The endpoint is being modified.</description></item>
            /// <item><description>CHANGE_FAILED: The endpoint failed to be modified.</description></item>
            /// <item><description>EXCEPTION: The endpoint encountered an exception.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SUCCESS</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2020-07-13 10:38:24</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

            /// <summary>
            /// <para>The time when the endpoint was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1594607904000</para>
            /// </summary>
            [NameInMap("UpdateTimestamp")]
            [Validation(Required=false)]
            public long? UpdateTimestamp { get; set; }

            /// <summary>
            /// <para>The ID of the outbound VPC. All outbound Domain Name System (DNS) requests of the resolver are forwarded by this VPC.</para>
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
            /// <para>The region ID of the outbound VPC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("VpcRegionId")]
            [Validation(Required=false)]
            public string VpcRegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the VPC resides.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China East 1 (Hangzhou)</para>
            /// </summary>
            [NameInMap("VpcRegionName")]
            [Validation(Required=false)]
            public string VpcRegionName { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
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
