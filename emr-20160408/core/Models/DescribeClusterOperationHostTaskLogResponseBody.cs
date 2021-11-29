// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20160408.Models
{
    public class DescribeClusterOperationHostTaskLogResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Stderr")]
        [Validation(Required=false)]
        public string Stderr { get; set; }

        [NameInMap("Stdout")]
        [Validation(Required=false)]
        public string Stdout { get; set; }

    }

}
