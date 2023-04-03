// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohUserInfoResponseBody : TeaModel {
        /// <summary>
        /// The number of accessed domains.
        /// </summary>
        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public int? DomainCount { get; set; }

        /// <summary>
        /// The ID of the Alibaba Cloud public DNS user.
        /// </summary>
        [NameInMap("PdnsId")]
        [Validation(Required=false)]
        public long? PdnsId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of accessed subdomains.
        /// </summary>
        [NameInMap("SubDomainCount")]
        [Validation(Required=false)]
        public int? SubDomainCount { get; set; }

    }

}
