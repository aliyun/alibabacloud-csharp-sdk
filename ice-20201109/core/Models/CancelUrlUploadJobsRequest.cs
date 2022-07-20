// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CancelUrlUploadJobsRequest : TeaModel {
        [NameInMap("JobIds")]
        [Validation(Required=false)]
        public string JobIds { get; set; }

        [NameInMap("UploadUrls")]
        [Validation(Required=false)]
        public string UploadUrls { get; set; }

    }

}
