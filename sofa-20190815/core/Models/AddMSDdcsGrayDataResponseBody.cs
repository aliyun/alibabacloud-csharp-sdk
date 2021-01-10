// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddMSDdcsGrayDataResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("PushResult")]
        [Validation(Required=false)]
        public List<AddMSDdcsGrayDataResponseBodyPushResult> PushResult { get; set; }
        public class AddMSDdcsGrayDataResponseBodyPushResult : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public string Host { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

    }

}
