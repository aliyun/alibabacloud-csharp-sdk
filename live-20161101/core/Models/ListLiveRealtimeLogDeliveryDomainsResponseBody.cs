// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryDomainsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListLiveRealtimeLogDeliveryDomainsResponseBodyContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryDomainsResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListLiveRealtimeLogDeliveryDomainsResponseBodyContentDomains> Domains { get; set; }
            public class ListLiveRealtimeLogDeliveryDomainsResponseBodyContentDomains : TeaModel {
                public string DomainName { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
