// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ModifyEventTaskStatusRequest : TeaModel {
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public string EventId { get; set; }

        [NameInMap("Ids")]
        [Validation(Required=false)]
        public string Ids { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        [NameInMap("SwitchTime")]
        [Validation(Required=false)]
        public long? SwitchTime { get; set; }

    }

}
