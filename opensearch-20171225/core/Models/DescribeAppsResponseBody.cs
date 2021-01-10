// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeAppsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<Dictionary<string, object>> Result { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
