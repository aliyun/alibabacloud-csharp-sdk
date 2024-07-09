/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pvtz20180101.Models
{
    public class AddResolverEndpointRequest : TeaModel {
        /// <summary>
        /// The source IP addresses of outbound traffic. You must add two to six source IP addresses to ensure high availability.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpConfig")]
        [Validation(Required=false)]
        public List<AddResolverEndpointRequestIpConfig> IpConfig { get; set; }
        public class AddResolverEndpointRequestIpConfig : TeaModel {
            /// <summary>
            /// The zone ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("AzId")]
            [Validation(Required=false)]
            public string AzId { get; set; }

            /// <summary>
            /// The IPv4 CIDR block of the vSwitch.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("CidrBlock")]
            [Validation(Required=false)]
            public string CidrBlock { get; set; }

            /// <summary>
            /// The source IP address of outbound traffic. The IP address must be within the specified CIDR block.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

        }

        /// <summary>
        /// The language.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The endpoint name. The name can be up to 20 characters in length. If the upper limit is exceeded, an error message is returned.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// The security group ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecurityGroupId")]
        [Validation(Required=false)]
        public string SecurityGroupId { get; set; }

        /// <summary>
        /// The outbound VPC ID.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

        /// <summary>
        /// The region ID of the outbound virtual private cloud (VPC).
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("VpcRegionId")]
        [Validation(Required=false)]
        public string VpcRegionId { get; set; }

    }

}
