// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddIpControlPolicyItemRequest : TeaModel {
        /// <summary>
        /// The restriction policy on app IDs for a specific policy. You can restrict app IDs only for whitelists. The IpControlType values of whitelists are ALLOW.
        /// 
        /// *   You can add only one app ID restriction policy at a time.
        /// *   If this parameter is empty, no restriction is imposed on the app IDs.
        /// *   If this parameter is not empty, there is restriction not only on IP addresses, but also on apps.
        /// *   Please note that if this parameter is not empty and the security authentication method of the API is No Authentication, all API calls are restricted.
        /// *   If this parameter is not empty for a blacklist, API Gateway automatically skips this parameter and sets only restriction on IP addresses. The IpControlType value of a blacklist is REFUSE.
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// The IP addresses or CIDR blocks involved in the policy. Separate multiple IP addresses or CIDR blocks with semicolons (;). You can specify a maximum of 10 IP addresses or CIDR blocks.
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
        /// The security token included in the WebSocket request header. The system uses this token to authenticate the request.
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
