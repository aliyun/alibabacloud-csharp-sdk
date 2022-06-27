// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeDiagnosisDimensionsResponseBody : TeaModel {
        [NameInMap("Databases")]
        [Validation(Required=false)]
        public List<string> Databases { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UserNames")]
        [Validation(Required=false)]
        public List<string> UserNames { get; set; }

    }

}
