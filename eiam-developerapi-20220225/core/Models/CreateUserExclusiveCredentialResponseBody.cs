// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eiam_developerapi20220225.Models
{
    public class CreateUserExclusiveCredentialResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cred_mkv7rgt4d7i4u7zqtzev2mxxxx</para>
        /// </summary>
        [NameInMap("credentialId")]
        [Validation(Required=false)]
        public string CredentialId { get; set; }

        /// <summary>
        /// <para>凭据标识。</para>
        /// 
        /// <b>Example:</b>
        /// <para>credential_identifier_test</para>
        /// </summary>
        [NameInMap("credentialIdentifier")]
        [Validation(Required=false)]
        public string CredentialIdentifier { get; set; }

    }

}
