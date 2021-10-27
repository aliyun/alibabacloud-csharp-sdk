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
                public string DelegationEnabledTime { get; set; }
                public string ServicePrincipal { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
