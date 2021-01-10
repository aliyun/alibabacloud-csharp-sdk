// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class ListDSTSpansResponseBody : TeaModel {
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

        [NameInMap("Spans")]
        [Validation(Required=false)]
        public List<ListDSTSpansResponseBodySpans> Spans { get; set; }
        public class ListDSTSpansResponseBodySpans : TeaModel {
            [NameInMap("BasicInfo")]
            [Validation(Required=false)]
            public string BasicInfo { get; set; }

            [NameInMap("Component")]
            [Validation(Required=false)]
            public string Component { get; set; }

            [NameInMap("Duration")]
            [Validation(Required=false)]
            public long? Duration { get; set; }

            [NameInMap("EnvInstanceId")]
            [Validation(Required=false)]
            public string EnvInstanceId { get; set; }

            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            [NameInMap("LocalInfo")]
            [Validation(Required=false)]
            public string LocalInfo { get; set; }

            [NameInMap("LocalIpv4")]
            [Validation(Required=false)]
            public string LocalIpv4 { get; set; }

            [NameInMap("LocalServiceName")]
            [Validation(Required=false)]
            public string LocalServiceName { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("ParentId")]
            [Validation(Required=false)]
            public string ParentId { get; set; }

            [NameInMap("RemoteInfo")]
            [Validation(Required=false)]
            public string RemoteInfo { get; set; }

            [NameInMap("RemoteIpv4")]
            [Validation(Required=false)]
            public string RemoteIpv4 { get; set; }

            [NameInMap("RemoteServiceName")]
            [Validation(Required=false)]
            public string RemoteServiceName { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public string Result { get; set; }

            [NameInMap("SpanId")]
            [Validation(Required=false)]
            public string SpanId { get; set; }

            [NameInMap("StartTime")]
            [Validation(Required=false)]
            public long? StartTime { get; set; }

            [NameInMap("TraceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<ListDSTSpansResponseBodySpansTags> Tags { get; set; }
            public class ListDSTSpansResponseBodySpansTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
