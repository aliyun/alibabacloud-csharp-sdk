// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20181221.Models
{
    public class DescribeFabricConsortiumConfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeFabricConsortiumConfigResponseBodyResult Result { get; set; }
        public class DescribeFabricConsortiumConfigResponseBodyResult : TeaModel {
            [NameInMap("ChannelPolicy")]
            [Validation(Required=false)]
            public List<string> ChannelPolicy { get; set; }
            [NameInMap("OrdererType")]
            [Validation(Required=false)]
            public List<string> OrdererType { get; set; }
        };

    }

}
