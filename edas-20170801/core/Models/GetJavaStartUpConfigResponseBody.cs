// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetJavaStartUpConfigResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("JavaStartUpConfig")]
        [Validation(Required=false)]
        public GetJavaStartUpConfigResponseBodyJavaStartUpConfig JavaStartUpConfig { get; set; }
        public class GetJavaStartUpConfigResponseBodyJavaStartUpConfig : TeaModel {
            [NameInMap("OriginalConfigs")]
            [Validation(Required=false)]
            public string OriginalConfigs { get; set; }
            [NameInMap("StartUpArgs")]
            [Validation(Required=false)]
            public string StartUpArgs { get; set; }
        };

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
