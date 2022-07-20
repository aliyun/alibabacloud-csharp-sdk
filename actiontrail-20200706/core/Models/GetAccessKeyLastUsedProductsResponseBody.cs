// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Actiontrail20200706.Models
{
    public class GetAccessKeyLastUsedProductsResponseBody : TeaModel {
        [NameInMap("Products")]
        [Validation(Required=false)]
        public List<GetAccessKeyLastUsedProductsResponseBodyProducts> Products { get; set; }
        public class GetAccessKeyLastUsedProductsResponseBodyProducts : TeaModel {
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("ServiceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("ServiceNameCn")]
            [Validation(Required=false)]
            public string ServiceNameCn { get; set; }

            [NameInMap("ServiceNameEn")]
            [Validation(Required=false)]
            public string ServiceNameEn { get; set; }

            [NameInMap("Source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            [NameInMap("UsedTimestamp")]
            [Validation(Required=false)]
            public long? UsedTimestamp { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
