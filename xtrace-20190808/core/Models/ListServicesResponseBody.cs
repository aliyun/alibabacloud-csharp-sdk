// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Xtrace20190808.Models
{
    public class ListServicesResponseBody : TeaModel {
        [NameInMap("Services")]
        [Validation(Required=false)]
        public ListServicesResponseBodyServices Services { get; set; }
        public class ListServicesResponseBodyServices : TeaModel {
            [NameInMap("Service")]
            [Validation(Required=false)]
            public List<ListServicesResponseBodyServicesService> Service { get; set; }
            public class ListServicesResponseBodyServicesService : TeaModel {
                public string Pid { get; set; }
                public string ServiceName { get; set; }
                public string RegionId { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
