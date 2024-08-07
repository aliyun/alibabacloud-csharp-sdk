// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiBackendMatchCondition : TeaModel {
        [NameInMap("key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        [NameInMap("operator")]
        [Validation(Required=false)]
        public string Operator { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        [NameInMap("value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
