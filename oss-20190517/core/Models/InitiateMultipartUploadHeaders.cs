// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oss20190517.Models
{
    public class InitiateMultipartUploadHeaders : TeaModel {
        [NameInMap("commonHeaders")]
        [Validation(Required=false)]
        public Dictionary<string, string> CommonHeaders { get; set; }

        /// <summary>
        /// The caching behavior of the web page when the object is downloaded. For more information, see **[RFC 2616](https://www.ietf.org/rfc/rfc2616.txt)**. 
        /// Default value: null.
        /// </summary>
        [NameInMap("Cache-Control")]
        [Validation(Required=false)]
        public string CacheControl { get; set; }

        /// <summary>
        /// The name of the object when the object is downloaded. For more information, see **[RFC 2616](https://www.ietf.org/rfc/rfc2616.txt)**. 
        /// Default value: null.
        /// </summary>
        [NameInMap("Content-Disposition")]
        [Validation(Required=false)]
        public string ContentDisposition { get; set; }

        /// <summary>
        /// The content encoding format of the object when the object is downloaded. For more information, see **[RFC 2616](https://www.ietf.org/rfc/rfc2616.txt)**. 
        /// Default value: null.
        /// </summary>
        [NameInMap("Content-Encoding")]
        [Validation(Required=false)]
        public string ContentEncoding { get; set; }

        /// <summary>
        /// The expiration time of the request. Unit: milliseconds. For more information, see **[RFC 2616](https://www.ietf.org/rfc/rfc2616.txt)**. 
        /// Default value: null.
        /// </summary>
        [NameInMap("Expires")]
        [Validation(Required=false)]
        public string Expires { get; set; }

        /// <summary>
        /// Specifies whether the InitiateMultipartUpload operation overwrites the existing object that has the same name as the object that you want to upload. When versioning is enabled or suspended for the bucket to which you want to upload the object, the **x-oss-forbid-overwrite** header does not take effect. In this case, the InitiateMultipartUpload operation overwrites the existing object that has the same name as the object that you want to upload. 
        ///   - If you do not specify the **x-oss-forbid-overwrite** header or set the **x-oss-forbid-overwrite** header to **false**, the object that is uploaded by calling the PutObject operation overwrites the existing object that has the same name. 
        ///   - If the value of **x-oss-forbid-overwrite** is set to **true**, existing objects cannot be overwritten by objects that have the same names. 
        /// 
        /// If you specify the **x-oss-forbid-overwrite** request header, the queries per second (QPS) performance of OSS is degraded. If you want to use the **x-oss-forbid-overwrite** request header to perform a large number of operations (QPS greater than 1,000), contact technical support
        /// </summary>
        [NameInMap("x-oss-forbid-overwrite")]
        [Validation(Required=false)]
        public string ForbidOverwrite { get; set; }

        /// <summary>
        /// The algorithm that is used to encrypt the object that you want to upload. If this header is not specified, the object is encrypted by using AES-256. This header is valid only when **x-oss-server-side-encryption** is set to KMS. 
        /// Valid value: SM4.
        /// </summary>
        [NameInMap("x-oss-server-side-data-encryption")]
        [Validation(Required=false)]
        public string SseDataEncryption { get; set; }

        /// <summary>
        /// The server-side encryption method that is used to encrypt each part of the object that you want to upload. 
        /// Valid values: **AES256**, **KMS**, and **SM4**.
        /// > You must activate Key Management Service (KMS) before you set this header to KMS. 
        /// 
        /// 
        /// If you specify this header in the request, this header is included in the response. OSS uses the method specified by this header to encrypt each uploaded part. When you download the object, the x-oss-server-side-encryption header is included in the response and the header value is set to the algorithm that is used to encrypt the object.
        /// </summary>
        [NameInMap("x-oss-server-side-encryption")]
        [Validation(Required=false)]
        public string ServerSideEncryption { get; set; }

        /// <summary>
        /// The ID of the CMK that is managed by KMS. 
        /// This header is valid only when **x-oss-server-side-encryption** is set to KMS.
        /// </summary>
        [NameInMap("x-oss-server-side-encryption-key-id")]
        [Validation(Required=false)]
        public string SseKeyId { get; set; }

        /// <summary>
        /// The storage class of the bucket. Default value: Standard.  Valid values:
        /// 
        /// - Standard
        /// - IA
        /// - Archive
        /// - ColdArchive
        /// </summary>
        [NameInMap("x-oss-storage-class")]
        [Validation(Required=false)]
        public string StorageClass { get; set; }

        /// <summary>
        /// The tag of the object. You can configure multiple tags for the object. Example: TagA=A&amp;TagB=B.
        /// > The key and value of a tag must be URL-encoded. If a tag does not contain an equal sign (=), the value of the tag is considered an empty string.
        /// </summary>
        [NameInMap("x-oss-tagging")]
        [Validation(Required=false)]
        public string Tagging { get; set; }

    }

}
