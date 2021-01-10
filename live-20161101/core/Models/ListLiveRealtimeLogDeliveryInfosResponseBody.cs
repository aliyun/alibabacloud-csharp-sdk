// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryInfosResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListLiveRealtimeLogDeliveryInfosResponseBodyContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryInfosResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfos")]
            [Validation(Required=false)]
            public List<ListLiveRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos> RealtimeLogDeliveryInfos { get; set; }
            public class ListLiveRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos : TeaModel {
                public string Project { get; set; }
                public string Logstore { get; set; }
                public string Region { get; set; }
            }
        };

    }

}
