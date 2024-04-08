// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchPutDcdnKvRequest : TeaModel {
        [NameInMap("KvList")]
        [Validation(Required=false)]
        public List<BatchPutDcdnKvRequestKvList> KvList { get; set; }
        public class BatchPutDcdnKvRequestKvList : TeaModel {
            [NameInMap("Expiration")]
            [Validation(Required=false)]
            public long? Expiration { get; set; }

            [NameInMap("ExpirationTtl")]
            [Validation(Required=false)]
            public long? ExpirationTtl { get; set; }

            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

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
