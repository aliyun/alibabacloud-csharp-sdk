// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class RunOptions : TeaModel {
        [NameInMap("batchWindow")]
        [Validation(Required=false)]
        public BatchWindow BatchWindow { get; set; }

        [NameInMap("deadLetterQueue")]
        [Validation(Required=false)]
        public DeadLetterQueue DeadLetterQueue { get; set; }

        [NameInMap("errorsTolerance")]
        [Validation(Required=false)]
        public string ErrorsTolerance { get; set; }

        [NameInMap("mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        [NameInMap("retryStrategy")]
        [Validation(Required=false)]
        public RetryStrategy RetryStrategy { get; set; }

    }

}
