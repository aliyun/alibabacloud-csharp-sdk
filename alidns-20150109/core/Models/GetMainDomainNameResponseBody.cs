// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class GetMainDomainNameResponseBody : TeaModel {
        [NameInMap("RR")]
        [Validation(Required=false)]
        public string RR { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("DomainLevel")]
        [Validation(Required=false)]
        public long? DomainLevel { get; set; }

    }

}
