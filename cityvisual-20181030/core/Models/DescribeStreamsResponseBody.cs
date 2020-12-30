// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cityvisual20181030.Models
{
    public class DescribeStreamsResponseBody : TeaModel {
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("Streams")]
        [Validation(Required=false)]
        public DescribeStreamsResponseBodyStreams Streams { get; set; }
        public class DescribeStreamsResponseBodyStreams : TeaModel {
            [NameInMap("Stream")]
            [Validation(Required=false)]
            public List<DescribeStreamsResponseBodyStreamsStream> Stream { get; set; }
            public class DescribeStreamsResponseBodyStreamsStream : TeaModel {
                public int? JobGroupId { get; set; }
                public string StreamName { get; set; }
                public string ComputeJobId { get; set; }
                public int? ObjCount { get; set; }
                public int? DelayMS { get; set; }
                public string StreamURL { get; set; }
            }
        };

    }

}
