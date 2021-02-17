// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMessageTraceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMessageTraceResponseBodyData Data { get; set; }
        public class OnsMessageTraceResponseBodyData : TeaModel {
            [NameInMap("MessageTrack")]
            [Validation(Required=false)]
            public List<OnsMessageTraceResponseBodyDataMessageTrack> MessageTrack { get; set; }
            public class OnsMessageTraceResponseBodyDataMessageTrack : TeaModel {
                public string TrackType { get; set; }
                public string ConsumerGroup { get; set; }
                public string InstanceId { get; set; }
            }
        };

    }

}
