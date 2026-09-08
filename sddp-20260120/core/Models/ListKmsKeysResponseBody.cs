// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListKmsKeysResponseBody : TeaModel {
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListKmsKeysResponseBodyItems> Items { get; set; }
        public class ListKmsKeysResponseBodyItems : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            [NameInMap("KeyId")]
            [Validation(Required=false)]
            public string KeyId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
