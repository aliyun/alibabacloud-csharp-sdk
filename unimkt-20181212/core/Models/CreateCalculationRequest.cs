// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.UniMkt20181212.Models
{
    public class CreateCalculationRequest : TeaModel {
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        [NameInMap("CloudCodeUserId")]
        [Validation(Required=false)]
        public string CloudCodeUserId { get; set; }

        [NameInMap("QueryString")]
        [Validation(Required=false)]
        public string QueryString { get; set; }

    }

}
