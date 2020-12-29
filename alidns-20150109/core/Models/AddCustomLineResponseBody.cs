// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class AddCustomLineResponseBody : TeaModel {
        [NameInMap("LineId")]
        [Validation(Required=false)]
        public long? LineId { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("LineCode")]
        [Validation(Required=false)]
        public string LineCode { get; set; }

    }

}
