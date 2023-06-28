// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutAsyncInvokeConfigInput : TeaModel {
        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

    }

}
