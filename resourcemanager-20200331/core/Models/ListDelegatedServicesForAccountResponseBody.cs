// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListDelegatedServicesForAccountResponseBody : TeaModel {
        /// <summary>
        /// The trusted services.
        /// 
        /// >  If the value of this parameter is empty, the member is not specified as a delegated administrator account.
        /// </summary>
        [NameInMap("DelegatedServices")]
        [Validation(Required=false)]
        public ListDelegatedServicesForAccountResponseBodyDelegatedServices DelegatedServices { get; set; }
        public class ListDelegatedServicesForAccountResponseBodyDelegatedServices : TeaModel {
            [NameInMap("DelegatedService")]
            [Validation(Required=false)]
            public List<ListDelegatedServicesForAccountResponseBodyDelegatedServicesDelegatedService> DelegatedService { get; set; }
            public class ListDelegatedServicesForAccountResponseBodyDelegatedServicesDelegatedService : TeaModel {
                /// <summary>
                /// The time when the member was specified as a delegated administrator account of the trusted service.
                /// </summary>
                [NameInMap("DelegationEnabledTime")]
                [Validation(Required=false)]
                public string DelegationEnabledTime { get; set; }

                /// <summary>
                /// The identification of the trusted service.
                /// </summary>
                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

                /// <summary>
                /// The status of the trusted service. Valid values:
                /// 
                /// *   ENABLED: enabled
                /// *   DISABLED: disabled
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
