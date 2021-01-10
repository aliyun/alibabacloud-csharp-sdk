// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class AddLinkeLinklogIndicationResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResponseStatusCode")]
        [Validation(Required=false)]
        public long? ResponseStatusCode { get; set; }

        [NameInMap("ResponseContentRange")]
        [Validation(Required=false)]
        public string ResponseContentRange { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("ResponseContentType")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

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
        public AddLinkeLinklogIndicationResponseBodyResult Result { get; set; }
        public class AddLinkeLinklogIndicationResponseBodyResult : TeaModel {
            [NameInMap("KnowledgeId")]
            [Validation(Required=false)]
            public long? KnowledgeId { get; set; }
            [NameInMap("Conditions")]
            [Validation(Required=false)]
            public List<string> Conditions { get; set; }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
        };

    }

}
