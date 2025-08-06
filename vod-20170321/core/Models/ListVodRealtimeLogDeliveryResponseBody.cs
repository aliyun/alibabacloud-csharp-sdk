// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListVodRealtimeLogDeliveryResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVodRealtimeLogDeliveryResponseBodyContent Content { get; set; }
        public class ListVodRealtimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfo")]
            [Validation(Required=false)]
            public List<ListVodRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo> RealtimeLogDeliveryInfo { get; set; }
            public class ListVodRealtimeLogDeliveryResponseBodyContentRealtimeLogDeliveryInfo : TeaModel {
                [NameInMap("DmId")]
                [Validation(Required=false)]
                public int? DmId { get; set; }

                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
