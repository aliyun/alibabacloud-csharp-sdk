// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryDomainsResponseBody : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryDomainsResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryDomainsResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryDomainsResponseBodyContentDomains> Domains { get; set; }
            public class ListRealtimeLogDeliveryDomainsResponseBodyContentDomains : TeaModel {
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
