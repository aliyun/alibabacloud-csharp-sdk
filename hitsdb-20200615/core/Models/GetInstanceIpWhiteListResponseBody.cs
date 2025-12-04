// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hitsdb20200615.Models
{
    public class GetInstanceIpWhiteListResponseBody : TeaModel {
        /// <summary>
        /// <para>The details about the access denial.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;AuthAction&quot;:&quot;xxx&quot;,&quot;AuthPrincipalDisplayName&quot;:&quot;222&quot;,&quot;AuthPrincipalOwnerId&quot;:&quot;111&quot;,&quot;AuthPrincipalType&quot;:&quot;SubUser&quot;,,&quot;NoPermissionType&quot;:&quot;ImplicitDeny&quot;,&quot;PolicyType&quot;:&quot;AccountLevelIdentityBasedPolicy&quot;,&quot;EncodedDiagnosticMessage&quot;:&quot;xxxxxx&quot;}</para>
        /// </summary>
        [NameInMap("AccessDeniedDetail")]
        [Validation(Required=false)]
        public string AccessDeniedDetail { get; set; }

        /// <summary>
        /// <para>The details about the IP address whitelists.</para>
        /// </summary>
        [NameInMap("GroupList")]
        [Validation(Required=false)]
        public List<GetInstanceIpWhiteListResponseBodyGroupList> GroupList { get; set; }
        public class GetInstanceIpWhiteListResponseBodyGroupList : TeaModel {
            /// <summary>
            /// <para>The name of the IP address whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("GroupName")]
            [Validation(Required=false)]
            public string GroupName { get; set; }

            /// <summary>
            /// <para>The IP addresses in the whitelist.</para>
            /// 
            /// <b>Example:</b>
            /// <para>192.168.1.0/24</para>
            /// </summary>
            [NameInMap("SecurityIpList")]
            [Validation(Required=false)]
            public string SecurityIpList { get; set; }

        }

        /// <summary>
        /// <para>The ID of the Lindorm instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ld-bp1z3506imz2f****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The list of IP addresses in the whitelist of the instance.</para>
        /// </summary>
        [NameInMap("IpList")]
        [Validation(Required=false)]
        public List<string> IpList { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1D1F6F4D-9203-53E7-84E9-5376B4657E63</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
