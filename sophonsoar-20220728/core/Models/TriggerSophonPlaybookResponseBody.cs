// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class TriggerSophonPlaybookResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public TriggerSophonPlaybookResponseBodyData Data { get; set; }
        public class TriggerSophonPlaybookResponseBodyData : TeaModel {
            [NameInMap("SophonTaskId")]
            [Validation(Required=false)]
            public string SophonTaskId { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
