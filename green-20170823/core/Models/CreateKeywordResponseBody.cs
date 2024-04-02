// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20170823.Models
{
    public class CreateKeywordResponseBody : TeaModel {
        [NameInMap("InvalidKeywordList")]
        [Validation(Required=false)]
        public List<string> InvalidKeywordList { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessCount")]
        [Validation(Required=false)]
        public int? SuccessCount { get; set; }

        [NameInMap("validKeywordList")]
        [Validation(Required=false)]
        public List<CreateKeywordResponseBodyValidKeywordList> ValidKeywordList { get; set; }
        public class CreateKeywordResponseBodyValidKeywordList : TeaModel {
            [NameInMap("id")]
            [Validation(Required=false)]
            public int? Id { get; set; }

            [NameInMap("keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

        }

    }

}
