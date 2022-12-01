// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListDelegatedServicesForAccountResponseBody : TeaModel {
        [NameInMap("DelegatedServices")]
        [Validation(Required=false)]
        public ListDelegatedServicesForAccountResponseBodyDelegatedServices DelegatedServices { get; set; }
        public class ListDelegatedServicesForAccountResponseBodyDelegatedServices : TeaModel {
            [NameInMap("DelegatedService")]
            [Validation(Required=false)]
            public List<ListDelegatedServicesForAccountResponseBodyDelegatedServicesDelegatedService> DelegatedService { get; set; }
            public class ListDelegatedServicesForAccountResponseBodyDelegatedServicesDelegatedService : TeaModel {
                [NameInMap("DelegationEnabledTime")]
                [Validation(Required=false)]
                public string DelegationEnabledTime { get; set; }

                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

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
