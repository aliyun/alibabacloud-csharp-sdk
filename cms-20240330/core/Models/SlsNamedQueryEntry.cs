// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class SlsNamedQueryEntry : TeaModel {
        [NameInMap("end")]
        [Validation(Required=false)]
        public long? End { get; set; }

        [NameInMap("expr")]
        [Validation(Required=false)]
        public string Expr { get; set; }

        [NameInMap("start")]
        [Validation(Required=false)]
        public long? Start { get; set; }

        [NameInMap("timeUnit")]
        [Validation(Required=false)]
        public string TimeUnit { get; set; }

        [NameInMap("window")]
        [Validation(Required=false)]
        public long? Window { get; set; }

    }

}
