// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class BatchWindow : TeaModel {
        [NameInMap("CountBasedWindow")]
        [Validation(Required=false)]
        public int? CountBasedWindow { get; set; }

        [NameInMap("TimeBasedWindow")]
        [Validation(Required=false)]
        public int? TimeBasedWindow { get; set; }

    }

}
