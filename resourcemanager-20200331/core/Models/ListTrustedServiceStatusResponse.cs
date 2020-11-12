// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTrustedServiceStatusResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=true)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public int? PageSize { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public int? TotalCount { get; set; }

        [NameInMap("EnabledServicePrincipals")]
        [Validation(Required=true)]
        public ListTrustedServiceStatusResponseEnabledServicePrincipals EnabledServicePrincipals { get; set; }
        public class ListTrustedServiceStatusResponseEnabledServicePrincipals : TeaModel {
            [NameInMap("EnabledServicePrincipal")]
            [Validation(Required=true)]
            public List<ListTrustedServiceStatusResponseEnabledServicePrincipalsEnabledServicePrincipal> EnabledServicePrincipal { get; set; }
            public class ListTrustedServiceStatusResponseEnabledServicePrincipalsEnabledServicePrincipal : TeaModel {
                public string EnableTime { get; set; }
                public string ServicePrincipal { get; set; }
            }
        };

    }

}
