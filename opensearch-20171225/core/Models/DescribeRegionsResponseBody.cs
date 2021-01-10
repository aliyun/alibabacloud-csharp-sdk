// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyResult> Result { get; set; }
        public class DescribeRegionsResponseBodyResult : TeaModel {
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("localName")]
            [Validation(Required=false)]
            public string LocalName { get; set; }

            [NameInMap("consoleUrl")]
            [Validation(Required=false)]
            public string ConsoleUrl { get; set; }

        }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
