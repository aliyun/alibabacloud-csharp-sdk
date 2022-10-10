// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class EvaluateRegionResourceResponseBody : TeaModel {
        [NameInMap("DBInstanceAvailable")]
        [Validation(Required=false)]
        public string DBInstanceAvailable { get; set; }

        [NameInMap("DBType")]
        [Validation(Required=false)]
        public string DBType { get; set; }

        [NameInMap("DBVersion")]
        [Validation(Required=false)]
        public string DBVersion { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
