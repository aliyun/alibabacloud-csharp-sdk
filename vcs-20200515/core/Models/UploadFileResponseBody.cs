// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UploadFileResponseBody : TeaModel {
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UploadFileResponseBodyData Data { get; set; }
        public class UploadFileResponseBodyData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=false)]
            public List<UploadFileResponseBodyDataRecords> Records { get; set; }
            public class UploadFileResponseBodyDataRecords : TeaModel {
                public string OssPath { get; set; }
                public string SourceId { get; set; }
            }
        };

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

    }

}
