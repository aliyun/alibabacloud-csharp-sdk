// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=true)]
        public ListLiveRealtimeLogDeliveryResponseContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryResponseContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfo")]
            [Validation(Required=true)]
            public List<ListLiveRealtimeLogDeliveryResponseContentRealtimeLogDeliveryInfo> RealtimeLogDeliveryInfo { get; set; }
            public class ListLiveRealtimeLogDeliveryResponseContentRealtimeLogDeliveryInfo : TeaModel {
                public string Project { get; set; }
                public string Logstore { get; set; }
                public string Region { get; set; }
                public string DomainName { get; set; }
                public int? DmId { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
