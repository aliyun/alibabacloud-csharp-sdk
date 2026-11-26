// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class SetSecurityInfoPreferenceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9B13E4EE-3853-5852-9165-597C32AD8FB7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The security information management preferences.</para>
        /// </summary>
        [NameInMap("SecurityInfoPreference")]
        [Validation(Required=false)]
        public SetSecurityInfoPreferenceResponseBodySecurityInfoPreference SecurityInfoPreference { get; set; }
        public class SetSecurityInfoPreferenceResponseBodySecurityInfoPreference : TeaModel {
            /// <summary>
            /// <para>Specifies whether CloudSSO users in the directory are allowed to manage their security email addresses in the CloudSSO user portal. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: allowed.</description></item>
            /// <item><description>false: not allowed.</description></item>
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
