// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiLatencyDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("CallLatencys")]
        [Validation(Required=false)]
        public DescribeApiLatencyDataResponseBodyCallLatencys CallLatencys { get; set; }
        public class DescribeApiLatencyDataResponseBodyCallLatencys : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem> MonitorItem { get; set; }
            public class DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}
