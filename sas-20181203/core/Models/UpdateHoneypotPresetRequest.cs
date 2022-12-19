// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class UpdateHoneypotPresetRequest : TeaModel {
        [NameInMap("HoneypotImageName")]
        [Validation(Required=false)]
        public string HoneypotImageName { get; set; }

        [NameInMap("HoneypotPresetId")]
        [Validation(Required=false)]
        public string HoneypotPresetId { get; set; }

        [NameInMap("Meta")]
        [Validation(Required=false)]
        public string Meta { get; set; }

        [NameInMap("PresetName")]
        [Validation(Required=false)]
        public string PresetName { get; set; }

    }

}
