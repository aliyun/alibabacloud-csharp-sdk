// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InitiateMultipartUploadResponseBody : TeaModel {
        /// <summary>
        /// The name of the bucket to which the object is uploaded by the multipart upload task.
        /// </summary>
        [NameInMap("Bucket")]
        [Validation(Required=false)]
        public string Bucket { get; set; }

        /// <summary>
        /// The encoding type of the object name in the response. If the encoding-type parameter is specified in the request, the object name in the response is encoded.
        /// </summary>
        [NameInMap("EncodingType")]
        [Validation(Required=false)]
        public string EncodingType { get; set; }

        /// <summary>
        /// The name of the object that is uploaded by the multipart upload task.
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// The Upload ID that uniquely identifies the multipart upload task. The Upload ID is used to call UploadPart and CompleteMultipartUpload later.
        /// </summary>
        [NameInMap("UploadId")]
        [Validation(Required=false)]
        public string UploadId { get; set; }

    }

}
