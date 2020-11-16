// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListLiveRealtimeLogDeliveryDomainsResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Content")]
        [Validation(Required=true)]
        public ListLiveRealtimeLogDeliveryDomainsResponseContent Content { get; set; }
        public class ListLiveRealtimeLogDeliveryDomainsResponseContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=true)]
            public List<ListLiveRealtimeLogDeliveryDomainsResponseContentDomains> Domains { get; set; }
            public class ListLiveRealtimeLogDeliveryDomainsResponseContentDomains : TeaModel {
                public string DomainName { get; set; }
                public string Status { get; set; }
            }
        };

    }

}
