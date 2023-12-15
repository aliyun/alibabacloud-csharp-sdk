// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeConsortiumConfigResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public DescribeConsortiumConfigResponseBodyResult Result { get; set; }
        public class DescribeConsortiumConfigResponseBodyResult : TeaModel {
            [NameInMap("ChannelPolicy")]
            [Validation(Required=false)]
            public List<string> ChannelPolicy { get; set; }

            [NameInMap("OrdererType")]
            [Validation(Required=false)]
            public List<string> OrdererType { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
