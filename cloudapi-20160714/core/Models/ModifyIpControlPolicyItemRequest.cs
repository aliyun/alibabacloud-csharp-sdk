// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class ModifyIpControlPolicyItemRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application that is restricted by the policy. You can configure the AppId parameter only when the value of the IpControlType parameter is ALLOW.</para>
        /// <list type="bullet">
        /// <item><description>You can add only one application ID at a time.</description></item>
        /// <item><description>If this parameter is empty, no applications are restricted.</description></item>
        /// <item><description>If this parameter is not empty, not only IP addresses but also applications are restricted.</description></item>
        /// <item><description>If this parameter is not empty and no security authentication method is specified for the API, all API calls are restricted.</description></item>
        /// <item><description>If the value of the IpControlType parameter is REFUSE and the AppId parameter is not empty, API Gateway automatically ignores the AppId parameter and restricts only the IP addresses.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The IP address or CIDR block that is defined in a policy. Separate multiple IP addresses or CIDR blocks with semicolons (;). You can add a maximum of 10 IP addresses or CIDR blocks.</para>
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
        /// <para>The ID of the policy.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P151617000829241</para>
        /// </summary>
        [NameInMap("PolicyItemId")]
        [Validation(Required=false)]
        public string PolicyItemId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
