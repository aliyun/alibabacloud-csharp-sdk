// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MPaaS20201028.Models
{
    public class GetUserAppDonwloadUrlInMsaResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultContent")]
        [Validation(Required=false)]
        public GetUserAppDonwloadUrlInMsaResponseBodyResultContent ResultContent { get; set; }
        public class GetUserAppDonwloadUrlInMsaResponseBodyResultContent : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public GetUserAppDonwloadUrlInMsaResponseBodyResultContentData Data { get; set; }
            public class GetUserAppDonwloadUrlInMsaResponseBodyResultContentData : TeaModel {
                [NameInMap("Filename")]
                [Validation(Required=false)]
                public string Filename { get; set; }

                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

    }

}
