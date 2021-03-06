// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class CheckLinkeBahamutFabricconfigResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

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
        public CheckLinkeBahamutFabricconfigResponseBodyResult Result { get; set; }
        public class CheckLinkeBahamutFabricconfigResponseBodyResult : TeaModel {
            [NameInMap("Pass")]
            [Validation(Required=false)]
            public bool? Pass { get; set; }
            [NameInMap("ForceStop")]
            [Validation(Required=false)]
            public bool? ForceStop { get; set; }
            [NameInMap("CheckList")]
            [Validation(Required=false)]
            public List<CheckLinkeBahamutFabricconfigResponseBodyResultCheckList> CheckList { get; set; }
            public class CheckLinkeBahamutFabricconfigResponseBodyResultCheckList : TeaModel {
                public bool? Pass { get; set; }
                public bool? ForceStop { get; set; }
                public string ConfigType { get; set; }
                public string DetailMessage { get; set; }
                public string CheckItem { get; set; }
            }
            [NameInMap("DetailMessage")]
            [Validation(Required=false)]
            public string DetailMessage { get; set; }
        };

    }

}
