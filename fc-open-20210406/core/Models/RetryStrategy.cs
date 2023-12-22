// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class RetryStrategy : TeaModel {
        [NameInMap("MaximumEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaximumEventAgeInSeconds { get; set; }

        [NameInMap("MaximumRetryAttempts")]
        [Validation(Required=false)]
        public long? MaximumRetryAttempts { get; set; }

        [NameInMap("PushRetryStrategy")]
        [Validation(Required=false)]
        public string PushRetryStrategy { get; set; }

    }

}
