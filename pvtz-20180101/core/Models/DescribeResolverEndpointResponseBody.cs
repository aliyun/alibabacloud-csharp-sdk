// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class DescribeResolverEndpointResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the endpoint was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-07-13 10:45:56</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The time when the endpoint was created. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594608356000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The endpoint ID. This ID uniquely identifies the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The configurations of the source IP addresses for outbound traffic.</para>
        /// </summary>
        [NameInMap("IpConfigs")]
        [Validation(Required=false)]
        public List<DescribeResolverEndpointResponseBodyIpConfigs> IpConfigs { get; set; }
        public class DescribeResolverEndpointResponseBodyIpConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the zone to which the vSwitch belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
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
            /// <para>The source IP address of outbound traffic. The IP address must be within the specified CIDR block. If this parameter is left empty, the system automatically allocates an IP address.</para>
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
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45020ED9-6319-4CA7-9475-6E8D6446E84F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the security group. The security group rules are applied to the outbound virtual private cloud (VPC).</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-8vb3sigz86xc-group-****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The state of the endpoint. Valid values:</para>
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
        /// <para>2020-07-13 10:48:39</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the endpoint was updated. This value is a UNIX timestamp representing the number of milliseconds that have elapsed since January 1, 1970, 00:00:00 UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594608519000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the outbound VPC. All outbound Domain Name System (DNS) requests of the resolver are forwarded by this VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-0jl96awrjt75ezglc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The name of the outbound VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-name-test</para>
        /// </summary>
        [NameInMap("VpcName")]
        [Validation(Required=false)]
        public string VpcName { get; set; }

        /// <summary>
        /// <para>The region ID of the outbound VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

        /// <summary>
        /// <para>The name of the region where the outbound VPC resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HuaBei</para>
        /// </summary>
        [NameInMap("VpcRegionName")]
        [Validation(Required=false)]
        public string VpcRegionName { get; set; }

    }

}
