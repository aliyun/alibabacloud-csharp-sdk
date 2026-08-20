// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddResolverEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The list of source IP addresses for outbound traffic. You must add at least two IP addresses. You can add up to six IP addresses.</para>
        /// <remarks>
        /// <para>To ensure high availability (HA), add at least two source IP addresses for the outbound endpoint. We recommend that you allocate these IP addresses in different zones. You can add a maximum of six source IP addresses.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("IpConfig")]
        [Validation(Required=false)]
        public List<AddResolverEndpointRequestIpConfig> IpConfig { get; set; }
        public class AddResolverEndpointRequestIpConfig : TeaModel {
            /// <summary>
            /// <para>The ID of the zone where the vSwitch resides.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-a</para>
            /// </summary>
            [NameInMap("AzId")]
            [Validation(Required=false)]
            public string AzId { get; set; }

            /// <summary>
            /// <para>The IPv4 CIDR block of the vSwitch.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX/24</para>
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// <para>The IP address. The IP address must be within the specified CIDR block. If you leave this parameter empty, the system automatically assigns an IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>172.16.XX.XX</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>The vSwitch ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-0jlgeyq4oazkh5xue****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// <para>The language of the response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>zh: Chinese.</para>
        /// </description></item>
        /// <item><description><para>en: English.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: en</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The name of the endpoint. The name can be up to 20 characters long. An error is reported if the limit is exceeded.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>endpoint-test-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The ID of the security group. The rules in the security group are applied to the outbound VPC.</para>
        /// <remarks>
        /// <para>To prevent service interruptions, you cannot change this value after you create the outbound endpoint.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sg-0jld3m9yq7l2cw12****</para>
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the outbound virtual private cloud (VPC). All outbound DNS query traffic from the Resolver is forwarded through this VPC.</para>
        /// <remarks>
        /// <para>To prevent service interruptions, you cannot change this value after you create the outbound endpoint.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-0jl96awrjt75ezglc****</para>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// <para>The region ID of the outbound VPC.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
