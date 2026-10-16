// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateLoginPreferenceShrinkRequest : TeaModel {
        [NameInMap("AllowedPostLogoutRedirectUris")]
        [Validation(Required=false)]
        public string AllowedPostLogoutRedirectUrisShrink { get; set; }

        /// <summary>
        /// <para>The logon preference configuration object. It contains the logon configuration fields to be updated.</para>
        /// </summary>
        [NameInMap("LoginPreference")]
        [Validation(Required=false)]
        public string LoginPreferenceShrink { get; set; }

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
