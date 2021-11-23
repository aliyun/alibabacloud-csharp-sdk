// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudAPI20160714.Models
{
    public class DescribeApiTrafficDataResponseBody : TeaModel {
        [NameInMap("CallDownloads")]
        [Validation(Required=false)]
        public DescribeApiTrafficDataResponseBodyCallDownloads CallDownloads { get; set; }
        public class DescribeApiTrafficDataResponseBodyCallDownloads : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficDataResponseBodyCallDownloadsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiTrafficDataResponseBodyCallDownloadsMonitorItem : TeaModel {
                public string ItemTime { get; set; }
                public string ItemValue { get; set; }
            }
        };

        [NameInMap("CallUploads")]
        [Validation(Required=false)]
        public DescribeApiTrafficDataResponseBodyCallUploads CallUploads { get; set; }
        public class DescribeApiTrafficDataResponseBodyCallUploads : TeaModel {
            [NameInMap("MonitorItem")]
            [Validation(Required=false)]
            public List<DescribeApiTrafficDataResponseBodyCallUploadsMonitorItem> MonitorItem { get; set; }
            public class DescribeApiTrafficDataResponseBodyCallUploadsMonitorItem : TeaModel {
                public string ItemTime { get; set; }
                public string ItemValue { get; set; }
            }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
