// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceExtResponseBody : TeaModel {
        /// <summary>
        /// The extended information about the Anti-DDoS Proxy instance.
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
            /// The ID of the instance.
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
            /// The type of the instance. Valid values:
            /// 
            /// *   **0**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Insurance mitigation plan
            /// *   **1**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Unlimited mitigation plan
            /// *   **2**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Chinese Mainland Acceleration (CMA) mitigation plan
            /// *   **3**: Anti-DDoS Proxy (Outside Chinese Mainland) instance of the Secure Chinese Mainland Acceleration (Sec-CMA) mitigation plan
            /// *   **9**: Anti-DDoS Proxy (Chinese Mainland) instance of the Profession mitigation plan
            /// </summary>
            [NameInMap("ProductPlan")]
            [Validation(Required=false)]
            public long? ProductPlan { get; set; }

            /// <summary>
            /// The Internet service provider (ISP) line of the Anti-DDoS Proxy (Chinese Mainland) instance.
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
