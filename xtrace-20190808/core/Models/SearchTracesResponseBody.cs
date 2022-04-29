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
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("TraceInfos")]
            [Validation(Required=false)]
            public SearchTracesResponseBodyPageBeanTraceInfos TraceInfos { get; set; }
            public class SearchTracesResponseBodyPageBeanTraceInfos : TeaModel {
                [NameInMap("TraceInfo")]
                [Validation(Required=false)]
                public List<SearchTracesResponseBodyPageBeanTraceInfosTraceInfo> TraceInfo { get; set; }
                public class SearchTracesResponseBodyPageBeanTraceInfosTraceInfo : TeaModel {
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

                    [NameInMap("TagMap")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> TagMap { get; set; }

                    [NameInMap("Timestamp")]
                    [Validation(Required=false)]
                    public long? Timestamp { get; set; }

                    [NameInMap("TraceID")]
                    [Validation(Required=false)]
                    public string TraceID { get; set; }

                }

            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
