// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cdn20180510.Models
{
    public class SetRefererConfigRequest : TeaModel {
        [NameInMap("AllowEmpty")]
        [Validation(Required=false)]
        public string AllowEmpty { get; set; }

        [NameInMap("DisableAst")]
        [Validation(Required=false)]
        public string DisableAst { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ReferList")]
        [Validation(Required=false)]
        public string ReferList { get; set; }

        [NameInMap("ReferType")]
        [Validation(Required=false)]
        public string ReferType { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
