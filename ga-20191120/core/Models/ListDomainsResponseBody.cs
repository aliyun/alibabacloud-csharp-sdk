// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ga20191120.Models
{
    public class ListDomainsResponseBody : TeaModel {
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<ListDomainsResponseBodyDomains> Domains { get; set; }
        public class ListDomainsResponseBodyDomains : TeaModel {
            [NameInMap("Accelerators")]
            [Validation(Required=false)]
            public List<ListDomainsResponseBodyDomainsAccelerators> Accelerators { get; set; }
            public class ListDomainsResponseBodyDomainsAccelerators : TeaModel {
                [NameInMap("AcceleratorId")]
                [Validation(Required=false)]
                public string AcceleratorId { get; set; }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("Domain")]
            [Validation(Required=false)]
            public string Domain { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

        }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
