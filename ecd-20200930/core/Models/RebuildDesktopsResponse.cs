// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class RebuildDesktopsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("RebuildResults")]
        [Validation(Required=true)]
        public List<RebuildDesktopsResponseRebuildResults> RebuildResults { get; set; }
        public class RebuildDesktopsResponseRebuildResults : TeaModel {
            [NameInMap("DesktopId")]
            [Validation(Required=true)]
            public string DesktopId { get; set; }

            [NameInMap("Code")]
            [Validation(Required=true)]
            public string Code { get; set; }

            [NameInMap("Message")]
            [Validation(Required=true)]
            public string Message { get; set; }

        }

    }

}
