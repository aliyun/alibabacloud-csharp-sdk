// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DistApplicationDataRequest : TeaModel {
        [NameInMap("AppId")]
        [Validation(Required=true)]
        public string AppId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public string Data { get; set; }

        [NameInMap("DistStrategy")]
        [Validation(Required=false)]
        public string DistStrategy { get; set; }

    }

}
