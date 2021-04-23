// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListLiveRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfo")]
            [Validation(Required=false)]
            public List<ListLiveRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo> RealtimeLogDeliveryInfo { get; set; }
            public class ListLiveRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo : TeaModel {
                public string Status { get; set; }
                public int? DmId { get; set; }
                public string Region { get; set; }
                public string Logstore { get; set; }
                public string Project { get; set; }
                public string DomainName { get; set; }
            }
        };

    }

}
