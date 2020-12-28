// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsConsumerTimeSpanResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsConsumerTimeSpanResponseBodyData Data { get; set; }
        public class OnsConsumerTimeSpanResponseBodyData : TeaModel {
            [NameInMap("MaxTimeStamp")]
            [Validation(Required=false)]
            public long? MaxTimeStamp { get; set; }
            [NameInMap("ConsumeTimeStamp")]
            [Validation(Required=false)]
            public long? ConsumeTimeStamp { get; set; }
            [NameInMap("Topic")]
            [Validation(Required=false)]
            public string Topic { get; set; }
            [NameInMap("MinTimeStamp")]
            [Validation(Required=false)]
            public long? MinTimeStamp { get; set; }
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }
        };

    }

}
