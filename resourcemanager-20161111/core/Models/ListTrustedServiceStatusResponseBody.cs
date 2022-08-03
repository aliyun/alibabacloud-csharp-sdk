// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20161111.Models
{
    public class ListTrustedServiceStatusResponseBody : TeaModel {
        [NameInMap("EnabledServicePrincipals")]
        [Validation(Required=false)]
        public ListTrustedServiceStatusResponseBodyEnabledServicePrincipals EnabledServicePrincipals { get; set; }
        public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipals : TeaModel {
            [NameInMap("EnabledServicePrincipal")]
            [Validation(Required=false)]
            public List<ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal> EnabledServicePrincipal { get; set; }
            public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal : TeaModel {
                public string EnableTime { get; set; }
                public string ServicePrincipal { get; set; }
            }
        };

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
