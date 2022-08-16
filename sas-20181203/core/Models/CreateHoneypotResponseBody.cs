// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateHoneypotResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public CreateHoneypotResponseBodyData Data { get; set; }
        public class CreateHoneypotResponseBodyData : TeaModel {
            [NameInMap("ControlNodeName")]
            [Validation(Required=false)]
            public string ControlNodeName { get; set; }
            [NameInMap("HoneypotId")]
            [Validation(Required=false)]
            public string HoneypotId { get; set; }
            [NameInMap("HoneypotImageDisplayName")]
            [Validation(Required=false)]
            public string HoneypotImageDisplayName { get; set; }
            [NameInMap("HoneypotImageName")]
            [Validation(Required=false)]
            public string HoneypotImageName { get; set; }
            [NameInMap("HoneypotName")]
            [Validation(Required=false)]
            public string HoneypotName { get; set; }
            [NameInMap("NodeId")]
            [Validation(Required=false)]
            public string NodeId { get; set; }
            [NameInMap("PresetId")]
            [Validation(Required=false)]
            public string PresetId { get; set; }
            [NameInMap("State")]
            [Validation(Required=false)]
            public List<string> State { get; set; }
        };

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
