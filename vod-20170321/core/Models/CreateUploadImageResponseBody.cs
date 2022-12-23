// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadImageResponseBody : TeaModel {
        /// <summary>
        /// The OSS URL of the file. The URL does not contain the information used for URL signing. You can set FileUrl to this URL when you call the [AddWatermark](~~98617~~) operation.
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// The ID of the image file.
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// The URL of the image.
        /// 
        /// > If you enable the URL signing feature in ApsaraVideo VOD, the returned URL may not be accessible from a browser and an HTTP 403 status code may be returned. To resolve this issue, you can disable the [URL signing](~~86090~~) feature or [generate a signed URL](~~57007~~).
        /// </summary>
        [NameInMap("ImageURL")]
        [Validation(Required=false)]
        public string ImageURL { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The upload URL.
        /// 
        /// > The returned upload URL is a Base64-encoded URL. You must decode the Base64-encoded upload URL before you use an SDK or call an API operation to upload media files. You need to parse UploadAddress only if you use the OSS SDK or call an OSS API operation to upload media files.
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// The upload credential.
        /// 
        /// > The returned upload credential is a Base64-encoded value. You must decode the Base64-encoded credential before you use an SDK or call an API operation to upload media files. You need to parse UploadAuth only if you use the OSS SDK or call an OSS API operation to upload media files.
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

    }

}
