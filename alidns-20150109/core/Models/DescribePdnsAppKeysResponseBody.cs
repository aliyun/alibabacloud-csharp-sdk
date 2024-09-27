// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsAppKeysResponseBody : TeaModel {
        [NameInMap("AppKeys")]
        [Validation(Required=false)]
        public List<DescribePdnsAppKeysResponseBodyAppKeys> AppKeys { get; set; }
        public class DescribePdnsAppKeysResponseBodyAppKeys : TeaModel {
            [NameInMap("AppKeyId")]
            [Validation(Required=false)]
            public string AppKeyId { get; set; }

            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            [NameInMap("CreateTimestamp")]
            [Validation(Required=false)]
            public long? CreateTimestamp { get; set; }

            [NameInMap("Remark")]
            [Validation(Required=false)]
            public string Remark { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
