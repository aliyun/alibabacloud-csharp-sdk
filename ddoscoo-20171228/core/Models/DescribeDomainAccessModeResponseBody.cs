// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAccessModeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainModeList")]
        [Validation(Required=false)]
        public List<DescribeDomainAccessModeResponseBodyDomainModeList> DomainModeList { get; set; }
        public class DescribeDomainAccessModeResponseBodyDomainModeList : TeaModel {
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public int? AccessMode { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

    }

}
