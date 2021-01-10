// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutStagequalityResponseBody : TeaModel {
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

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public GetLinkeBahamutStagequalityResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutStagequalityResponseBodyResult : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Branch")]
            [Validation(Required=false)]
            public string Branch { get; set; }
            [NameInMap("CodeName")]
            [Validation(Required=false)]
            public string CodeName { get; set; }
            [NameInMap("Pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }
            [NameInMap("Items")]
            [Validation(Required=false)]
            public List<GetLinkeBahamutStagequalityResponseBodyResultItems> Items { get; set; }
            public class GetLinkeBahamutStagequalityResponseBodyResultItems : TeaModel {
                public string Key { get; set; }
                public string Link { get; set; }
                public bool? MeetTheRule { get; set; }
                public string Message { get; set; }
                public string Rule { get; set; }
                public string Value { get; set; }
            }
        };

    }

}
