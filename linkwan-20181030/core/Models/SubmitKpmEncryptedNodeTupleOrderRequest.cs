// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.LinkWAN20181030.Models
{
    public class SubmitKpmEncryptedNodeTupleOrderRequest : TeaModel {
        [NameInMap("ApiProduct")]
        [Validation(Required=false)]
        public string ApiProduct { get; set; }

        [NameInMap("ApiRevision")]
        [Validation(Required=false)]
        public string ApiRevision { get; set; }

        [NameInMap("LoraVersion")]
        [Validation(Required=false)]
        public string LoraVersion { get; set; }

        [NameInMap("RequiredCount")]
        [Validation(Required=false)]
        public long? RequiredCount { get; set; }

    }

}
