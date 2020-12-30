// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class QueryHBaseHaDBResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("ClusterList")]
        [Validation(Required=false)]
        public QueryHBaseHaDBResponseBodyClusterList ClusterList { get; set; }
        public class QueryHBaseHaDBResponseBodyClusterList : TeaModel {
            [NameInMap("Cluster")]
            [Validation(Required=false)]
            public List<QueryHBaseHaDBResponseBodyClusterListCluster> Cluster { get; set; }
            public class QueryHBaseHaDBResponseBodyClusterListCluster : TeaModel {
                public string HaName { get; set; }
                public string BdsName { get; set; }
                public QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnList HaSlbConnList { get; set; }
                public class QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnList : TeaModel {
                    [NameInMap("HaSlbConn")]
                    [Validation(Required=false)]
                    public List<QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnListHaSlbConn> HaSlbConn { get; set; }
                    public class QueryHBaseHaDBResponseBodyClusterListClusterHaSlbConnListHaSlbConn : TeaModel {
                        [NameInMap("SlbConnAddr")]
                        [Validation(Required=false)]
                        public string SlbConnAddr { get; set; }

                        [NameInMap("HbaseType")]
                        [Validation(Required=false)]
                        public string HbaseType { get; set; }

                        [NameInMap("SlbType")]
                        [Validation(Required=false)]
                        public string SlbType { get; set; }

                    }

                }
                public string ActiveName { get; set; }
                public string StandbyName { get; set; }
            }
        };

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

    }

}
