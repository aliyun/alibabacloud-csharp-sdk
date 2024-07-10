// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class ListWebCustomDomainOutput : TeaModel {
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("WebCustomDomains")]
        [Validation(Required=false)]
        public List<WebCustomDomain> WebCustomDomains { get; set; }

    }

}
