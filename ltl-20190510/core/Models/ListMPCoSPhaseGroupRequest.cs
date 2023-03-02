// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ltl20190510.Models
{
    public class ListMPCoSPhaseGroupRequest : TeaModel {
        [NameInMap("ApiVersion")]
        [Validation(Required=false)]
        public string ApiVersion { get; set; }

        [NameInMap("BizChainId")]
        [Validation(Required=false)]
        public string BizChainId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Num")]
        [Validation(Required=false)]
        public int? Num { get; set; }

        [NameInMap("Size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
