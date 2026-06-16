// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentLoop20260520.Models
{
    public class RunStrategies : TeaModel {
        [NameInMap("backfill")]
        [Validation(Required=false)]
        public BackfillStrategy Backfill { get; set; }

        [NameInMap("continuous")]
        [Validation(Required=false)]
        public ContinuousStrategy Continuous { get; set; }

    }

}
