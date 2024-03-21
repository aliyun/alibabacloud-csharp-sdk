// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchPutDcdnKvRequest : TeaModel {
        /// <summary>
        /// The key-value pairs. The key-value pairs can be up to 2 MB in size.
        /// </summary>
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public List<BatchPutDcdnKvRequestKvList> KvList { get; set; }
        public class BatchPutDcdnKvRequestKvList : TeaModel {
            /// <summary>
            /// The expiration time. The value is a timestamp in seconds. The expiration time cannot be earlier than the current time. If you specify Expiration and ExpirationTtl, only ExpirationTtl takes effect.
            /// </summary>
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public long? Expiration { get; set; }

            /// <summary>
            /// The relative expiration time. Unit: seconds. If you specify Expiration and ExpirationTtl, only ExpirationTtl takes effect.
            /// </summary>
            [NameInMap("ExpirationTtl")]
            [Validation(Required=false)]
            public long? ExpirationTtl { get; set; }

            /// <summary>
            /// The key. The key can be up to 512 characters in length and cannot contain spaces.
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// The value.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The name of the namespace.
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

    }

}
