// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ons20190214.Models
{
    public class OnsMqttQueryHistoryOnlineResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public OnsMqttQueryHistoryOnlineResponseBodyData Data { get; set; }
        public class OnsMqttQueryHistoryOnlineResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<OnsMqttQueryHistoryOnlineResponseBodyDataRecords> Records { get; set; }
            public class OnsMqttQueryHistoryOnlineResponseBodyDataRecords : TeaModel {
                public float? Y { get; set; }
                public long? X { get; set; }
            }
            [NameInMap("XUnit")]
            [Validation(Required=false)]
            public string XUnit { get; set; }
            [NameInMap("YUnit")]
            [Validation(Required=false)]
            public string YUnit { get; set; }
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }
        };

    }

}
