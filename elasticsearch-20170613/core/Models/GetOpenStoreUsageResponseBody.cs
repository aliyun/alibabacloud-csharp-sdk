// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class GetOpenStoreUsageResponseBody : TeaModel {
        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetOpenStoreUsageResponseBodyResult Result { get; set; }
        public class GetOpenStoreUsageResponseBodyResult : TeaModel {
            [NameInMap("lastDayUsage")]
            [Validation(Required=false)]
            public long? LastDayUsage { get; set; }
            [NameInMap("currentUsage")]
            [Validation(Required=false)]
            public long? CurrentUsage { get; set; }
        };

    }

}
