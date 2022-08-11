// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC_Open20210406.Models
{
    public class PutFunctionAsyncInvokeConfigRequest : TeaModel {
        [NameInMap("destinationConfig")]
        [Validation(Required=false)]
        public DestinationConfig DestinationConfig { get; set; }

        [NameInMap("maxAsyncEventAgeInSeconds")]
        [Validation(Required=false)]
        public long? MaxAsyncEventAgeInSeconds { get; set; }

        [NameInMap("maxAsyncRetryAttempts")]
        [Validation(Required=false)]
        public long? MaxAsyncRetryAttempts { get; set; }

        [NameInMap("statefulInvocation")]
        [Validation(Required=false)]
        public bool? StatefulInvocation { get; set; }

        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

    }

}
