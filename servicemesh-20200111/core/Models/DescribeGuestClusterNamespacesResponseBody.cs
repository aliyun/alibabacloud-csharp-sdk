// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeGuestClusterNamespacesResponseBody : TeaModel {
        [NameInMap("NsLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> NsLabels { get; set; }

        [NameInMap("NsList")]
        [Validation(Required=false)]
        public List<string> NsList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
