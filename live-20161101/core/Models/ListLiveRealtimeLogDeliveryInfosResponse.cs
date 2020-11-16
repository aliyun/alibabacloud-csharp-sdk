// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryInfosResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=true)]
        public ListLiveRealtimeLogDeliveryInfosResponseContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryInfosResponseContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfos")]
            [Validation(Required=true)]
            public List<ListLiveRealtimeLogDeliveryInfosResponseContentRealtimeLogDeliveryInfos> RealtimeLogDeliveryInfos { get; set; }
            public class ListLiveRealtimeLogDeliveryInfosResponseContentRealtimeLogDeliveryInfos : TeaModel {
                public string Project { get; set; }
                public string Logstore { get; set; }
                public string Region { get; set; }
            }
        };

    }

}
