// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeUserAssetIPTrafficInfoResponseBody : TeaModel {
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        [NameInMap("InBps")]
        [Validation(Required=false)]
        public long? InBps { get; set; }

        [NameInMap("InPps")]
        [Validation(Required=false)]
        public long? InPps { get; set; }

        [NameInMap("NewConn")]
        [Validation(Required=false)]
        public long? NewConn { get; set; }

        [NameInMap("OutBps")]
        [Validation(Required=false)]
        public long? OutBps { get; set; }

        [NameInMap("OutPps")]
        [Validation(Required=false)]
        public long? OutPps { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SessionCount")]
        [Validation(Required=false)]
        public long? SessionCount { get; set; }

        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
