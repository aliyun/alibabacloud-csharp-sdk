// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class BatchGetSecretValueShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The list of secret information. You can query up to 20 different secrets at a time.</para>
        /// </summary>
        [NameInMap("SecretsList")]
        [Validation(Required=false)]
        public string SecretsListShrink { get; set; }

    }

}
