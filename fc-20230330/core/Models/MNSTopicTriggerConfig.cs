// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class MNSTopicTriggerConfig : TeaModel {
        [NameInMap("filterTag")]
        [Validation(Required=false)]
        public string FilterTag { get; set; }

        [NameInMap("notifyContentFormat")]
        [Validation(Required=false)]
        public string NotifyContentFormat { get; set; }

        [NameInMap("notifyStrategy")]
        [Validation(Required=false)]
        public string NotifyStrategy { get; set; }

    }

}
