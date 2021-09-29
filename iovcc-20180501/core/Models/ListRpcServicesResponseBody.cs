// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListRpcServicesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RpcServices")]
        [Validation(Required=false)]
        public ListRpcServicesResponseBodyRpcServices RpcServices { get; set; }
        public class ListRpcServicesResponseBodyRpcServices : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListRpcServicesResponseBodyRpcServicesPagination Pagination { get; set; }
            public class ListRpcServicesResponseBodyRpcServicesPagination : TeaModel {
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
            public List<ListRpcServicesResponseBodyRpcServicesList> List { get; set; }
            public class ListRpcServicesResponseBodyRpcServicesList : TeaModel {
                public string MethodName { get; set; }
                public string Type { get; set; }
                public string InterfaceName { get; set; }
                public string Params { get; set; }
                public string AppKey { get; set; }
                public string GroupName { get; set; }
                public long? GmtCreate { get; set; }
                public string IsDelete { get; set; }
                public string VersionCode { get; set; }
                public long? GmtModified { get; set; }
                public long? Id { get; set; }
            }
        };

    }

}
