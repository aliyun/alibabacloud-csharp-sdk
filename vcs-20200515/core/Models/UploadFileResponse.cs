// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vcs20200515.Models
{
    public class UploadFileResponse : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("Message")]
        [Validation(Required=true)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public UploadFileResponseData Data { get; set; }
        public class UploadFileResponseData : TeaModel {
            [NameInMap("Records")]
            [Validation(Required=true)]
            public List<UploadFileResponseDataRecords> Records { get; set; }
            public class UploadFileResponseDataRecords : TeaModel {
                public string OssPath { get; set; }
                public string SourceId { get; set; }
            }
        };

    }

}
