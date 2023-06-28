// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class PutAsyncInvokeConfigRequest : TeaModel {
        [NameInMap("qualifier")]
        [Validation(Required=false)]
        public string Qualifier { get; set; }

        [NameInMap("request")]
        [Validation(Required=false)]
        public PutAsyncInvokeConfigInput Request { get; set; }

    }

}
