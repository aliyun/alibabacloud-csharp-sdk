// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListDiagnosticsRequest : TeaModel {
        [NameInMap("DiagnosticKey")]
        [Validation(Required=false)]
        public string DiagnosticKey { get; set; }

        [NameInMap("DiagnosticProduct")]
        [Validation(Required=false)]
        public string DiagnosticProduct { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
