// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Apds20220331.Models
{
    public class UpdatePushAppResponseBody : TeaModel {
        [NameInMap("IsDebugEnable")]
        [Validation(Required=false)]
        public bool? IsDebugEnable { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultObj")]
        [Validation(Required=false)]
        public object ResultObj { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TipMsg")]
        [Validation(Required=false)]
        public string TipMsg { get; set; }

    }

}
