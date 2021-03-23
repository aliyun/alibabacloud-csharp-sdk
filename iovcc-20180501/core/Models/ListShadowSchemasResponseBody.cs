// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListShadowSchemasResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageList")]
        [Validation(Required=false)]
        public ListShadowSchemasResponseBodyPageList PageList { get; set; }
        public class ListShadowSchemasResponseBodyPageList : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListShadowSchemasResponseBodyPageListList> List { get; set; }
            public class ListShadowSchemasResponseBodyPageListList : TeaModel {
                public string AuthTypeDesc { get; set; }
                public long? Id { get; set; }
                public string ProjectId { get; set; }
                public long? DeviceModelId { get; set; }
                public string DeviceModel { get; set; }
                public string ModuleSchema { get; set; }
                public string Namespace { get; set; }
                public int? AuthType { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListShadowSchemasResponseBodyPageListPagination Pagination { get; set; }
            public class ListShadowSchemasResponseBodyPageListPagination : TeaModel {
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

                [NameInMap("SimpleSign")]
                [Validation(Required=false)]
                public bool? SimpleSign { get; set; }

                [NameInMap("HasNextPage")]
                [Validation(Required=false)]
                public bool? HasNextPage { get; set; }

            }
        };

    }

}
