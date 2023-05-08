// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDomainDetailRequest : TeaModel {
        /// <summary>
        /// The domain name or the name of website that you want to query.
        /// 
        /// >  Fuzzy match is not supported. You must enter a complete domain name or a website.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The type of the domain asset. Valid values:
        /// 
        /// *   **0**: an Elastic Compute Service (ECS) instance
        /// *   **1**: a Server Load Balancer (SLB) instance
        /// *   **2**: a Network Address Translation (NAT) gateway
        /// *   **3**: an ApsaraDB RDS instance
        /// *   **4**: an ApsaraDB for MongoDB instance
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
