// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetThumbnailsResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Results")]
        [Validation(Required=false)]
        public GetThumbnailsResponseBodyResults Results { get; set; }
        public class GetThumbnailsResponseBodyResults : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<GetThumbnailsResponseBodyResultsResult> Result { get; set; }
            public class GetThumbnailsResponseBodyResultsResult : TeaModel {
                public string ThumbnailUrl { get; set; }
                public string PhotoIdStr { get; set; }
                public string Code { get; set; }
                public string Message { get; set; }
                public long? PhotoId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
