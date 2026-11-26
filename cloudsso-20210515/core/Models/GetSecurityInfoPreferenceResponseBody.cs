// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class GetSecurityInfoPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8CE8B990-193D-50CE-A604-69F3E7DCE740</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security information management preferences.</para>
        /// </summary>
        [NameInMap("SecurityInfoPreference")]
        [Validation(Required=false)]
        public GetSecurityInfoPreferenceResponseBodySecurityInfoPreference SecurityInfoPreference { get; set; }
        public class GetSecurityInfoPreferenceResponseBodySecurityInfoPreference : TeaModel {
            /// <summary>
            /// <para>Indicates whether CloudSSO users in the directory are allowed to manage their security email addresses in the CloudSSO user portal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: Allowed.</description></item>
            /// <item><description>false: Not allowed. This is the default value.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("AllowUserManageSecurityEmail")]
            [Validation(Required=false)]
            public bool? AllowUserManageSecurityEmail { get; set; }

        }

    }

}
