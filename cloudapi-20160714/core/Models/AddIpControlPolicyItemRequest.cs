// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class AddIpControlPolicyItemRequest : TeaModel {
        /// <summary>
        /// <para>The restriction policy on app IDs for a specific policy. You can restrict app IDs only for whitelists. The IpControlType values of whitelists are ALLOW.</para>
        /// <list type="bullet">
        /// <item><description>You can add only one app ID restriction policy at a time.</description></item>
        /// <item><description>If this parameter is empty, no restriction is imposed on the app IDs.</description></item>
        /// <item><description>If this parameter is not empty, there is restriction not only on IP addresses, but also on apps.</description></item>
        /// <item><description>Please note that if this parameter is not empty and the security authentication method of the API is No Authentication, all API calls are restricted.</description></item>
        /// <item><description>If this parameter is not empty for a blacklist, API Gateway automatically skips this parameter and sets only restriction on IP addresses. The IpControlType value of a blacklist is REFUSE.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1111111</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The IP addresses or CIDR blocks involved in the policy. Separate multiple IP addresses or CIDR blocks with semicolons (;). You can specify a maximum of 10 IP addresses or CIDR blocks.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>113.125.1.101;101.11.1.1</para>
        /// </summary>
        [NameInMap("CidrIp")]
        [Validation(Required=false)]
        public string CidrIp { get; set; }

        /// <summary>
        /// <para>The ID of the ACL. The ID is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7ea91319a34d48a09b5c9c871d9768b1</para>
        /// </summary>
        [NameInMap("IpControlId")]
        [Validation(Required=false)]
        public string IpControlId { get; set; }

        /// <summary>
        /// <para>The security token included in the WebSocket request header. The system uses this token to authenticate the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4223a10e-eed3-46a6-8b7c-23003f488153</para>
        /// </summary>
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
