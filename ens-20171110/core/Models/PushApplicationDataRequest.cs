// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PushApplicationDataRequest : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=true)]
        public string Data { get; set; }

        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

        [NameInMap("PushStrategy")]
        [Validation(Required=false)]
        public string PushStrategy { get; set; }

    }

}
