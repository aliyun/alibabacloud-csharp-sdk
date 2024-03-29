// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class DescribeConnectableClustersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeConnectableClustersResponseBodyResult> Result { get; set; }
        public class DescribeConnectableClustersResponseBodyResult : TeaModel {
            [NameInMap("instances")]
            [Validation(Required=false)]
            public string Instances { get; set; }

            [NameInMap("networkType")]
            [Validation(Required=false)]
            public string NetworkType { get; set; }

        }

    }

}
