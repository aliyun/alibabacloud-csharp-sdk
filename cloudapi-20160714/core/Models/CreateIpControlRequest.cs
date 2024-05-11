// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateIpControlRequest : TeaModel {
        /// <summary>
        /// The description. The description can be up to 200 characters in length.
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// The name of the ACL. The name must be 4 to 50 characters in length, and can contain letters, digits, and underscores (_). The name cannot start with an underscore (_).``
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpControlName")]
        [Validation(Required=false)]
        public string IpControlName { get; set; }

        /// <summary>
        /// The information about the policies. The information is an array of ipcontrolpolicys data.
        /// </summary>
        [NameInMap("IpControlPolicys")]
        [Validation(Required=false)]
        public List<CreateIpControlRequestIpControlPolicys> IpControlPolicys { get; set; }
        public class CreateIpControlRequestIpControlPolicys : TeaModel {
            /// <summary>
            /// The ID of the application that is restricted by the policy. You can configure the AppId parameter only when the value of the IpControlType parameter is ALLOW.
            /// 
            /// *   You can add only one application ID at a time.
            /// *   If this parameter is empty, no applications are restricted.
            /// *   If this parameter is not empty, not only IP addresses but also applications are restricted.
            /// *   If this parameter is not empty and no security authentication method is specified for the API, all API calls are restricted.
            /// *   If the value of the IpControlType parameter is REFUSE and the AppId parameter is not empty, API Gateway automatically ignores the AppId parameter and restricts only the IP addresses.
            /// *   Valid values of N in IpControlPolicys.N: `[1,100]`.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// The IP address or CIDR block involved in a policy.
            /// 
            /// *   If you want to specify a policy when you create an ACL, this parameter is required.
            /// *   The IP address or CIDR block that is defined in each policy. Separate multiple IP addresses or CIDR blocks with semicolons (;). You can add a maximum of 10 IP addresses or CIDR blocks.
            /// *   Valid values of N in IpControlPolicys.N: `[1,100]`.
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

        }

        /// <summary>
        /// The type of the ACL. Valid values:
        /// 
        /// *   **ALLOW**: an IP address whitelist
        /// *   **REFUSE**: an IP address blacklist
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("IpControlType")]
        [Validation(Required=false)]
        public string IpControlType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
