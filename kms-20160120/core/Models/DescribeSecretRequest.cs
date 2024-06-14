// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class DescribeSecretRequest : TeaModel {
        /// <summary>
        /// Specifies whether to return the resource tags of the secret. Valid values:
        /// 
        /// *   true: The resource tags are returned.
        /// *   false: The resource tags are not returned. This is the default value.
        /// </summary>
        [NameInMap("FetchTags")]
        [Validation(Required=false)]
        public string FetchTags { get; set; }

        /// <summary>
        /// The name of the secret.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

    }

}
