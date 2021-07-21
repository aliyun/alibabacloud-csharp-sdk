// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorQuotaResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSiteMonitorQuotaResponseBodyData Data { get; set; }
        public class DescribeSiteMonitorQuotaResponseBodyData : TeaModel {
            [NameInMap("SiteMonitorOperatorQuotaQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorOperatorQuotaQuota { get; set; }
            [NameInMap("SecondMonitor")]
            [Validation(Required=false)]
            public bool? SecondMonitor { get; set; }
            [NameInMap("SiteMonitorQuotaTaskUsed")]
            [Validation(Required=false)]
            public int? SiteMonitorQuotaTaskUsed { get; set; }
            [NameInMap("SiteMonitorTaskQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorTaskQuota { get; set; }
            [NameInMap("SiteMonitorVersion")]
            [Validation(Required=false)]
            public string SiteMonitorVersion { get; set; }
            [NameInMap("SiteMonitorIdcQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorIdcQuota { get; set; }
        };

    }

}
