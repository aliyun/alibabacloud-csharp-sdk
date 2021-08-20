// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class RunTriggerNodeRequest : TeaModel {
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public long? NodeId { get; set; }

        [NameInMap("CycleTime")]
        [Validation(Required=false)]
        public long? CycleTime { get; set; }

        [NameInMap("BizDate")]
        [Validation(Required=false)]
        public long? BizDate { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=false)]
        public long? AppId { get; set; }

    }

}
