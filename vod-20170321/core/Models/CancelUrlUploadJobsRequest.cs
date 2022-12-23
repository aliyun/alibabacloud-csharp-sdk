// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class CancelUrlUploadJobsRequest : TeaModel {
        /// <summary>
        /// The IDs of the upload jobs. You can obtain the job IDs in the response parameter PlayInfo of the [GetPlayInfo](~~56124~~) operation.
        /// *   You can specify a maximum of 10 IDs.
        /// *   Separate multiple IDs with commas (,).
        /// > You must set one of the JobIds and the UploadUrls parameters. If you set both the JobIds and UploadUrls parameters, only the value of the JobIds parameter takes effect.
        /// </summary>
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        /// <summary>
        /// The upload URLs of source files. Separate multiple URLs with commas (,). You can specify a maximum of 10 URLs.
        /// > *   You must encode the URLs before you use the URLs.
        /// > *   You must set one of the JobIds and the UploadUrls parameters. If you set both the JobIds and UploadUrls parameters, only the value of the JobIds parameter takes effect.
        /// </summary>
        [NameInMap("UploadUrls")]
        [Validation(Required=false)]
        public string UploadUrls { get; set; }

    }

}
