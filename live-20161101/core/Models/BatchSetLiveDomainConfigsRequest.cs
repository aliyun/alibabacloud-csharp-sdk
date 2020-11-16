// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class BatchSetLiveDomainConfigsRequest : TeaModel {
        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

        [NameInMap("DomainNames")]
        [Validation(Required=true)]
        public string DomainNames { get; set; }

        [NameInMap("Functions")]
        [Validation(Required=true)]
        public string Functions { get; set; }

    }

}
