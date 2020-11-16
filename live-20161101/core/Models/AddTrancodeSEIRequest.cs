// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddTrancodeSEIRequest : TeaModel {
        [NameInMap("DomainName")]
        [Validation(Required=true)]
        public string DomainName { get; set; }

        [NameInMap("AppName")]
        [Validation(Required=true)]
        public string AppName { get; set; }

        [NameInMap("StreamName")]
        [Validation(Required=true)]
        public string StreamName { get; set; }

        [NameInMap("Text")]
        [Validation(Required=true)]
        public string Text { get; set; }

        [NameInMap("Pattern")]
        [Validation(Required=true)]
        public string Pattern { get; set; }

        [NameInMap("Repeat")]
        [Validation(Required=true)]
        public int? Repeat { get; set; }

        [NameInMap("Delay")]
        [Validation(Required=true)]
        public int? Delay { get; set; }

    }

}
