// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSystemEventMetaListResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSystemEventMetaListResponseBodyData Data { get; set; }
        public class DescribeSystemEventMetaListResponseBodyData : TeaModel {
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public List<DescribeSystemEventMetaListResponseBodyDataResource> Resource { get; set; }
            public class DescribeSystemEventMetaListResponseBodyDataResource : TeaModel {
                public string EventType { get; set; }
                public string Level { get; set; }
                public string Name { get; set; }
                public string NameDesc { get; set; }
                public string NameDesc_en { get; set; }
                public string Product { get; set; }
                public string Status { get; set; }
                public string StatusDesc { get; set; }
            }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
