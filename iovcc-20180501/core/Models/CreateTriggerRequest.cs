// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iovcc20180501.Models
{
    public class CreateTriggerRequest : TeaModel {
        [NameInMap("ProjectId")]
        [Validation(Required=false)]
        public string ProjectId { get; set; }

        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        [NameInMap("FunctionIds")]
        [Validation(Required=false)]
        public string FunctionIds { get; set; }

        [NameInMap("InvocationMode")]
        [Validation(Required=false)]
        public int? InvocationMode { get; set; }

        [NameInMap("Sandbox")]
        [Validation(Required=false)]
        public int? Sandbox { get; set; }

        [NameInMap("Production")]
        [Validation(Required=false)]
        public int? Production { get; set; }

    }

}
