// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadVideoResponseBody : TeaModel {
        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The upload URL.
        /// 
        /// > The upload URL returned by this operation is Base64-encoded. Before you can use an SDK or an API operation to upload a media asset based on the upload URL, you must decode the upload URL by using the Base64 algorithm. You must parse the upload URL only if you use native OSS SDKs or OSS API for uploads.
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// The upload credential.
        /// 
        /// > The upload credential returned by this operation is Base64-encoded. Before you can use an SDK or an API operation to upload a media asset based on the upload credential, you must decode the upload credential by using the Base64 algorithm. You must parse the upload credential only if you use native OSS SDKs or OSS API for uploads.
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

        /// <summary>
        /// The ID of the audio or video file. You can set the request parameter VideoId to this ID when you call an operation for media asset management, media processing, or media review.
        /// </summary>
        [NameInMap("VideoId")]
        [Validation(Required=false)]
        public string VideoId { get; set; }

    }

}
