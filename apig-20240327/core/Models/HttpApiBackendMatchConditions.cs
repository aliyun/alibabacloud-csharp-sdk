// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class HttpApiBackendMatchConditions : TeaModel {
        [NameInMap("conditions")]
        [Validation(Required=false)]
        public List<HttpApiBackendMatchCondition> Conditions { get; set; }

        [NameInMap("default")]
        [Validation(Required=false)]
        public bool? Default { get; set; }

    }

}
