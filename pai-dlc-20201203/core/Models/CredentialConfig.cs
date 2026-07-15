// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class CredentialConfig : TeaModel {
        /// <summary>
        /// <para>The role identity key injected into environment variables.</para>
        /// </summary>
        [NameInMap("AliyunEnvRoleKey")]
        [Validation(Required=false)]
        public string AliyunEnvRoleKey { get; set; }

        /// <summary>
        /// <para>The list of credential configuration items.</para>
        /// </summary>
        [NameInMap("CredentialConfigItems")]
        [Validation(Required=false)]
        public List<CredentialConfigItem> CredentialConfigItems { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable credential injection.</para>
        /// </summary>
        [NameInMap("EnableCredentialInject")]
        [Validation(Required=false)]
        public bool? EnableCredentialInject { get; set; }

    }

}
