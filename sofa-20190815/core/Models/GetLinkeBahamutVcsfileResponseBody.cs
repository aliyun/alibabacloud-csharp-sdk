// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutVcsfileResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLinkeBahamutVcsfileResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutVcsfileResponseBodyResult : TeaModel {
            [NameInMap("BlobId")]
            [Validation(Required=false)]
            public string BlobId { get; set; }
            [NameInMap("CommitId")]
            [Validation(Required=false)]
            public string CommitId { get; set; }
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }
            [NameInMap("Encoding")]
            [Validation(Required=false)]
            public string Encoding { get; set; }
            [NameInMap("FileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }
            [NameInMap("LastCommitId")]
            [Validation(Required=false)]
            public string LastCommitId { get; set; }
            [NameInMap("Ref")]
            [Validation(Required=false)]
            public string Ref { get; set; }
            [NameInMap("Size")]
            [Validation(Required=false)]
            public string Size { get; set; }
        };

    }

}
