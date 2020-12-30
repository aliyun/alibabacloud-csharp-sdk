// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDDoSTrafficResponseBody : TeaModel {
        [NameInMap("DefenseInBytes")]
        [Validation(Required=false)]
        public long? DefenseInBytes { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceInBytes")]
        [Validation(Required=false)]
        public long? SourceInBytes { get; set; }

        [NameInMap("DDoSTrafficPoints")]
        [Validation(Required=false)]
        public List<DescribeDDoSTrafficResponseBodyDDoSTrafficPoints> DDoSTrafficPoints { get; set; }
        public class DescribeDDoSTrafficResponseBodyDDoSTrafficPoints : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=false)]
            public long? Time { get; set; }

            [NameInMap("SourceMaxInBps")]
            [Validation(Required=false)]
            public long? SourceMaxInBps { get; set; }

            [NameInMap("DefenseMaxInBps")]
            [Validation(Required=false)]
            public long? DefenseMaxInBps { get; set; }

        }

    }

}
