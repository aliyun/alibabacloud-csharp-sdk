// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class DetailResponseBody : TeaModel {
        [NameInMap("Instance")]
        [Validation(Required=false)]
        public DetailResponseBodyInstance Instance { get; set; }
        public class DetailResponseBodyInstance : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public int? Capacity { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Qps")]
            [Validation(Required=false)]
            public int? Qps { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("ServiceType")]
            [Validation(Required=false)]
            public int? ServiceType { get; set; }

            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

            [NameInMap("UtcCreate")]
            [Validation(Required=false)]
            public string UtcCreate { get; set; }

            [NameInMap("UtcExpireTime")]
            [Validation(Required=false)]
            public string UtcExpireTime { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
