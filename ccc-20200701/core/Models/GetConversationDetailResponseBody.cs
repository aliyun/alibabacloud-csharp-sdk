// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetConversationDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Phrases")]
        [Validation(Required=false)]
        public List<GetConversationDetailResponseBodyPhrases> Phrases { get; set; }
        public class GetConversationDetailResponseBodyPhrases : TeaModel {
            [NameInMap("Begin")]
            [Validation(Required=false)]
            public int? Begin { get; set; }

            [NameInMap("End")]
            [Validation(Required=false)]
            public int? End { get; set; }

            [NameInMap("Identity")]
            [Validation(Required=false)]
            public string Identity { get; set; }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

            [NameInMap("Words")]
            [Validation(Required=false)]
            public string Words { get; set; }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
