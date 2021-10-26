// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeRegionQpsGroupByInstanceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("InstanceQps")]
        [Validation(Required=false)]
        public DescribeRegionQpsGroupByInstanceResponseBodyInstanceQps InstanceQps { get; set; }
        public class DescribeRegionQpsGroupByInstanceResponseBodyInstanceQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeRegionQpsGroupByInstanceResponseBodyInstanceQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeRegionQpsGroupByInstanceResponseBodyInstanceQpsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
                public string Item { get; set; }
            }
        };

    }

}
