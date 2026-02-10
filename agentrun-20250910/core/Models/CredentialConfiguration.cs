// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRun20250910.Models
{
    public class CredentialConfiguration : TeaModel {
        /// <summary>
        /// <para>凭证的唯一标识符</para>
        /// 
        /// <b>Example:</b>
        /// <para>deepagent-key</para>
        /// </summary>
        [NameInMap("credentialName")]
        [Validation(Required=false)]
        public string CredentialName { get; set; }

    }

}
