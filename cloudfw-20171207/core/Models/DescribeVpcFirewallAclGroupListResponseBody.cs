// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeVpcFirewallAclGroupListResponseBody : TeaModel {
        /// <summary>
        /// The information about the policy groups.
        /// </summary>
        [NameInMap("AclGroupList")]
        [Validation(Required=false)]
        public List<DescribeVpcFirewallAclGroupListResponseBodyAclGroupList> AclGroupList { get; set; }
        public class DescribeVpcFirewallAclGroupListResponseBodyAclGroupList : TeaModel {
            /// <summary>
            /// The ID of the policy group.
            /// 
            /// Valid values:
            /// 
            /// *   If the VPC firewall is used to protect a Cloud Enterprise Network (CEN) instance, the value of this parameter is the ID of the CEN instance.
            /// 
            ///     Example: cen-ervw0g12b5jbw\*\*\*\*
            /// 
            /// *   If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the instance ID of the VPC firewall.
            /// 
            ///     Example: vfw-a42bbb7b887148c9\*\*\*\*
            /// </summary>
            [NameInMap("AclGroupId")]
            [Validation(Required=false)]
            public string AclGroupId { get; set; }

            /// <summary>
            /// The name of the policy group. Valid values:
            /// 
            /// *   If the VPC firewall is used to protect a CEN instance, the value of this parameter is the name of the CEN instance.
            /// *   If the VPC firewall is used to protect an Express Connect circuit, the value of this parameter is the instance name of the VPC firewall.
            /// </summary>
            [NameInMap("AclGroupName")]
            [Validation(Required=false)]
            public string AclGroupName { get; set; }

            /// <summary>
            /// The number of access control policies in the policy group.
            /// </summary>
            [NameInMap("AclRuleCount")]
            [Validation(Required=false)]
            public int? AclRuleCount { get; set; }

            /// <summary>
            /// 是否是默认防火墙。取值：
            /// - **true**：是默认防火墙。
            /// - **false**：不是默认防火墙。
            /// </summary>
            [NameInMap("IsDefault")]
            [Validation(Required=false)]
            public bool? IsDefault { get; set; }

            /// <summary>
            /// The UID of the member that is managed by your Alibaba Cloud account.
            /// </summary>
            [NameInMap("MemberUid")]
            [Validation(Required=false)]
            public string MemberUid { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of the policy groups that are returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
