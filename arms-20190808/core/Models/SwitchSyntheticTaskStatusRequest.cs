// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SwitchSyntheticTaskStatusRequest : TeaModel {
        [NameInMap("SwitchStatus")]
        [Validation(Required=false)]
        public long? SwitchStatus { get; set; }

        [NameInMap("TaskIds")]
        [Validation(Required=false)]
        public List<long?> TaskIds { get; set; }

    }

}
