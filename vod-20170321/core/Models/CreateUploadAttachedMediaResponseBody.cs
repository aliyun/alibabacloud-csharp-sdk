// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CreateUploadAttachedMediaResponseBody : TeaModel {
        /// <summary>
        /// The URL of the auxiliary media asset file. The URL is an Object Storage Service (OSS) URL and does not contain the information used for URL signing.
        /// 
        /// You can use specify this value for the `FileUrl` parameter when you call the [AddWatermark](~~AddWatermark~~) operation to create a watermark template.
        /// </summary>
        [NameInMap("FileURL")]
        [Validation(Required=false)]
        public string FileURL { get; set; }

        /// <summary>
        /// The ID of the auxiliary media asset.
        /// </summary>
        [NameInMap("MediaId")]
        [Validation(Required=false)]
        public string MediaId { get; set; }

        /// <summary>
        /// The URL of the auxiliary media asset.
        /// 
        /// If a domain name for Alibaba Cloud CDN is specified, a CDN URL is returned. Otherwise, an OSS URL is returned.
        /// 
        /// >  If you enable the URL signing feature of ApsaraVideo VOD, you may be unable to access the returned URL of the auxiliary media asset by using a browser and the HTTP status code 403 may be returned. To resolve this issue, you can disable the [URL signing](https://help.aliyun.com/document_detail/86090.html) feature or [generate a signed URL](https://help.aliyun.com/document_detail/57007.html).
        /// </summary>
        [NameInMap("MediaURL")]
        [Validation(Required=false)]
        public string MediaURL { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The upload URL.
        /// 
        /// >  The upload URL returned by this operation is Base64-encoded. Before you can use an SDK or an API operation to upload a media asset based on the upload URL, you must decode the upload URL by using the Base64 algorithm. You must parse the upload URL only if you use native OSS SDKs or OSS API for uploads.
        /// </summary>
        [NameInMap("UploadAddress")]
        [Validation(Required=false)]
        public string UploadAddress { get; set; }

        /// <summary>
        /// The upload credential.
        /// 
        /// >  The upload credential returned by this operation is Base64-encoded. Before you can use an SDK or an API operation to upload a media asset based on the upload credential, you must decode the upload credential by using the Base64 algorithm. You must parse the upload credential only if you use native OSS SDKs or OSS API for uploads.
        /// </summary>
        [NameInMap("UploadAuth")]
        [Validation(Required=false)]
        public string UploadAuth { get; set; }

    }

}
