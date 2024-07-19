// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class DescribeGatewayResponseBody : TeaModel {
        /// <summary>
        /// The UID of the account that is used to create the private gateway.
        /// </summary>
        [NameInMap("CallerUid")]
        [Validation(Required=false)]
        public string CallerUid { get; set; }

        /// <summary>
        /// The time when the private gateway was created. The time is displayed in UTC.
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// The ID of the self-managed cluster.
        /// </summary>
        [NameInMap("ExternalClusterId")]
        [Validation(Required=false)]
        public string ExternalClusterId { get; set; }

        /// <summary>
        /// The ID of the private gateway.
        /// </summary>
        [NameInMap("GatewayId")]
        [Validation(Required=false)]
        public string GatewayId { get; set; }

        /// <summary>
        /// The private gateway alias.
        /// </summary>
        [NameInMap("GatewayName")]
        [Validation(Required=false)]
        public string GatewayName { get; set; }

        /// <summary>
        /// The instance type used for the private gateway.
        /// </summary>
        [NameInMap("InstanceType")]
        [Validation(Required=false)]
        public string InstanceType { get; set; }

        /// <summary>
        /// The Internet access control policies.
        /// </summary>
        [NameInMap("InternetAclPolicyList")]
        [Validation(Required=false)]
        public List<DescribeGatewayResponseBodyInternetAclPolicyList> InternetAclPolicyList { get; set; }
        public class DescribeGatewayResponseBodyInternetAclPolicyList : TeaModel {
            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("Comment")]
            [Validation(Required=false)]
            public string Comment { get; set; }

            /// <summary>
            /// The Classless Inter-Domain Routing (CIDR) block that is allowed to access the private gateway.
            /// </summary>
            [NameInMap("Entry")]
            [Validation(Required=false)]
            public string Entry { get; set; }

            /// <summary>
            /// The state of the private gateway.
            /// 
            /// Valid values:
            /// 
            /// *   Creating
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   Running
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// The public endpoint.
        /// </summary>
        [NameInMap("InternetDomain")]
        [Validation(Required=false)]
        public string InternetDomain { get; set; }

        /// <summary>
        /// Indicates whether Internet access is enabled.
        /// </summary>
        [NameInMap("InternetEnabled")]
        [Validation(Required=false)]
        public bool? InternetEnabled { get; set; }

        /// <summary>
        /// The internal endpoint.
        /// </summary>
        [NameInMap("IntranetDomain")]
        [Validation(Required=false)]
        public string IntranetDomain { get; set; }

        /// <summary>
        /// Indicates whether internal network access is enabled.
        /// </summary>
        [NameInMap("IntranetEnabled")]
        [Validation(Required=false)]
        public bool? IntranetEnabled { get; set; }

        /// <summary>
        /// The internal endpoints.
        /// </summary>
        [NameInMap("IntranetLinkedVpcList")]
        [Validation(Required=false)]
        public List<DescribeGatewayResponseBodyIntranetLinkedVpcList> IntranetLinkedVpcList { get; set; }
        public class DescribeGatewayResponseBodyIntranetLinkedVpcList : TeaModel {
            /// <summary>
            /// The IP address.
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// The security group ID.
            /// </summary>
            [NameInMap("SecurityGroupId")]
            [Validation(Required=false)]
            public string SecurityGroupId { get; set; }

            /// <summary>
            /// The state of the private gateway. Valid values:
            /// 
            /// *   Creating
            /// *   Running
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The vSwitch ID.
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// The ID of the virtual private cloud (VPC).
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// The user ID (UID) of the Alibaba Cloud account that is used to create the private gateway.
        /// </summary>
        [NameInMap("ParentUid")]
        [Validation(Required=false)]
        public string ParentUid { get; set; }

        /// <summary>
        /// The region ID of the private gateway.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The state of the private gateway.
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// The time when the private gateway was updated. The time is displayed in UTC.
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
