// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetFileTokenForUploadToMsaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public GetFileTokenForUploadToMsaResponseBodyResultContent ResultContent { get; set; }
        public class GetFileTokenForUploadToMsaResponseBodyResultContent : TeaModel {
            [NameInMap("Content")]
            [Validation(Required=false)]
            public GetFileTokenForUploadToMsaResponseBodyResultContentContent Content { get; set; }
            public class GetFileTokenForUploadToMsaResponseBodyResultContentContent : TeaModel {
                [NameInMap("Accessid")]
                [Validation(Required=false)]
                public string Accessid { get; set; }

                [NameInMap("Dir")]
                [Validation(Required=false)]
                public string Dir { get; set; }

                [NameInMap("Expire")]
                [Validation(Required=false)]
                public string Expire { get; set; }

                [NameInMap("Host")]
                [Validation(Required=false)]
                public string Host { get; set; }

                [NameInMap("Policy")]
                [Validation(Required=false)]
                public string Policy { get; set; }

                [NameInMap("Signature")]
                [Validation(Required=false)]
                public string Signature { get; set; }

            }

            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            [NameInMap("RequestId")]
            [Validation(Required=false)]
            public string RequestId { get; set; }

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public string Success { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
