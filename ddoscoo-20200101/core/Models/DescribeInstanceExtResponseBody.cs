// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceExtResponseBody : TeaModel {
        /// <summary>
        /// The information about the instance.
        /// </summary>
        [NameInMap("InstanceExtSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceExtResponseBodyInstanceExtSpecs> InstanceExtSpecs { get; set; }
        public class DescribeInstanceExtResponseBodyInstanceExtSpecs : TeaModel {
            /// <summary>
            /// The function plan. Valid values:
            /// 
            /// *   **0**: Standard
            /// *   **1**: Enhanced
            /// </summary>
            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public long? FunctionVersion { get; set; }

            /// <summary>
            /// The instance ID
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The clean bandwidth. Unit: Mbit/s.
            /// </summary>
            [NameInMap("NormalBandwidth")]
            [Validation(Required=false)]
            public long? NormalBandwidth { get; set; }

            /// <summary>
            /// The type of the instance. Valid value:
            /// 
            /// *   **0**: Anti-DDoS Premium instance of the Insurance mitigation plan
            /// *   **1**: Anti-DDoS Premium instance of the Unlimited mitigation plan
            /// *   **2**: Anti-DDoS Premium instance of the CMA mitigation plan
            /// *   **3**: Anti-DDoS Premium instance of the Secure Chinese Mainland Acceleration (Sec-CMA) plan
            /// *   **9**: Anti-DDoS Pro instance of the Profession mitigation plan
            /// </summary>
            [NameInMap("ProductPlan")]
            [Validation(Required=false)]
            public long? ProductPlan { get; set; }

            /// <summary>
            /// The Internet service provider (ISP) line resource of the Anti-DDoS Pro instance.
            /// </summary>
            [NameInMap("ServicePartner")]
            [Validation(Required=false)]
            public string ServicePartner { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of queried instances.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
