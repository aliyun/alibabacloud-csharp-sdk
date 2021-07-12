// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class GotoPresetRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        [NameInMap("PresetId")]
        [Validation(Required=false)]
        public string PresetId { get; set; }

        [NameInMap("SubProtocol")]
        [Validation(Required=false)]
        public string SubProtocol { get; set; }

    }

}
