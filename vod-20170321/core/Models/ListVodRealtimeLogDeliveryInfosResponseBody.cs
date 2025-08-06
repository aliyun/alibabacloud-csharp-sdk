// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListVodRealtimeLogDeliveryInfosResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVodRealtimeLogDeliveryInfosResponseBodyContent Content { get; set; }
        public class ListVodRealtimeLogDeliveryInfosResponseBodyContent : TeaModel {
            [NameInMap("RealtimeLogDeliveryInfos")]
            [Validation(Required=false)]
            public List<ListVodRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos> RealtimeLogDeliveryInfos { get; set; }
            public class ListVodRealtimeLogDeliveryInfosResponseBodyContentRealtimeLogDeliveryInfos : TeaModel {
                [NameInMap("Logstore")]
                [Validation(Required=false)]
                public string Logstore { get; set; }

                [NameInMap("Project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
