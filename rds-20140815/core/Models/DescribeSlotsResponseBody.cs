// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeSlotsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Slots")]
        [Validation(Required=false)]
        public List<DescribeSlotsResponseBodySlots> Slots { get; set; }
        public class DescribeSlotsResponseBodySlots : TeaModel {
            [NameInMap("Database")]
            [Validation(Required=false)]
            public string Database { get; set; }

            [NameInMap("Plugin")]
            [Validation(Required=false)]
            public string Plugin { get; set; }

            [NameInMap("SlotName")]
            [Validation(Required=false)]
            public string SlotName { get; set; }

            [NameInMap("SlotStatus")]
            [Validation(Required=false)]
            public string SlotStatus { get; set; }

            [NameInMap("SlotType")]
            [Validation(Required=false)]
            public string SlotType { get; set; }

            [NameInMap("SubReplayLag")]
            [Validation(Required=false)]
            public string SubReplayLag { get; set; }

            [NameInMap("Temporary")]
            [Validation(Required=false)]
            public string Temporary { get; set; }

            [NameInMap("WalDelay")]
            [Validation(Required=false)]
            public string WalDelay { get; set; }

        }

    }

}
