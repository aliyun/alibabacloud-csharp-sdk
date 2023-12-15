// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeFabricChannelConfigResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeFabricChannelConfigResponseBodyResult Result { get; set; }
        public class DescribeFabricChannelConfigResponseBodyResult : TeaModel {
            [NameInMap("AbsoluteMaxBytes")]
            [Validation(Required=false)]
            public long? AbsoluteMaxBytes { get; set; }

            [NameInMap("BatchTimeout")]
            [Validation(Required=false)]
            public string BatchTimeout { get; set; }

            [NameInMap("MaxMessageCount")]
            [Validation(Required=false)]
            public long? MaxMessageCount { get; set; }

            [NameInMap("PreferredMaxBytes")]
            [Validation(Required=false)]
            public long? PreferredMaxBytes { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
