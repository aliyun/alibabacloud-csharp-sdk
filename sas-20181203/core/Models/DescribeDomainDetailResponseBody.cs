// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// The total number of alerts in your website assets.
        /// </summary>
        [NameInMap("AlarmCount")]
        [Validation(Required=false)]
        public int? AlarmCount { get; set; }

        /// <summary>
        /// The domain name.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// An array that consists of the details about the domain asset.
        /// </summary>
        [NameInMap("DomainDetailItems")]
        [Validation(Required=false)]
        public List<DescribeDomainDetailResponseBodyDomainDetailItems> DomainDetailItems { get; set; }
        public class DescribeDomainDetailResponseBodyDomainDetailItems : TeaModel {
            /// <summary>
            /// The type of the domain asset. Valid values:
            /// 
            /// *   **0**: an Elastic Compute Service (ECS) instance
            /// *   **1**: a Server Load Balancer (SLB) instance
            /// *   **2**: a Network Address Translation (NAT) gateway
            /// *   **3**: an ApsaraDB RDS instance
            /// *   **4**: an ApsaraDB for MongoDB instance
            /// </summary>
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            /// <summary>
            /// The instance ID of the asset.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// The name of the asset.
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// The public IP address of the asset.
            /// </summary>
            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            /// <summary>
            /// The private IP address of the asset.
            /// </summary>
            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            /// <summary>
            /// The instance UUID of the domain asset.
            /// </summary>
            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The name of the root domain that corresponds to the domain.
        /// </summary>
        [NameInMap("RootDomain")]
        [Validation(Required=false)]
        public string RootDomain { get; set; }

        /// <summary>
        /// The total number of vulnerabilities in your website assets.
        /// </summary>
        [NameInMap("VulCount")]
        [Validation(Required=false)]
        public int? VulCount { get; set; }

    }

}
