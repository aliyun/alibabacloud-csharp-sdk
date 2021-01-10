// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class StartLinkelinkflowLinkflowProcessRequest : TeaModel {
        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("DefinitionKey")]
        [Validation(Required=false)]
        public string DefinitionKey { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Outcome")]
        [Validation(Required=false)]
        public string Outcome { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        [NameInMap("StartUserId")]
        [Validation(Required=false)]
        public string StartUserId { get; set; }

        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
