// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchTracesByPageResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTracesByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchTracesByPageResponseBodyPageBean : TeaModel {
            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public List<SearchTracesByPageResponseBodyPageBeanTraceInfos> TraceInfos { get; set; }
            public class SearchTracesByPageResponseBodyPageBeanTraceInfos : TeaModel {
                public string OperationName { get; set; }
                public string ServiceIp { get; set; }
                public long? Duration { get; set; }
                public long? Timestamp { get; set; }
                public string ServiceName { get; set; }
                public string TraceID { get; set; }
            }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
