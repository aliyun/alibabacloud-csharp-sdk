// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeUidOnlineStreamsResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeUidOnlineStreamsResponseBodyData> Data { get; set; }
        public class DescribeUidOnlineStreamsResponseBodyData : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            [NameInMap("StreamName")]
            [Validation(Required=false)]
            public string StreamName { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public long? TotalNum { get; set; }

    }

}
