// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20200710.Models
{
    public class GetMcubeFileTokenResponseBody : TeaModel {
        [NameInMap("GetFileTokenResult")]
        [Validation(Required=false)]
        public GetMcubeFileTokenResponseBodyGetFileTokenResult GetFileTokenResult { get; set; }
        public class GetMcubeFileTokenResponseBodyGetFileTokenResult : TeaModel {
            [NameInMap("FileToken")]
            [Validation(Required=false)]
            public GetMcubeFileTokenResponseBodyGetFileTokenResultFileToken FileToken { get; set; }
            public class GetMcubeFileTokenResponseBodyGetFileTokenResultFileToken : TeaModel {
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

            [NameInMap("ResultMsg")]
            [Validation(Required=false)]
            public string ResultMsg { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
