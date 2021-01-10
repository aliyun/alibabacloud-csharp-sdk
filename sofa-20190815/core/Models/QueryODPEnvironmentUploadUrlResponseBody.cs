// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class QueryODPEnvironmentUploadUrlResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryODPEnvironmentUploadUrlResponseBodyData Data { get; set; }
        public class QueryODPEnvironmentUploadUrlResponseBodyData : TeaModel {
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("OssUrl")]
            [Validation(Required=false)]
            public string OssUrl { get; set; }
        };

    }

}
