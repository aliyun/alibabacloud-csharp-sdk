// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gameshield20180305.Models
{
    public class DescribeDailyDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DailyDetails")]
        [Validation(Required=false)]
        public List<DescribeDailyDetailsResponseBodyDailyDetails> DailyDetails { get; set; }
        public class DescribeDailyDetailsResponseBodyDailyDetails : TeaModel {
            [NameInMap("IosActiveCount")]
            [Validation(Required=false)]
            public long? IosActiveCount { get; set; }

            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            [NameInMap("AndroidCount")]
            [Validation(Required=false)]
            public long? AndroidCount { get; set; }

            [NameInMap("IosCount")]
            [Validation(Required=false)]
            public long? IosCount { get; set; }

            [NameInMap("NewCount")]
            [Validation(Required=false)]
            public long? NewCount { get; set; }

            [NameInMap("IpActiveCount")]
            [Validation(Required=false)]
            public long? IpActiveCount { get; set; }

            [NameInMap("ActiveCount")]
            [Validation(Required=false)]
            public long? ActiveCount { get; set; }

            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            [NameInMap("AndroidActiveCount")]
            [Validation(Required=false)]
            public long? AndroidActiveCount { get; set; }

        }

    }

}
