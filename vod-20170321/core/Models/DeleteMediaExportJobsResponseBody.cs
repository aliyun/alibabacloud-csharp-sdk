// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteMediaExportJobsResponseBody : TeaModel {
        [NameInMap("FailedJobIds")]
        [Validation(Required=false)]
        public List<string> FailedJobIds { get; set; }

        [NameInMap("NonExistJobIds")]
        [Validation(Required=false)]
        public List<string> NonExistJobIds { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
