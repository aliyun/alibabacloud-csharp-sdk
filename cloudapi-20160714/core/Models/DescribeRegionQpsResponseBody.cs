// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeRegionQpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RegionQps")]
        [Validation(Required=false)]
        public DescribeRegionQpsResponseBodyRegionQps RegionQps { get; set; }
        public class DescribeRegionQpsResponseBodyRegionQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeRegionQpsResponseBodyRegionQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeRegionQpsResponseBodyRegionQpsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}
