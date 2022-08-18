// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class CDNEventsTriggerConfig : TeaModel {
        [NameInMap("eventName")]
        [Validation(Required=false)]
        public string EventName { get; set; }

        [NameInMap("eventVersion")]
        [Validation(Required=false)]
        public string EventVersion { get; set; }

        [NameInMap("filter")]
        [Validation(Required=false)]
        public Dictionary<string, List<string>> Filter { get; set; }

        [NameInMap("notes")]
        [Validation(Required=false)]
        public string Notes { get; set; }

    }

}
