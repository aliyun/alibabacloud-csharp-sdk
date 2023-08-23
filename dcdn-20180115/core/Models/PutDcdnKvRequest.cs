// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class PutDcdnKvRequest : TeaModel {
        /// <summary>
        /// The time when the key expires.Example: "1690081381".
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public long? Expiration { get; set; }

        /// <summary>
        /// The time when the key expires.Example: "3600".
        /// </summary>
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
