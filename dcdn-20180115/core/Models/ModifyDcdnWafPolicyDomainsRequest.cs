// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class ModifyDcdnWafPolicyDomainsRequest : TeaModel {
        [NameInMap("BindDomains")]
        [Validation(Required=false)]
        public string BindDomains { get; set; }

        [NameInMap("Method")]
        [Validation(Required=false)]
        public int? Method { get; set; }

        [NameInMap("PolicyId")]
        [Validation(Required=false)]
        public long? PolicyId { get; set; }

        [NameInMap("UnbindDomains")]
        [Validation(Required=false)]
        public string UnbindDomains { get; set; }

    }

}
