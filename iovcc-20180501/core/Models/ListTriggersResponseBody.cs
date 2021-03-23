// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class ListTriggersResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TriggerList")]
        [Validation(Required=false)]
        public ListTriggersResponseBodyTriggerList TriggerList { get; set; }
        public class ListTriggersResponseBodyTriggerList : TeaModel {
            [NameInMap("Triggers")]
            [Validation(Required=false)]
            public List<ListTriggersResponseBodyTriggerListTriggers> Triggers { get; set; }
            public class ListTriggersResponseBodyTriggerListTriggers : TeaModel {
                public long? Id { get; set; }
                public string Namespace { get; set; }
                public string Source { get; set; }
                public long? GmtCreate { get; set; }
                public long? GmtModified { get; set; }
                public string ChainedFunctionIds { get; set; }
                public int? Type { get; set; }
                public int? Status { get; set; }
                public int? InvocationMode { get; set; }
                public int? Sandbox { get; set; }
                public int? Production { get; set; }
                public List<ListTriggersResponseBodyTriggerListTriggersFunctions> Functions { get; set; }
                public class ListTriggersResponseBodyTriggerListTriggersFunctions : TeaModel {
                    public long? Id { get; set; }
                    public string Name { get; set; }
                    public long? FileId { get; set; }
                    public string FileName { get; set; }
                    public long? GmtCreate { get; set; }
                    public long? GmtModified { get; set; }
                }
            }
            [NameInMap("Pagination")]
            [Validation(Required=false)]
            public ListTriggersResponseBodyTriggerListPagination Pagination { get; set; }
            public class ListTriggersResponseBodyTriggerListPagination : TeaModel {
                [NameInMap("PageIndex")]
                [Validation(Required=false)]
                public int? PageIndex { get; set; }

                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

                [NameInMap("TotalCount")]
                [Validation(Required=false)]
                public int? TotalCount { get; set; }

                [NameInMap("TotalPageCount")]
                [Validation(Required=false)]
                public int? TotalPageCount { get; set; }

            }
        };

    }

}
