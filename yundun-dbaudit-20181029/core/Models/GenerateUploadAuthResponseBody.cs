// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yundun_dbaudit20181029.Models
{
    public class GenerateUploadAuthResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("UploadConfig")]
        [Validation(Required=false)]
        public GenerateUploadAuthResponseBodyUploadConfig UploadConfig { get; set; }
        public class GenerateUploadAuthResponseBodyUploadConfig : TeaModel {
            [NameInMap("Signature")]
            [Validation(Required=false)]
            public string Signature { get; set; }
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }
            [NameInMap("Policy")]
            [Validation(Required=false)]
            public string Policy { get; set; }
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public long? ExpireTime { get; set; }
            [NameInMap("UploadHost")]
            [Validation(Required=false)]
            public string UploadHost { get; set; }
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }
        };

    }

}
