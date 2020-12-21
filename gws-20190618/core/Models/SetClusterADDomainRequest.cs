// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gws20190618.Models
{
    public class SetClusterADDomainRequest : TeaModel {
        [NameInMap("ClusterId")]
        [Validation(Required=true)]
        public string ClusterId { get; set; }

        [NameInMap("DomainDnsIp")]
        [Validation(Required=true)]
        public string DomainDnsIp { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("DomainPassword")]
        [Validation(Required=true)]
        public string DomainPassword { get; set; }

        [NameInMap("DomainAdmin")]
        [Validation(Required=false)]
        public string DomainAdmin { get; set; }

        [NameInMap("DomainDelete")]
        [Validation(Required=false)]
        public bool? DomainDelete { get; set; }

    }

}
