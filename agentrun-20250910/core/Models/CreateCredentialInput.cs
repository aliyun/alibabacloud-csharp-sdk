// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CreateCredentialInput : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("credentialAuthType")]
        [Validation(Required=false)]
        public string CredentialAuthType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

        [NameInMap("credentialPublicConfig")]
        [Validation(Required=false)]
        public CredentialPublicConfig CredentialPublicConfig { get; set; }

        [NameInMap("credentialSecret")]
        [Validation(Required=false)]
        public string CredentialSecret { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("credentialSourceType")]
        [Validation(Required=false)]
        public string CredentialSourceType { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

    }

}
