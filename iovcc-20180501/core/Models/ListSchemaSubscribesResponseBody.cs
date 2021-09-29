// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListSchemaSubscribesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageList")]
        [Validation(Required=false)]
        public List<ListSchemaSubscribesResponseBodyPageList> PageList { get; set; }
        public class ListSchemaSubscribesResponseBodyPageList : TeaModel {
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListSchemaSubscribesResponseBodyPageListPagination Pagination { get; set; }
            public class ListSchemaSubscribesResponseBodyPageListPagination : TeaModel {
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
                [NameInMap("SimpleSign")]
                [Validation(Required=false)]
                public bool? SimpleSign { get; set; }
                [NameInMap("HasNextPage")]
                [Validation(Required=false)]
                public bool? HasNextPage { get; set; }
            };

            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListSchemaSubscribesResponseBodyPageListList> List { get; set; }
            public class ListSchemaSubscribesResponseBodyPageListList : TeaModel {
                [NameInMap("DeviceModelId")]
                [Validation(Required=false)]
                public long? DeviceModelId { get; set; }

                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public string ProjectId { get; set; }

                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public long? GmtCreate { get; set; }

                [NameInMap("Namespace")]
                [Validation(Required=false)]
                public string Namespace { get; set; }

                [NameInMap("ValiditySchema")]
                [Validation(Required=false)]
                public string ValiditySchema { get; set; }

                [NameInMap("DeviceModel")]
                [Validation(Required=false)]
                public string DeviceModel { get; set; }

                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public long? GmtModified { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

            }

        }

    }

}
