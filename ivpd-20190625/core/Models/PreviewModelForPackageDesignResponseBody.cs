// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ivpd20190625.Models
{
    public class PreviewModelForPackageDesignResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreviewModelForPackageDesignResponseBodyData Data { get; set; }
        public class PreviewModelForPackageDesignResponseBodyData : TeaModel {
            [NameInMap("PreviewUrl")]
            [Validation(Required=false)]
            public string PreviewUrl { get; set; }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
