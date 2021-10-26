// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeInstanceQpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public DescribeInstanceQpsResponseBodyInstanceQps InstanceQps { get; set; }
        public class DescribeInstanceQpsResponseBodyInstanceQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeInstanceQpsResponseBodyInstanceQpsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}
