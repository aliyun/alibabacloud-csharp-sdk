// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnL2VipsRequest : TeaModel {
        /// <summary>
        /// The domain name. You can specify only one domain name in each request. If you do not specify this parameter, the origin CIDR blocks of all domain names in your account in the whitelist are returned.
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

    }

}
