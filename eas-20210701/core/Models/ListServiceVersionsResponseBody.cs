// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class ListServiceVersionsResponseBody : TeaModel {
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Versions")]
        [Validation(Required=false)]
        public List<ListServiceVersionsResponseBodyVersions> Versions { get; set; }
        public class ListServiceVersionsResponseBodyVersions : TeaModel {
            [NameInMap("BuildTime")]
            [Validation(Required=false)]
            public string BuildTime { get; set; }

            [NameInMap("ImageAvailable")]
            [Validation(Required=false)]
            public string ImageAvailable { get; set; }

            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public int? ImageId { get; set; }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("ServiceConfig")]
            [Validation(Required=false)]
            public string ServiceConfig { get; set; }

            [NameInMap("ServiceRunnable")]
            [Validation(Required=false)]
            public string ServiceRunnable { get; set; }

        }

    }

}
