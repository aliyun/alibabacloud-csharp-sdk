// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class BatchWindow : TeaModel {
        [NameInMap("CountBasedWindow")]
        [Validation(Required=false)]
        public long? CountBasedWindow { get; set; }

        [NameInMap("TimeBasedWindow")]
        [Validation(Required=false)]
        public long? TimeBasedWindow { get; set; }

    }

}
