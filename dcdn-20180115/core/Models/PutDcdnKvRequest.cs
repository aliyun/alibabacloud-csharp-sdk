// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PutDcdnKvRequest : TeaModel {
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        [NameInMap("ExpirationTtl")]
        [Validation(Required=false)]
        public long? ExpirationTtl { get; set; }

        /// <summary>
        /// The key. The key can be up to 512 characters in length, and cannot contain spaces.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The value of the key. The maximum size is 2 MB (2 x 1000 x 1000 bytes).
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
