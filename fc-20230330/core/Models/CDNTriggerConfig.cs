// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class CDNTriggerConfig : TeaModel {
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
