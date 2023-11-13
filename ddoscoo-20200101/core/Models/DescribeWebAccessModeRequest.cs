// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ddoscoo20200101.Models
{
    public class DescribeWebAccessModeRequest : TeaModel {
        /// <summary>
        /// The domain name of the website.
        /// 
        /// > A forwarding rule must be configured for a domain name. You can call the [DescribeDomains](~~91724~~) operation to query all domain names.
        /// </summary>
        [NameInMap("Domains")]
        [Validation(Required=false)]
        public List<string> Domains { get; set; }

    }

}
