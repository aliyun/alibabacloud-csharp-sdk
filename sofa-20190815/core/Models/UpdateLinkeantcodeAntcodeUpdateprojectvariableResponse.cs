// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class UpdateLinkeantcodeAntcodeUpdateprojectvariableResponse : TeaModel {
        [NameInMap("headers")]
        [Validation(Required=true)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("body")]
        [Validation(Required=true)]
        public UpdateLinkeantcodeAntcodeUpdateprojectvariableResponseBody Body { get; set; }

    }

}
