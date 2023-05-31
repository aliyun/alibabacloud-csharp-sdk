// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeRiskListCheckResultResponseBody : TeaModel {
        /// <summary>
        /// The number of risk items for each cloud service.
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<DescribeRiskListCheckResultResponseBodyList> List { get; set; }
        public class DescribeRiskListCheckResultResponseBodyList : TeaModel {
            /// <summary>
            /// The instance ID of the cloud service.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The total number of risk items detected in the current cloud service.
            /// </summary>
            [NameInMap("riskCount")]
            [Validation(Required=false)]
            public long? RiskCount { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
