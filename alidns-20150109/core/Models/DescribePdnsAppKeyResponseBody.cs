// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribePdnsAppKeyResponseBody : TeaModel {
        [NameInMap("AppKey")]
        [Validation(Required=false)]
        public DescribePdnsAppKeyResponseBodyAppKey AppKey { get; set; }
        public class DescribePdnsAppKeyResponseBodyAppKey : TeaModel {
            [NameInMap("AppKeyId")]
            [Validation(Required=false)]
            public string AppKeyId { get; set; }

            [NameInMap("AppKeySecret")]
            [Validation(Required=false)]
            public string AppKeySecret { get; set; }

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
