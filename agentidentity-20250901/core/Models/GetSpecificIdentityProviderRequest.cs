// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class GetSpecificIdentityProviderRequest : TeaModel {
        /// <summary>
        /// <para>The type of the identity provider. Currently, only DingTalk is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DingTalk</para>
        /// </summary>
        [NameInMap("IdentityProviderType")]
        [Validation(Required=false)]
        public string IdentityProviderType { get; set; }

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
