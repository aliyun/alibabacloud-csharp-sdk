// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class MnsTopicTriggerConfig : TeaModel {
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
