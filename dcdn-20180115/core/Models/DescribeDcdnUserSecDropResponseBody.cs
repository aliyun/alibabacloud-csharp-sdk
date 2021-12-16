// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropResponseBody : TeaModel {
        [NameInMap("Drops")]
        [Validation(Required=false)]
        public int? Drops { get; set; }

        [NameInMap("Msg")]
        [Validation(Required=false)]
        public string Msg { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UuidStr")]
        [Validation(Required=false)]
        public string UuidStr { get; set; }

    }

}
