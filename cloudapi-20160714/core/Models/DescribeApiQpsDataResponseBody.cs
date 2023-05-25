// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiQpsDataResponseBody : TeaModel {
        [NameInMap("CallFails")]
        [Validation(Required=false)]
        public DescribeApiQpsDataResponseBodyCallFails CallFails { get; set; }
        public class DescribeApiQpsDataResponseBodyCallFails : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiQpsDataResponseBodyCallFailsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiQpsDataResponseBodyCallFailsMonitorItem : TeaModel {
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        [NameInMap("CallSuccesses")]
        [Validation(Required=false)]
        public DescribeApiQpsDataResponseBodyCallSuccesses CallSuccesses { get; set; }
        public class DescribeApiQpsDataResponseBodyCallSuccesses : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiQpsDataResponseBodyCallSuccessesMonitorItem> MonitorItem { get; set; }
            public class DescribeApiQpsDataResponseBodyCallSuccessesMonitorItem : TeaModel {
                [NameInMap("ItemTime")]
                [Validation(Required=false)]
                public string ItemTime { get; set; }

                [NameInMap("ItemValue")]
                [Validation(Required=false)]
                public string ItemValue { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
