// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class ListTrustedServiceStatusResponseBody : TeaModel {
        /// <summary>
        /// The trusted services that are enabled.
        /// </summary>
        [NameInMap("EnabledServicePrincipals")]
        [Validation(Required=false)]
        public ListTrustedServiceStatusResponseBodyEnabledServicePrincipals EnabledServicePrincipals { get; set; }
        public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipals : TeaModel {
            [NameInMap("EnabledServicePrincipal")]
            [Validation(Required=false)]
            public List<ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal> EnabledServicePrincipal { get; set; }
            public class ListTrustedServiceStatusResponseBodyEnabledServicePrincipalsEnabledServicePrincipal : TeaModel {
                /// <summary>
                /// The time when the trusted service was enabled.
                /// </summary>
                [NameInMap("EnableTime")]
                [Validation(Required=false)]
                public string EnableTime { get; set; }

                /// <summary>
                /// The identification of the trusted service.
                /// </summary>
                [NameInMap("ServicePrincipal")]
                [Validation(Required=false)]
                public string ServicePrincipal { get; set; }

            }

        }

        /// <summary>
        /// The page number of the returned page.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries returned per page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
