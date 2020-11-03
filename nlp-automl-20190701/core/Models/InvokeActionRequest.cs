// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Nlp_automl20190701.Models
{
    public class InvokeActionRequest : TeaModel {
        [NameInMap("InvokeProduct")]
        [Validation(Required=false)]
        public string InvokeProduct { get; set; }

        [NameInMap("InvokeRegion")]
        [Validation(Required=false)]
        public string InvokeRegion { get; set; }

        [NameInMap("InvokeAction")]
        [Validation(Required=true)]
        public string InvokeAction { get; set; }

        [NameInMap("InvokeParams")]
        [Validation(Required=true)]
        public string InvokeParams { get; set; }

    }

}
