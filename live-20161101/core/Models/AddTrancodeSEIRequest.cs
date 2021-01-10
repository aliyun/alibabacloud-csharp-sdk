// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddTrancodeSEIRequest : TeaModel {
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=false)]
        public string StreamName { get; set; }

        [NameInMap("Text")]
        [Validation(Required=false)]
        public string Text { get; set; }

        [NameInMap("Pattern")]
        [Validation(Required=false)]
        public string Pattern { get; set; }

        [NameInMap("Repeat")]
        [Validation(Required=false)]
        public int? Repeat { get; set; }

        [NameInMap("Delay")]
        [Validation(Required=false)]
        public int? Delay { get; set; }

    }

}
