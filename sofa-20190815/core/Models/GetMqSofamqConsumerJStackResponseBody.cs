// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetMqSofamqConsumerJStackResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetMqSofamqConsumerJStackResponseBodyData Data { get; set; }
        public class GetMqSofamqConsumerJStackResponseBodyData : TeaModel {
            [NameInMap("ClientId")]
            [Validation(Required=false)]
            public string ClientId { get; set; }
            [NameInMap("Jstack")]
            [Validation(Required=false)]
            public List<GetMqSofamqConsumerJStackResponseBodyDataJstack> Jstack { get; set; }
            public class GetMqSofamqConsumerJStackResponseBodyDataJstack : TeaModel {
                public string Thread { get; set; }
                public List<string> TrackList { get; set; }
            }
        };

    }

}
