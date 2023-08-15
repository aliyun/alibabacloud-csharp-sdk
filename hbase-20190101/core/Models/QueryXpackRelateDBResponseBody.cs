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
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("DBType")]
                [Validation(Required=false)]
                public string DBType { get; set; }

                [NameInMap("DBVersion")]
                [Validation(Required=false)]
                public string DBVersion { get; set; }

                [NameInMap("IsRelated")]
                [Validation(Required=false)]
                public bool? IsRelated { get; set; }

                [NameInMap("LockMode")]
                [Validation(Required=false)]
                public string LockMode { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
