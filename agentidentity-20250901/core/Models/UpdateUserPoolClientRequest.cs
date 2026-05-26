// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentIdentity20250901.Models
{
    public class UpdateUserPoolClientRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("AccessTokenValidity")]
        [Validation(Required=false)]
        public string AccessTokenValidity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-web-app</para>
        /// </summary>
        [NameInMap("ClientName")]
        [Validation(Required=false)]
        public string ClientName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnforcePKCE")]
        [Validation(Required=false)]
        public bool? EnforcePKCE { get; set; }

        [NameInMap("RedirectURIs")]
        [Validation(Required=false)]
        public List<string> RedirectURIs { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>86400</para>
        /// </summary>
        [NameInMap("RefreshTokenValidity")]
        [Validation(Required=false)]
        public string RefreshTokenValidity { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("SecretRequired")]
        [Validation(Required=false)]
        public bool? SecretRequired { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-agent-userpool</para>
        /// </summary>
        [NameInMap("UserPoolName")]
        [Validation(Required=false)]
        public string UserPoolName { get; set; }

    }

}
