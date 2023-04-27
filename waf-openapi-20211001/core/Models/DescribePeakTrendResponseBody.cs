// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribePeakTrendResponseBody : TeaModel {
        /// <summary>
        /// An array of the QPS statistics of the WAF instance.
        /// </summary>
        [NameInMap("FlowChart")]
        [Validation(Required=false)]
        public List<DescribePeakTrendResponseBodyFlowChart> FlowChart { get; set; }
        public class DescribePeakTrendResponseBodyFlowChart : TeaModel {
            /// <summary>
            /// The number of requests that are monitored or blocked by the custom rule (access control) module.
            /// </summary>
            [NameInMap("AclSum")]
            [Validation(Required=false)]
            public long? AclSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored or blocked by the scan protection module.
            /// </summary>
            [NameInMap("AntiScanSum")]
            [Validation(Required=false)]
            public long? AntiScanSum { get; set; }

            /// <summary>
            /// The number of requests that are monitored or blocked by the HTTP flood protection module.
            /// </summary>
            [NameInMap("CcSum")]
            [Validation(Required=false)]
            public long? CcSum { get; set; }

            /// <summary>
            /// The total number of requests.
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public long? Count { get; set; }

            /// <summary>
            /// The serial number of the time interval. The serial numbers are arranged in chronological order.
            /// </summary>
            [NameInMap("Index")]
            [Validation(Required=false)]
            public long? Index { get; set; }

            /// <summary>
            /// The number of requests that are monitored or blocked by the regular expression protection engine.
            /// </summary>
            [NameInMap("WafSum")]
            [Validation(Required=false)]
            public long? WafSum { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
