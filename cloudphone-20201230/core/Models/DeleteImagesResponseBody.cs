// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class DeleteImagesResponseBody : TeaModel {
        [NameInMap("ImageResponses")]
        [Validation(Required=false)]
        public DeleteImagesResponseBodyImageResponses ImageResponses { get; set; }
        public class DeleteImagesResponseBodyImageResponses : TeaModel {
            [NameInMap("ImageResponse")]
            [Validation(Required=false)]
            public List<DeleteImagesResponseBodyImageResponsesImageResponse> ImageResponse { get; set; }
            public class DeleteImagesResponseBodyImageResponsesImageResponse : TeaModel {
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
