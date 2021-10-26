// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiErrorDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ClientErrors")]
        [Validation(Required=false)]
        public DescribeApiErrorDataResponseBodyClientErrors ClientErrors { get; set; }
        public class DescribeApiErrorDataResponseBodyClientErrors : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiErrorDataResponseBodyClientErrorsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiErrorDataResponseBodyClientErrorsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

        [NameInMap("ServerErrors")]
        [Validation(Required=false)]
        public DescribeApiErrorDataResponseBodyServerErrors ServerErrors { get; set; }
        public class DescribeApiErrorDataResponseBodyServerErrors : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiErrorDataResponseBodyServerErrorsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiErrorDataResponseBodyServerErrorsMonitorItem : TeaModel {
                public string ItemValue { get; set; }
                public string ItemTime { get; set; }
            }
        };

    }

}
