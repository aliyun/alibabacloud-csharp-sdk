// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeDomainViewTopCostTimeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UrlList")]
        [Validation(Required=false)]
        public List<DescribeDomainViewTopCostTimeResponseBodyUrlList> UrlList { get; set; }
        public class DescribeDomainViewTopCostTimeResponseBodyUrlList : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("CostTime")]
            [Validation(Required=false)]
            public float? CostTime { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

    }

}
