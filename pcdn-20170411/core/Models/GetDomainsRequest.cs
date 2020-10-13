// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pcdn20170411.Models
{
    public class GetDomainsRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("Version")]
        [Validation(Required=true)]
        public string Version { get; set; }

        [NameInMap("Page")]
        [Validation(Required=true)]
        public string Page { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=true)]
        public string PageSize { get; set; }

        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

    }

}
