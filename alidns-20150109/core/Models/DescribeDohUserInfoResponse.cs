// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDohUserInfoResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("PdnsId")]
        [Validation(Required=true)]
        public long? PdnsId { get; set; }

        [NameInMap("DomainCount")]
        [Validation(Required=true)]
        public int? DomainCount { get; set; }

        [NameInMap("SubDomainCount")]
        [Validation(Required=true)]
        public int? SubDomainCount { get; set; }

    }

}
