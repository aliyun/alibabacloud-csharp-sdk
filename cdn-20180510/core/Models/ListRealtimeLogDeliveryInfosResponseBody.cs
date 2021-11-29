// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryInfosResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryInfosResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryInfosResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfos")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos> RealtimeLogDeliveryInfos { get; set; }
            public class ListRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos : TeaModel {
                public string Logstore { get; set; }
                public string Project { get; set; }
                public string Region { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
