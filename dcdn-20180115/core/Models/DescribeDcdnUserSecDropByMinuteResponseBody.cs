// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnUserSecDropByMinuteResponseBody : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Len")]
        [Validation(Required=false)]
        public int? Len { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Rows")]
        [Validation(Required=false)]
        public List<DescribeDcdnUserSecDropByMinuteResponseBodyRows> Rows { get; set; }
        public class DescribeDcdnUserSecDropByMinuteResponseBodyRows : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("Drops")]
            [Validation(Required=false)]
            public int? Drops { get; set; }

            [NameInMap("Object")]
            [Validation(Required=false)]
            public string Object { get; set; }

            [NameInMap("RuleName")]
            [Validation(Required=false)]
            public string RuleName { get; set; }

            [NameInMap("SecFunc")]
            [Validation(Required=false)]
            public string SecFunc { get; set; }

            [NameInMap("TmStr")]
            [Validation(Required=false)]
            public string TmStr { get; set; }

        }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
