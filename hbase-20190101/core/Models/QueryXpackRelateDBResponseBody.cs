// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class QueryXpackRelateDBResponseBody : TeaModel {
        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public QueryXpackRelateDBResponseBodyClusterList ClusterList { get; set; }
        public class QueryXpackRelateDBResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<QueryXpackRelateDBResponseBodyClusterListCluster> Cluster { get; set; }
            public class QueryXpackRelateDBResponseBodyClusterListCluster : TeaModel {
                public string Status { get; set; }
                public string DBVersion { get; set; }
                public bool? IsRelated { get; set; }
                public string ClusterName { get; set; }
                public string DBType { get; set; }
                public string LockMode { get; set; }
                public string ClusterId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
