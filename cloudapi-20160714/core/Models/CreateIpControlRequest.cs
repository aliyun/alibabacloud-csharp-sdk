// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class CreateIpControlRequest : TeaModel {
        /// <summary>
        /// <para>The description. The description can be up to 200 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the ACL. The name must be 4 to 50 characters in length, and can contain letters, digits, and underscores (<em>). The name cannot start with an underscore (</em>).``</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>controlNameTest</para>
        /// </summary>
        [NameInMap("IpControlName")]
        [Validation(Required=false)]
        public string IpControlName { get; set; }

        /// <summary>
        /// <para>The information about the policies. The information is an array of ipcontrolpolicys data.</para>
        /// </summary>
        [NameInMap("IpControlPolicys")]
        [Validation(Required=false)]
        public List<CreateIpControlRequestIpControlPolicys> IpControlPolicys { get; set; }
        public class CreateIpControlRequestIpControlPolicys : TeaModel {
            /// <summary>
            /// <para>The ID of the application that is restricted by the policy. You can configure the AppId parameter only when the value of the IpControlType parameter is ALLOW.</para>
            /// <list type="bullet">
            /// <item><description>You can add only one application ID at a time.</description></item>
            /// <item><description>If this parameter is empty, no applications are restricted.</description></item>
            /// <item><description>If this parameter is not empty, not only IP addresses but also applications are restricted.</description></item>
            /// <item><description>If this parameter is not empty and no security authentication method is specified for the API, all API calls are restricted.</description></item>
            /// <item><description>If the value of the IpControlType parameter is REFUSE and the AppId parameter is not empty, API Gateway automatically ignores the AppId parameter and restricts only the IP addresses.</description></item>
            /// <item><description>Valid values of N in IpControlPolicys.N: <c>[1,100]</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>11111</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <para>The IP address or CIDR block involved in a policy.</para>
            /// <list type="bullet">
            /// <item><description>If you want to specify a policy when you create an ACL, this parameter is required.</description></item>
            /// <item><description>The IP address or CIDR block that is defined in each policy. Separate multiple IP addresses or CIDR blocks with semicolons (;). You can add a maximum of 10 IP addresses or CIDR blocks.</description></item>
            /// <item><description>Valid values of N in IpControlPolicys.N: <c>[1,100]</c>.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>114.1.1.0/24</para>
            /// </summary>
            [NameInMap("CidrIp")]
            [Validation(Required=false)]
            public string CidrIp { get; set; }

        }

        /// <summary>
        /// <para>The type of the ACL. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ALLOW</b>: an IP address whitelist</description></item>
        /// <item><description><b>REFUSE</b>: an IP address blacklist</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ALLOW</para>
        /// </summary>
        [NameInMap("IpControlType")]
        [Validation(Required=false)]
        public string IpControlType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
