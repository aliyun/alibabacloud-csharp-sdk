// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeAvailableDedicatedHostClassesResponseBody : TeaModel {
        [NameInMap("HostClasses")]
        [Validation(Required=false)]
        public DescribeAvailableDedicatedHostClassesResponseBodyHostClasses HostClasses { get; set; }
        public class DescribeAvailableDedicatedHostClassesResponseBodyHostClasses : TeaModel {
            [NameInMap("HostClasses")]
            [Validation(Required=false)]
            public List<DescribeAvailableDedicatedHostClassesResponseBodyHostClassesHostClasses> HostClasses { get; set; }
            public class DescribeAvailableDedicatedHostClassesResponseBodyHostClassesHostClasses : TeaModel {
                public string Description { get; set; }
                public string HostClassName { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
