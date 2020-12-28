// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class SearchTracesResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTracesResponseBodyPageBean PageBean { get; set; }
        public class SearchTracesResponseBodyPageBean : TeaModel {
            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public List<SearchTracesResponseBodyPageBeanTraceInfos> TraceInfos { get; set; }
            public class SearchTracesResponseBodyPageBeanTraceInfos : TeaModel {
                public string OperationName { get; set; }
                public string ServiceIp { get; set; }
                public long? Duration { get; set; }
                public long? Timestamp { get; set; }
                public string ServiceName { get; set; }
                public string TraceID { get; set; }
            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
