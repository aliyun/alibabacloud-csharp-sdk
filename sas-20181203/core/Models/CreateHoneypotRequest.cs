// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotRequest : TeaModel {
        [NameInMap("HoneypotImageId")]
        [Validation(Required=false)]
        public string HoneypotImageId { get; set; }

        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        [NameInMap("HoneypotName")]
        [Validation(Required=false)]
        public string HoneypotName { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

    }

}
