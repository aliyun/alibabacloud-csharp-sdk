// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateLoginPreferenceRequest : TeaModel {
        [NameInMap("AllowedPostLogoutRedirectUris")]
        [Validation(Required=false)]
        public List<string> AllowedPostLogoutRedirectUris { get; set; }

        /// <summary>
        /// <para>The logon preference configuration object. It contains the logon configuration fields to be updated.</para>
        /// </summary>
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public UpdateLoginPreferenceRequestLoginPreference LoginPreference { get; set; }
        public class UpdateLoginPreferenceRequestLoginPreference : TeaModel {
            /// <summary>
            /// <para>Specifies whether to enable password logon for users.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("EnablePasswordLogin")]
            [Validation(Required=false)]
            public bool? EnablePasswordLogin { get; set; }

        }

        /// <summary>
        /// <para>The name of the user pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
