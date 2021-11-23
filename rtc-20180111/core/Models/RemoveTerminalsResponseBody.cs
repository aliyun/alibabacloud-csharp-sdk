// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class RemoveTerminalsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Terminals")]
        [Validation(Required=false)]
        public RemoveTerminalsResponseBodyTerminals Terminals { get; set; }
        public class RemoveTerminalsResponseBodyTerminals : TeaModel {
            [NameInMap("Terminal")]
            [Validation(Required=false)]
            public List<RemoveTerminalsResponseBodyTerminalsTerminal> Terminal { get; set; }
            public class RemoveTerminalsResponseBodyTerminalsTerminal : TeaModel {
                public int? Code { get; set; }
                public string Id { get; set; }
                public string Message { get; set; }
            }
        };

    }

}
