// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class ListRealtimeLogDeliveryDomainsResponseBody : TeaModel {
        /// <summary>
        /// The information about the accelerated domain names.
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public ListRealtimeLogDeliveryDomainsResponseBodyContent Content { get; set; }
        public class ListRealtimeLogDeliveryDomainsResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<ListRealtimeLogDeliveryDomainsResponseBodyContentDomains> Domains { get; set; }
            public class ListRealtimeLogDeliveryDomainsResponseBodyContentDomains : TeaModel {
                /// <summary>
                /// The domain name.
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// The status. Valid values:
                /// 
                /// *   **online**: enabled
                /// *   **offline**: disabled
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
