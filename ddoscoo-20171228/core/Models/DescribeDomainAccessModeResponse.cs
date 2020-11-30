// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20171228.Models
{
    public class DescribeDomainAccessModeResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("DomainModeList")]
        [Validation(Required=true)]
        public List<DescribeDomainAccessModeResponseDomainModeList> DomainModeList { get; set; }
        public class DescribeDomainAccessModeResponseDomainModeList : TeaModel {
            [NameInMap("Domain")]
            [Validation(Required=true)]
            public string Domain { get; set; }

            [NameInMap("AccessMode")]
            [Validation(Required=true)]
            public int? AccessMode { get; set; }

        }

    }

}
