// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourceAccessedPortsResponseBody : TeaModel {
        [NameInMap("Http")]
        [Validation(Required=false)]
        public List<int?> Http { get; set; }

        [NameInMap("Https")]
        [Validation(Required=false)]
        public List<int?> Https { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
