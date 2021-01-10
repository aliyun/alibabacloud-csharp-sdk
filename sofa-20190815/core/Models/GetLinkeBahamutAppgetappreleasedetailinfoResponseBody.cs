// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutAppgetappreleasedetailinfoResponseBody : TeaModel {
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
        public GetLinkeBahamutAppgetappreleasedetailinfoResponseBodyResult Result { get; set; }
        public class GetLinkeBahamutAppgetappreleasedetailinfoResponseBodyResult : TeaModel {
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }
            [NameInMap("Created")]
            [Validation(Required=false)]
            public long? Created { get; set; }
            [NameInMap("Deleted")]
            [Validation(Required=false)]
            public bool? Deleted { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }
            [NameInMap("LastModified")]
            [Validation(Required=false)]
            public long? LastModified { get; set; }
            [NameInMap("NeedMerge")]
            [Validation(Required=false)]
            public bool? NeedMerge { get; set; }
            [NameInMap("ReleaseExternalId")]
            [Validation(Required=false)]
            public string ReleaseExternalId { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }
            [NameInMap("ActiveStages")]
            [Validation(Required=false)]
            public List<string> ActiveStages { get; set; }
            [NameInMap("Stages")]
            [Validation(Required=false)]
            public List<string> Stages { get; set; }
        };

    }

}
