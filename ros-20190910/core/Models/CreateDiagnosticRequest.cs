// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateDiagnosticRequest : TeaModel {
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        [NameInMap("DiagnosticType")]
        [Validation(Required=false)]
        public string DiagnosticType { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

    }

}
