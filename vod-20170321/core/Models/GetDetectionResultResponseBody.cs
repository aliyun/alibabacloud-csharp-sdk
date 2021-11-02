// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetDetectionResultResponseBody : TeaModel {
        [NameInMap("DetectionResultList")]
        [Validation(Required=false)]
        public List<GetDetectionResultResponseBodyDetectionResultList> DetectionResultList { get; set; }
        public class GetDetectionResultResponseBodyDetectionResultList : TeaModel {
            [NameInMap("CollectionTitle")]
            [Validation(Required=false)]
            public string CollectionTitle { get; set; }

            [NameInMap("CollectionUrl")]
            [Validation(Required=false)]
            public string CollectionUrl { get; set; }

            [NameInMap("ContentType")]
            [Validation(Required=false)]
            public string ContentType { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Uploader")]
            [Validation(Required=false)]
            public string Uploader { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
