// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeInstanceSpecsResponseBody : TeaModel {
        /// <summary>
        /// The details of the specifications of the instance.
        /// </summary>
        [NameInMap("InstanceSpecs")]
        [Validation(Required=false)]
        public List<DescribeInstanceSpecsResponseBodyInstanceSpecs> InstanceSpecs { get; set; }
        public class DescribeInstanceSpecsResponseBodyInstanceSpecs : TeaModel {
            /// <summary>
            /// The clean bandwidth. Unit: Mbit/s.
            /// </summary>
            [NameInMap("BandwidthMbps")]
            [Validation(Required=false)]
            public int? BandwidthMbps { get; set; }

            /// <summary>
            /// The basic protection bandwidth. Unit: Gbit/s.
            /// </summary>
            [NameInMap("BaseBandwidth")]
            [Validation(Required=false)]
            public int? BaseBandwidth { get; set; }

            /// <summary>
            /// The specification of concurrent connections of the instance.
            /// </summary>
            [NameInMap("ConnLimit")]
            [Validation(Required=false)]
            public long? ConnLimit { get; set; }

            /// <summary>
            /// The specification of new connections of the instance.
            /// </summary>
            [NameInMap("CpsLimit")]
            [Validation(Required=false)]
            public long? CpsLimit { get; set; }

            /// <summary>
            /// The number of available advanced mitigation sessions for this month. **-1**: unlimited
            /// 
            /// >  This parameter is returned only when the request parameter **RegionId** is set to **ap-southeast-1**. If RegionId is set to ap-southeast-1, the specifications of Anti-DDoS Proxy (Outside Chinese Mainland) instances are queried.
            /// </summary>
            [NameInMap("DefenseCount")]
            [Validation(Required=false)]
            public int? DefenseCount { get; set; }

            /// <summary>
            /// The number of domain names that can be protected by the instance.
            /// </summary>
            [NameInMap("DomainLimit")]
            [Validation(Required=false)]
            public int? DomainLimit { get; set; }

            /// <summary>
            /// The burstable protection bandwidth. Unit: Gbit/s.
            /// </summary>
            [NameInMap("ElasticBandwidth")]
            [Validation(Required=false)]
            public int? ElasticBandwidth { get; set; }

            /// <summary>
            /// The burstable clean bandwidth. Unit: Mbit/s.
            /// </summary>
            [NameInMap("ElasticBw")]
            [Validation(Required=false)]
            public int? ElasticBw { get; set; }

            /// <summary>
            /// The metering method of the burstable clean bandwidth. Valid values:
            /// 
            /// *   **day**: the metering method of daily 95th percentile
            /// *   **month**: the metering method of monthly 95th percentile
            /// </summary>
            [NameInMap("ElasticBwModel")]
            [Validation(Required=false)]
            public string ElasticBwModel { get; set; }

            /// <summary>
            /// The burstable QPS. Unit: QPS
            /// </summary>
            [NameInMap("ElasticQps")]
            [Validation(Required=false)]
            public long? ElasticQps { get; set; }

            /// <summary>
            /// The metering method of the burstable QPS. Valid values:
            /// 
            /// *   **day**: the metering method of daily 95th percentile
            /// *   **month**: the metering method of monthly 95th percentile
            /// </summary>
            [NameInMap("ElasticQpsMode")]
            [Validation(Required=false)]
            public string ElasticQpsMode { get; set; }

            /// <summary>
            /// The function plan of the instance. Valid values:
            /// 
            /// *   **default**: Standard
            /// *   **enhance**: Enhanced
            /// *   **cnhk**: Chinese Mainland Acceleration (CMA)
            /// *   **cnhk_default**: Secure Chinese Mainland Acceleration (Sec-CMA) standard
            /// *   **cnhk_enhance**: Sec-CMA enhanced
            /// </summary>
            [NameInMap("FunctionVersion")]
            [Validation(Required=false)]
            public string FunctionVersion { get; set; }

            /// <summary>
            /// The ID of the instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The number of ports that can be protected by the instance.
            /// </summary>
            [NameInMap("PortLimit")]
            [Validation(Required=false)]
            public int? PortLimit { get; set; }

            /// <summary>
            /// The clean QPS.
            /// </summary>
            [NameInMap("QpsLimit")]
            [Validation(Required=false)]
            public int? QpsLimit { get; set; }

            /// <summary>
            /// The threshold of the clean bandwidth. Valid values: 0 to 15360. The value 0 indicates that rate limiting is never triggered. Unit: Mbit/s
            /// </summary>
            [NameInMap("RealLimitBw")]
            [Validation(Required=false)]
            public long? RealLimitBw { get; set; }

            /// <summary>
            /// The number of sites that can be protected by the instance.
            /// </summary>
            [NameInMap("SiteLimit")]
            [Validation(Required=false)]
            public int? SiteLimit { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
