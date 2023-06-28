// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class AsyncConfig : TeaModel {
        [NameInMap("createdTime")]
        [Validation(Required=false)]
        public string CreatedTime { get; set; }

        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        [NameInMap("functionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("lastModifiedTime")]
        [Validation(Required=false)]
        public string LastModifiedTime { get; set; }

        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
