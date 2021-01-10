// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTTracesResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Traces")]
        [Validation(Required=false)]
        public List<ListDSTTracesResponseBodyTraces> Traces { get; set; }
        public class ListDSTTracesResponseBodyTraces : TeaModel {
            [NameInMap("Collected")]
            [Validation(Required=false)]
            public bool? Collected { get; set; }

            [NameInMap("CollectedDescription")]
            [Validation(Required=false)]
            public string CollectedDescription { get; set; }

            [NameInMap("CollectedName")]
            [Validation(Required=false)]
            public string CollectedName { get; set; }

            [NameInMap("CollectedTime")]
            [Validation(Required=false)]
            public string CollectedTime { get; set; }

            [NameInMap("CollectedUserName")]
            [Validation(Required=false)]
            public string CollectedUserName { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

        }

    }

}
