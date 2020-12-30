// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudPhoto20170711.Models
{
    public class GetQuotaResponseBody : TeaModel {
        [NameInMap("Action")]
        [Validation(Required=false)]
        public string Action { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Quota")]
        [Validation(Required=false)]
        public GetQuotaResponseBodyQuota Quota { get; set; }
        public class GetQuotaResponseBodyQuota : TeaModel {
            [NameInMap("PhotosCount")]
            [Validation(Required=false)]
            public int? PhotosCount { get; set; }
            [NameInMap("VideosCount")]
            [Validation(Required=false)]
            public int? VideosCount { get; set; }
            [NameInMap("FacesCount")]
            [Validation(Required=false)]
            public int? FacesCount { get; set; }
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }
            [NameInMap("TotalQuota")]
            [Validation(Required=false)]
            public long? TotalQuota { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
