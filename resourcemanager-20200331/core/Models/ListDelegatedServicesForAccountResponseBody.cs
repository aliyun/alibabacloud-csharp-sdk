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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D9C03B94-9396-4794-A74B-13DC437556A6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
