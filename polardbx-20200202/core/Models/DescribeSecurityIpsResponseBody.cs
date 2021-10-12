// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeSecurityIpsResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSecurityIpsResponseBodyData Data { get; set; }
        public class DescribeSecurityIpsResponseBodyData : TeaModel {
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }
            [NameInMap("GroupItems")]
            [Validation(Required=false)]
            public List<DescribeSecurityIpsResponseBodyDataGroupItems> GroupItems { get; set; }
            public class DescribeSecurityIpsResponseBodyDataGroupItems : TeaModel {
                public string GroupName { get; set; }
                public string SecurityIPList { get; set; }
            }
        };

    }

}
