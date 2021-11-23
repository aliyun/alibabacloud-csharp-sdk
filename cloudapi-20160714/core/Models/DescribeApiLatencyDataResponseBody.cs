// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiLatencyDataResponseBody : TeaModel {
        [NameInMap("CallLatencys")]
        [Validation(Required=false)]
        public DescribeApiLatencyDataResponseBodyCallLatencys CallLatencys { get; set; }
        public class DescribeApiLatencyDataResponseBodyCallLatencys : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem> MonitorItem { get; set; }
            public class DescribeApiLatencyDataResponseBodyCallLatencysMonitorItem : TeaModel {
                public string ItemTime { get; set; }
                public string ItemValue { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
