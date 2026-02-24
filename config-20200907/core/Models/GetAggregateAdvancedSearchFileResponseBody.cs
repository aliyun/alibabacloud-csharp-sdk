// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class GetAggregateAdvancedSearchFileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResourceSearch")]
        [Validation(Required=false)]
        public GetAggregateAdvancedSearchFileResponseBodyResourceSearch ResourceSearch { get; set; }
        public class GetAggregateAdvancedSearchFileResponseBodyResourceSearch : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            [NameInMap("ResourceInventoryGenerateTime")]
            [Validation(Required=false)]
            public long? ResourceInventoryGenerateTime { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
