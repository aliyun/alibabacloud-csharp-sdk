// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeGroupQpsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("GroupQps")]
        [Validation(Required=false)]
        public DescribeGroupQpsResponseBodyGroupQps GroupQps { get; set; }
        public class DescribeGroupQpsResponseBodyGroupQps : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeGroupQpsResponseBodyGroupQpsMonitorItem> MonitorItem { get; set; }
            public class DescribeGroupQpsResponseBodyGroupQpsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}
