// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imp20210630.Models
{
    public class CreateLiveResponseBody : TeaModel {
        /// <summary>
        /// 请求ID。
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CreateLiveResponseBodyResult Result { get; set; }
        public class CreateLiveResponseBodyResult : TeaModel {
            [NameInMap("LiveId")]
            [Validation(Required=false)]
            public string LiveId { get; set; }
        };

    }

}
