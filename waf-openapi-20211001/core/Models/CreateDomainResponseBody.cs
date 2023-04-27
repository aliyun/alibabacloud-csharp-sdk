// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class CreateDomainResponseBody : TeaModel {
        /// <summary>
        /// $.parameters[3].schema.example
        /// </summary>
        [NameInMap("DomainInfo")]
        [Validation(Required=false)]
        public CreateDomainResponseBodyDomainInfo DomainInfo { get; set; }
        public class CreateDomainResponseBodyDomainInfo : TeaModel {
            /// <summary>
            /// $.parameters[3].schema.enumValueTitles
            /// </summary>
            [NameInMap("Cname")]
            [Validation(Required=false)]
            public string Cname { get; set; }

            /// <summary>
            /// $.parameters[4].schema.properties.Backends.items.description
            /// </summary>
            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

        /// <summary>
        /// $.parameters[3].schema.description
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
