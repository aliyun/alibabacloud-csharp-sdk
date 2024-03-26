// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GenerateDownloadSecretKeyResponseBody : TeaModel {
        /// <summary>
        /// The key file for secure download.
        /// </summary>
        [NameInMap("AppEncryptKey")]
        [Validation(Required=false)]
        public string AppEncryptKey { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
