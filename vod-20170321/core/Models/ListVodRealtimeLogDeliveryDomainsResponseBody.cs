// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class ListVodRealtimeLogDeliveryDomainsResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListVodRealtimeLogDeliveryDomainsResponseBodyContent Content { get; set; }
        public class ListVodRealtimeLogDeliveryDomainsResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListVodRealtimeLogDeliveryDomainsResponseBodyContentDomains> Domains { get; set; }
            public class ListVodRealtimeLogDeliveryDomainsResponseBodyContentDomains : TeaModel {
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

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
