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
        /// <para>The time when the endpoint was created. This is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594608356000</para>
        /// </summary>
        [NameInMap("CreateTimestamp")]
        [Validation(Required=false)]
        public long? CreateTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hra0**</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>A list of IP address configurations for the outbound traffic source.</para>
        /// </summary>
        [NameInMap("IpConfigs")]
        [Validation(Required=false)]
        public List<DescribeResolverEndpointResponseBodyIpConfigs> IpConfigs { get; set; }
        public class DescribeResolverEndpointResponseBodyIpConfigs : TeaModel {
            /// <summary>
            /// <para>The ID of the zone where the vSwitch is located.</para>
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
            /// <para>An IP address within the specified CIDR block. If you leave this parameter empty, the system automatically assigns an IP address.</para>
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
        /// <para>Endpoint-test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The unique request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>45020ED9-6319-4CA7-9475-6E8D6446E84F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the security group. The rules in the security group are applied to the outbound VPC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-8vb3sigz86xc-group-****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The status of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>SUCCESS: The endpoint works as expected.</para>
        /// </description></item>
        /// <item><description><para>INIT: The endpoint is being created.</para>
        /// </description></item>
        /// <item><description><para>FAILED: The endpoint failed to be created.</para>
        /// </description></item>
        /// <item><description><para>CHANGE_INIT: The endpoint is being modified.</para>
        /// </description></item>
        /// <item><description><para>CHANGE_FAILED: The endpoint failed to be modified.</para>
        /// </description></item>
        /// <item><description><para>EXCEPTION: An exception occurred on the endpoint.</para>
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
        /// <para>2020-07-13 10:48:39</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// <para>The time when the endpoint was last updated. This is a UNIX timestamp.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1594608519000</para>
        /// </summary>
        [NameInMap("UpdateTimestamp")]
        [Validation(Required=false)]
        public long? UpdateTimestamp { get; set; }

        /// <summary>
        /// <para>The ID of the outbound virtual private cloud (VPC). All outbound DNS query traffic from the Resolver is forwarded through this VPC.</para>
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
        /// <para>The ID of the region where the outbound VPC is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

        /// <summary>
        /// <para>The name of the region where the outbound VPC is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>North China</para>
        /// </summary>
        [NameInMap("VpcRegionName")]
        [Validation(Required=false)]
        public string VpcRegionName { get; set; }

    }

}
