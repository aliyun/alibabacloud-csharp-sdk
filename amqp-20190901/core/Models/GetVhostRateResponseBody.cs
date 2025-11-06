// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Amqp20190901.Models
{
    public class GetVhostRateResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetVhostRateResponseBodyData> Data { get; set; }
        public class GetVhostRateResponseBodyData : TeaModel {
            [NameInMap("ChannelNum")]
            [Validation(Required=false)]
            public int? ChannelNum { get; set; }

            [NameInMap("ConnectionNum")]
            [Validation(Required=false)]
            public int? ConnectionNum { get; set; }

            [NameInMap("InQps")]
            [Validation(Required=false)]
            public long? InQps { get; set; }

            [NameInMap("OutQps")]
            [Validation(Required=false)]
            public long? OutQps { get; set; }

            [NameInMap("VhostName")]
            [Validation(Required=false)]
            public string VhostName { get; set; }

        }

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
