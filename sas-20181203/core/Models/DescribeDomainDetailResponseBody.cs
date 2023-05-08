// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainDetailResponseBody : TeaModel {
        /// <summary>
        /// 1.2.XX.XX
        /// </summary>
        [NameInMap("AlarmCount")]
        [Validation(Required=false)]
        public int? AlarmCount { get; set; }

        /// <summary>
        /// The total number of alerts in your website assets.
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// DescribeDomainDetail
        /// </summary>
        [NameInMap("DomainDetailItems")]
        [Validation(Required=false)]
        public List<DescribeDomainDetailResponseBodyDomainDetailItems> DomainDetailItems { get; set; }
        public class DescribeDomainDetailResponseBodyDomainDetailItems : TeaModel {
            [NameInMap("AssetType")]
            [Validation(Required=false)]
            public string AssetType { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            [NameInMap("InternetIp")]
            [Validation(Required=false)]
            public string InternetIp { get; set; }

            [NameInMap("IntranetIp")]
            [Validation(Required=false)]
            public string IntranetIp { get; set; }

            [NameInMap("Uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

        }

        /// <summary>
        /// The instance UUID of the domain asset.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Queries the details of domain assets within your Alibaba Cloud account.
        /// </summary>
        [NameInMap("RootDomain")]
        [Validation(Required=false)]
        public string RootDomain { get; set; }

        /// <summary>
        /// The ID of the request, which is used to locate and troubleshoot issues.
        /// </summary>
        [NameInMap("VulCount")]
        [Validation(Required=false)]
        public int? VulCount { get; set; }

    }

}
