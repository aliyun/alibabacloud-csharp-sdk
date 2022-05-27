// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Viapi_regen20211119.Models
{
    public class ListWorkspacesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListWorkspacesResponseBodyData Data { get; set; }
        public class ListWorkspacesResponseBodyData : TeaModel {
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public long? CurrentPage { get; set; }
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ListWorkspacesResponseBodyDataElements> Elements { get; set; }
            public class ListWorkspacesResponseBodyDataElements : TeaModel {
                public string Description { get; set; }
                public long? GmtCreate { get; set; }
                public long? Id { get; set; }
                public string Name { get; set; }
                public string Type { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public long? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("TotalPage")]
            [Validation(Required=false)]
            public long? TotalPage { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
