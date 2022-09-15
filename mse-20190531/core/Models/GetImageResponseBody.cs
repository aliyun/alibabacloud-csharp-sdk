// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class GetImageResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetImageResponseBodyData Data { get; set; }
        public class GetImageResponseBodyData : TeaModel {
            [NameInMap("CurrentVersionFullShowName")]
            [Validation(Required=false)]
            public string CurrentVersionFullShowName { get; set; }

            [NameInMap("MaxVersionChangelogUrl")]
            [Validation(Required=false)]
            public string MaxVersionChangelogUrl { get; set; }

            [NameInMap("MaxVersionCode")]
            [Validation(Required=false)]
            public string MaxVersionCode { get; set; }

            [NameInMap("MaxVersionFullShowName")]
            [Validation(Required=false)]
            public string MaxVersionFullShowName { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
