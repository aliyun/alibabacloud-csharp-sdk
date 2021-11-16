// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListConnectedClustersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public ListConnectedClustersResponseBodyResult Result { get; set; }
        public class ListConnectedClustersResponseBodyResult : TeaModel {
            [NameInMap("Result")]
            [Validation(Required=false)]
            public List<ListConnectedClustersResponseBodyResultResult> Result { get; set; }
            public class ListConnectedClustersResponseBodyResultResult : TeaModel {
                public string Instances { get; set; }
                public string NetworkType { get; set; }
            }
        };

    }

}
