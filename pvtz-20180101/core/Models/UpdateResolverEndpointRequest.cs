// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class UpdateResolverEndpointRequest : TeaModel {
        /// <summary>
        /// <para>The endpoint ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hr****</para>
        /// </summary>
        [NameInMap("EndpointId")]
        [Validation(Required=false)]
        public string EndpointId { get; set; }

        /// <summary>
        /// <para>A list of source IP addresses for outbound traffic. Specify at least two and up to six IP addresses.</para>
        /// <remarks>
        /// <para>To ensure high availability (HA), an outbound endpoint requires at least two source IP addresses. We recommend that you assign these IP addresses to different zones. An outbound endpoint supports a maximum of six source IP addresses.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("IpConfig")]
        [Validation(Required=false)]
        public List<UpdateResolverEndpointRequestIpConfig> IpConfig { get; set; }
        public class UpdateResolverEndpointRequestIpConfig : TeaModel {
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
            /// <para>An IP address that is within the CIDR block of the vSwitch. If you leave this parameter empty, the system automatically assigns an IP address.</para>
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
        /// <para>The name of the endpoint.</para>
        /// 
        /// <b>Example:</b>
        /// <para>endpoint-test-name</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
