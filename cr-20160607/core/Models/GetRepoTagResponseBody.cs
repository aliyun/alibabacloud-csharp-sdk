// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cr20160607.Models
{
    public class GetRepoTagResponseBody : BaseModel {
        [NameInMap("digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        [NameInMap("imageCreate")]
        [Validation(Required=false)]
        public long? ImageCreate { get; set; }

        [NameInMap("imageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        [NameInMap("imageSize")]
        [Validation(Required=false)]
        public long? ImageSize { get; set; }

        [NameInMap("imageUpdate")]
        [Validation(Required=false)]
        public long? ImageUpdate { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

    }

}
