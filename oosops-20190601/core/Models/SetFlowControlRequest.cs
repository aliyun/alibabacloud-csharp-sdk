// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oosops20190601.Models
{
    public class SetFlowControlRequest : TeaModel {
        [NameInMap("Api")]
        [Validation(Required=false)]
        public string Api { get; set; }

        [NameInMap("Service")]
        [Validation(Required=false)]
        public string Service { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

        [NameInMap("Value")]
        [Validation(Required=false)]
        public int? Value { get; set; }

    }

}
