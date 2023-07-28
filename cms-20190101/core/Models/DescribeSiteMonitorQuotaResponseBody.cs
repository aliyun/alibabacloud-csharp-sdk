// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSiteMonitorQuotaResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the call was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The quotas and version of site monitoring.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeSiteMonitorQuotaResponseBodyData Data { get; set; }
        public class DescribeSiteMonitorQuotaResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the second-level monitoring is enabled. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("SecondMonitor")]
            [Validation(Required=false)]
            public bool? SecondMonitor { get; set; }

            /// <summary>
            /// The quota of detection points that are provided by Alibaba Cloud. Five detection points are provided for free.
            /// </summary>
            [NameInMap("SiteMonitorIdcQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorIdcQuota { get; set; }

            /// <summary>
            /// The quota of detection points that are not provided by Alibaba Cloud. Default value: 0.
            /// </summary>
            [NameInMap("SiteMonitorOperatorQuotaQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorOperatorQuotaQuota { get; set; }

            /// <summary>
            /// The used quota of site monitoring tasks.
            /// </summary>
            [NameInMap("SiteMonitorQuotaTaskUsed")]
            [Validation(Required=false)]
            public int? SiteMonitorQuotaTaskUsed { get; set; }

            /// <summary>
            /// The quota of site monitoring tasks.
            /// </summary>
            [NameInMap("SiteMonitorTaskQuota")]
            [Validation(Required=false)]
            public int? SiteMonitorTaskQuota { get; set; }

            /// <summary>
            /// The version of site monitoring. Valid values:
            /// 
            /// *   V1
            /// *   V2
            /// </summary>
            [NameInMap("SiteMonitorVersion")]
            [Validation(Required=false)]
            public string SiteMonitorVersion { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the call was successful. Valid values:
        /// 
        /// *   true: The call was successful.
        /// *   false: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
