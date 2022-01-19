// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Jarvis_public20180621.Models
{
    public class DescribeAccessWhitelistEcsListResponseBody : TeaModel {
        [NameInMap("EcsList")]
        [Validation(Required=false)]
        public List<DescribeAccessWhitelistEcsListResponseBodyEcsList> EcsList { get; set; }
        public class DescribeAccessWhitelistEcsListResponseBodyEcsList : TeaModel {
            [NameInMap("IP")]
            [Validation(Required=false)]
            public string IP { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("module")]
        [Validation(Required=false)]
        public string Module { get; set; }

    }

}
