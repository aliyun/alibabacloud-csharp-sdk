// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetLinkeBahamutConfiglinkchostResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NotSuccess")]
        [Validation(Required=false)]
        public bool? NotSuccess { get; set; }

        [NameInMap("NotValid")]
        [Validation(Required=false)]
        public bool? NotValid { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Total")]
        [Validation(Required=false)]
        public long? Total { get; set; }

        [NameInMap("Valid")]
        [Validation(Required=false)]
        public bool? Valid { get; set; }

        [NameInMap("ErrorMessages")]
        [Validation(Required=false)]
        public List<string> ErrorMessages { get; set; }

        [NameInMap("Pager")]
        [Validation(Required=false)]
        public GetLinkeBahamutConfiglinkchostResponseBodyPager Pager { get; set; }
        public class GetLinkeBahamutConfiglinkchostResponseBodyPager : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public long? Begin { get; set; }
            [NameInMap("Length")]
            [Validation(Required=false)]
            public long? Length { get; set; }
            [NameInMap("NotValid")]
            [Validation(Required=false)]
            public bool? NotValid { get; set; }
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }
            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public long? PageCount { get; set; }
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }
            [NameInMap("Valid")]
            [Validation(Required=false)]
            public bool? Valid { get; set; }
        };

    }

}
