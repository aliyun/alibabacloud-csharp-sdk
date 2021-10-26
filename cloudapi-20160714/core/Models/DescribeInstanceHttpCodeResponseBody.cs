// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceHttpCodeResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceHttpCode")]
        [Validation(Required=false)]
        public DescribeInstanceHttpCodeResponseBodyInstanceHttpCode InstanceHttpCode { get; set; }
        public class DescribeInstanceHttpCodeResponseBodyInstanceHttpCode : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceHttpCodeResponseBodyInstanceHttpCodeMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceHttpCodeResponseBodyInstanceHttpCodeMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}
