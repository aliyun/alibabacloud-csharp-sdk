// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetLogMetaResponseBody : TeaModel {
        [NameInMap("LogMeta")]
        [Validation(Required=false)]
        public GetLogMetaResponseBodyLogMeta LogMeta { get; set; }
        public class GetLogMetaResponseBodyLogMeta : TeaModel {
            [NameInMap("LogStore")]
            [Validation(Required=false)]
            public string LogStore { get; set; }

            [NameInMap("Project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
