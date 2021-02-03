// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohUserInfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SubDomainCount")]
        [Validation(Required=false)]
        public int? SubDomainCount { get; set; }

        [NameInMap("PdnsId")]
        [Validation(Required=false)]
        public long? PdnsId { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=false)]
        public int? DomainCount { get; set; }

    }

}
