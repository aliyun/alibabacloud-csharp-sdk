// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListFCTriggerRequest : TeaModel {
        [NameInMap("EventMetaName")]
        [Validation(Required=false)]
        public string EventMetaName { get; set; }

        [NameInMap("EventMetaVersion")]
        [Validation(Required=false)]
        public string EventMetaVersion { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

    }

}
