// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkedmall20230930.Models
{
    public class ProductSpec : TeaModel {
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("keyId")]
        [Validation(Required=false)]
        public long? KeyId { get; set; }

        [NameInMap("values")]
        [Validation(Required=false)]
        public List<ProductSpecValue> Values { get; set; }

    }

}
