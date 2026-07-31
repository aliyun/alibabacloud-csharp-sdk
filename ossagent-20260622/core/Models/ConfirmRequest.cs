// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OssAgent20260622.Models
{
    public class ConfirmRequest : TeaModel {
        [NameInMap("confirmed")]
        [Validation(Required=false)]
        public bool? Confirmed { get; set; }

        [NameInMap("phase")]
        [Validation(Required=false)]
        public string Phase { get; set; }

        [NameInMap("reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("sessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        [NameInMap("toolCalls")]
        [Validation(Required=false)]
        public List<ConfirmRequestToolCalls> ToolCalls { get; set; }
        public class ConfirmRequestToolCalls : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("modifiedInput")]
            [Validation(Required=false)]
            public Dictionary<string, object> ModifiedInput { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

    }

}
