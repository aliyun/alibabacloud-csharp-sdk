// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeLinktUploadinfoResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public long? ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetLinkeLinktUploadinfoResponseBodyData Data { get; set; }
        public class GetLinkeLinktUploadinfoResponseBodyData : TeaModel {
            [NameInMap("DownloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }
            [NameInMap("SignedUploadUrl")]
            [Validation(Required=false)]
            public string SignedUploadUrl { get; set; }
            [NameInMap("StoredFilename")]
            [Validation(Required=false)]
            public string StoredFilename { get; set; }
        };

    }

}
