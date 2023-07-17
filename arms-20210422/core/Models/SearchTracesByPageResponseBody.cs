// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20210422.Models
{
    public class SearchTracesByPageResponseBody : TeaModel {
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public SearchTracesByPageResponseBodyPageBean PageBean { get; set; }
        public class SearchTracesByPageResponseBodyPageBean : TeaModel {
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public List<SearchTracesByPageResponseBodyPageBeanTraceInfos> TraceInfos { get; set; }
            public class SearchTracesByPageResponseBodyPageBeanTraceInfos : TeaModel {
                [NameInMap("Duration")]
                [Validation(Required=false)]
                public long? Duration { get; set; }

                [NameInMap("OperationName")]
                [Validation(Required=false)]
                public string OperationName { get; set; }

                [NameInMap("ServiceIp")]
                [Validation(Required=false)]
                public string ServiceIp { get; set; }

                [NameInMap("ServiceName")]
                [Validation(Required=false)]
                public string ServiceName { get; set; }

                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public long? Timestamp { get; set; }

                [NameInMap("TraceID")]
                [Validation(Required=false)]
                public string TraceID { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
