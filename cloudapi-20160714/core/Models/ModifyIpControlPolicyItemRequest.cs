// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyIpControlPolicyItemRequest : TeaModel {
        /// <summary>
        /// The ID of the application that is restricted by the policy. You can configure the AppId parameter only when the value of the IpControlType parameter is ALLOW.
        /// 
        /// *   You can add only one application ID at a time.
        /// *   If this parameter is empty, no applications are restricted.
        /// *   If this parameter is not empty, not only IP addresses but also applications are restricted.
        /// *   If this parameter is not empty and no security authentication method is specified for the API, all API calls are restricted.
        /// *   If the value of the IpControlType parameter is REFUSE and the AppId parameter is not empty, API Gateway automatically ignores the AppId parameter and restricts only the IP addresses.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The IP address or CIDR block that is defined in a policy. Separate multiple IP addresses or CIDR blocks with semicolons (;). You can add a maximum of 10 IP addresses or CIDR blocks.
        /// </summary>
        [NameInMap("CidrIp")]
        [Validation(Required=false)]
        public string CidrIp { get; set; }

        /// <summary>
        /// The ID of the ACL. The ID is unique.
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// The ID of the policy.
        /// </summary>
        [NameInMap("PolicyItemId")]
        [Validation(Required=false)]
        public string PolicyItemId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
