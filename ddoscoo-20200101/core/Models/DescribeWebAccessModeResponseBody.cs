// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAccessModeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("DomainModes")]
        [Validation(Required=false)]
        public List<DescribeWebAccessModeResponseBodyDomainModes> DomainModes { get; set; }
        public class DescribeWebAccessModeResponseBodyDomainModes : TeaModel {
            [NameInMap("AccessMode")]
            [Validation(Required=false)]
            public int? AccessMode { get; set; }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

        }

    }

}
