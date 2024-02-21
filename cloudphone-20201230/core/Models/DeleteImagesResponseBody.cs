// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudphone20201230.Models
{
    public class DeleteImagesResponseBody : TeaModel {
        /// <summary>
        /// Details about images that are deleted.
        /// </summary>
        [NameInMap("ImageResponses")]
        [Validation(Required=false)]
        public DeleteImagesResponseBodyImageResponses ImageResponses { get; set; }
        public class DeleteImagesResponseBodyImageResponses : TeaModel {
            [NameInMap("ImageResponse")]
            [Validation(Required=false)]
            public List<DeleteImagesResponseBodyImageResponsesImageResponse> ImageResponse { get; set; }
            public class DeleteImagesResponseBodyImageResponsesImageResponse : TeaModel {
                /// <summary>
                /// The HTTP status code that is returned when the image is deleted.
                /// </summary>
                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                /// <summary>
                /// The ID of the image that is requested for deletion.
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// The message that is returned when the image is deleted.
                /// </summary>
                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

            }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
