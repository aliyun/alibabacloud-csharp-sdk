// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeBahamutReleasestatusResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ErrorMsgParamsMap")]
        [Validation(Required=false)]
        public string ErrorMsgParamsMap { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public CheckLinkeBahamutReleasestatusResponseBodyResult Result { get; set; }
        public class CheckLinkeBahamutReleasestatusResponseBodyResult : TeaModel {
            [NameInMap("ReleaseApplied")]
            [Validation(Required=false)]
            public bool? ReleaseApplied { get; set; }
            [NameInMap("Ready")]
            [Validation(Required=false)]
            public bool? Ready { get; set; }
            [NameInMap("UnitsNotYetReady")]
            [Validation(Required=false)]
            public List<string> UnitsNotYetReady { get; set; }
            [NameInMap("AppsNotApplied")]
            [Validation(Required=false)]
            public List<string> AppsNotApplied { get; set; }
        };

    }

}
