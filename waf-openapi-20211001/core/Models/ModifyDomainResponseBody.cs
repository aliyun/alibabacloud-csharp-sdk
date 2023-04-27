// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class ModifyDomainResponseBody : TeaModel {
        /// <summary>
        /// The information about the domain name.
        /// </summary>
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public ModifyDomainResponseBodyDomainInfo DomainInfo { get; set; }
        public class ModifyDomainResponseBodyDomainInfo : TeaModel {
            /// <summary>
            /// The CNAME that is assigned by WAF to the domain name.
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// The domain name whose access configurations you modified.
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            /// <summary>
            /// The ID of the domain name.
            /// </summary>
            [NameInMap("DomainId")]
            [Validation(Required=false)]
            public string DomainId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
