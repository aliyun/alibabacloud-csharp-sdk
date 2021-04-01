// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDDoSTrafficResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DefenseInBytes")]
        [Validation(Required=true)]
        public long? DefenseInBytes { get; set; }

        [NameInMap("SourceInBytes")]
        [Validation(Required=true)]
        public long? SourceInBytes { get; set; }

        [NameInMap("DDoSTrafficPoints")]
        [Validation(Required=true)]
        public List<DescribeDDoSTrafficResponseDDoSTrafficPoints> DDoSTrafficPoints { get; set; }
        public class DescribeDDoSTrafficResponseDDoSTrafficPoints : TeaModel {
            [NameInMap("Time")]
            [Validation(Required=true)]
            public long? Time { get; set; }

            [NameInMap("DefenseMaxInBps")]
            [Validation(Required=true)]
            public long? DefenseMaxInBps { get; set; }

            [NameInMap("SourceMaxInBps")]
            [Validation(Required=true)]
            public long? SourceMaxInBps { get; set; }

        }

    }

}
