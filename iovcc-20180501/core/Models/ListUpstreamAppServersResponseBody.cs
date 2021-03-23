// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListUpstreamAppServersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("AppServers")]
        [Validation(Required=false)]
        public ListUpstreamAppServersResponseBodyAppServers AppServers { get; set; }
        public class ListUpstreamAppServersResponseBodyAppServers : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListUpstreamAppServersResponseBodyAppServersList> List { get; set; }
            public class ListUpstreamAppServersResponseBodyAppServersList : TeaModel {
                public long? Id { get; set; }
                public string PAppKey { get; set; }
                public string ProjectId { get; set; }
                public string Name { get; set; }
                public string Tags { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string QueueNameList { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListUpstreamAppServersResponseBodyAppServersPagination Pagination { get; set; }
            public class ListUpstreamAppServersResponseBodyAppServersPagination : TeaModel {
                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }
        };

    }

}
