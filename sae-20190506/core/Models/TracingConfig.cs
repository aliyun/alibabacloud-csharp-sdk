// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sae20190506.Models
{
    public class TracingConfig : TeaModel {
        [NameInMap("jaegerConfig")]
        [Validation(Required=false)]
        public JaegerConfig JaegerConfig { get; set; }

        [NameInMap("params")]
        [Validation(Required=false)]
        public object Params { get; set; }

        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
