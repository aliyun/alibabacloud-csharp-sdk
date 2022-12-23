// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetURLUploadInfosRequest : TeaModel {
        /// <summary>
        /// The one or more IDs of upload jobs. You can obtain the job IDs in the response parameter JobId of the [UploadMediaByURL](~~86311~~) operation.
        /// 
        /// - You can specify a maximum of 10 IDs.
        /// - Separate multiple IDs with commas (,).
        /// 
        /// > You must set one of the JobIds and the UploadURLs parameters. If you set both the JobIds and UploadURLs parameters, only the value of the JobIds parameter takes effect.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// The one or more upload URLs of the source files. Separate multiple URLs with commas (,). You can specify a maximum of 10 URLs.
        /// 
        /// > * You must encode the URLs before you use the URLs.
        /// > * If a media file is uploaded multiple times, pass the URL of the media file to this parameter only once.
        /// > * You must set one of the JobIds and the UploadURLs parameters. If you set both the JobIds and UploadURLs parameters, only the value of the JobIds parameter takes effect.
        /// </summary>
        [NameInMap("UploadURLs")]
        [Validation(Required=false)]
        public string UploadURLs { get; set; }

    }

}
