// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotPresetRequest : TeaModel {
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        [NameInMap("PresetName")]
        [Validation(Required=false)]
        public string PresetName { get; set; }

    }

}
