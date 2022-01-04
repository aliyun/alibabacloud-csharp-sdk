// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicemesh20200111.Models
{
    public class DescribeVersionsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("VersionInfo")]
        [Validation(Required=false)]
        public List<DescribeVersionsResponseBodyVersionInfo> VersionInfo { get; set; }
        public class DescribeVersionsResponseBodyVersionInfo : TeaModel {
            [NameInMap("Edition")]
            [Validation(Required=false)]
            public string Edition { get; set; }

            [NameInMap("Versions")]
            [Validation(Required=false)]
            public List<string> Versions { get; set; }

        }

    }

}
