// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListUpstreamAppKeyRelationsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RelationList")]
        [Validation(Required=false)]
        public ListUpstreamAppKeyRelationsResponseBodyRelationList RelationList { get; set; }
        public class ListUpstreamAppKeyRelationsResponseBodyRelationList : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListUpstreamAppKeyRelationsResponseBodyRelationListPagination Pagination { get; set; }
            public class ListUpstreamAppKeyRelationsResponseBodyRelationListPagination : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

            }
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListUpstreamAppKeyRelationsResponseBodyRelationListList> List { get; set; }
            public class ListUpstreamAppKeyRelationsResponseBodyRelationListList : TeaModel {
                public string AppName { get; set; }
                public string AppKey { get; set; }
                public string AppPackage { get; set; }
                public string ProjectId { get; set; }
                public long? GmtCreate { get; set; }
                public string PAppKey { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
