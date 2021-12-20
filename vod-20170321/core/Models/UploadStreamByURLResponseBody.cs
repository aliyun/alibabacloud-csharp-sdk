// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class UploadStreamByURLResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceURL")]
        [Validation(Required=false)]
        public string SourceURL { get; set; }

        [NameInMap("StreamFileURL")]
        [Validation(Required=false)]
        public string StreamFileURL { get; set; }

        [NameInMap("StreamJobId")]
        [Validation(Required=false)]
        public string StreamJobId { get; set; }

    }

}
