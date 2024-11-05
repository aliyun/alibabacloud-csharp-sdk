// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_bastionhost20191209.Models
{
    public class GetPolicyUserScopeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EC9BF0F4-8983-491A-BC8C-1B4DD94976DE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The users to whom the control policy applies.</para>
        /// </summary>
        [NameInMap("UserScope")]
        [Validation(Required=false)]
        public GetPolicyUserScopeResponseBodyUserScope UserScope { get; set; }
        public class GetPolicyUserScopeResponseBodyUserScope : TeaModel {
            /// <summary>
            /// <para>The scope of users to whom the control policy applies.</para>
            /// <list type="bullet">
            /// <item><description><para>If <b>All</b> is returned for this parameter, the control policy applies to all users.</para>
            /// </description></item>
            /// <item><description><para>If no value is returned for this parameter, the control policy applies to the assets specified in the return values of UserGroupIds and UserIds.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>All</para>
            /// </summary>
            [NameInMap("ScopeType")]
            [Validation(Required=false)]
            public string ScopeType { get; set; }

            /// <summary>
            /// <para>The user groups to which the control policy applies.</para>
            /// </summary>
            [NameInMap("UserGroupIds")]
            [Validation(Required=false)]
            public List<string> UserGroupIds { get; set; }

            /// <summary>
            /// <para>The users to whom the control policy applies.</para>
            /// </summary>
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
