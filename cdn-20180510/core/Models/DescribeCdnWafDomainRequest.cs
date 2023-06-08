// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class DescribeCdnWafDomainRequest : TeaModel {
        /// <summary>
        /// The domain name that you want to query.
        /// 
        /// You can specify only one domain name in each request. You have three options to configure this parameter:
        /// 
        /// *   Specify an exact domain name. For example, if you set this parameter to example.com, configuration information of example.com is queried.
        /// *   Specify a keyword. For example, if you set this parameter to example, configuration information about all domain names that contain example is queried.
        /// *   Leave this parameter empty. If this parameter is left empty, all accelerated domain names for which WAF is configured are queried.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        /// <summary>
        /// The region where WAF is enabled. Valid values:
        /// 
        /// *   **cn-hangzhou**: inside the Chinese mainland
        /// *   **ap-southeast-1**: outside the Chinese mainland
        /// 
        /// > ap-southeast-1 includes Hong Kong (China), Macao (China), Taiwan (China), and other countries and regions.
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// The ID of the resource group.
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

    }

}
