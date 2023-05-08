// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotPresetResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HoneypotPreset")]
        [Validation(Required=false)]
        public CreateHoneypotPresetResponseBodyHoneypotPreset HoneypotPreset { get; set; }
        public class CreateHoneypotPresetResponseBodyHoneypotPreset : TeaModel {
            [NameInMap("HoneypotPresetId")]
            [Validation(Required=false)]
            public string HoneypotPresetId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
