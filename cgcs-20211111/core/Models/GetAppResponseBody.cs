// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class GetAppResponseBody : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        [NameInMap("GmtCreate")]
        [Validation(Required=false)]
        public string GmtCreate { get; set; }

        [NameInMap("GmtModified")]
        [Validation(Required=false)]
        public string GmtModified { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("StreamingAppId")]
        [Validation(Required=false)]
        public string StreamingAppId { get; set; }

        [NameInMap("StreamingSolution")]
        [Validation(Required=false)]
        public string StreamingSolution { get; set; }

        [NameInMap("VersionAdaptNum")]
        [Validation(Required=false)]
        public long? VersionAdaptNum { get; set; }

        [NameInMap("VersionTotalNum")]
        [Validation(Required=false)]
        public long? VersionTotalNum { get; set; }

    }

}
