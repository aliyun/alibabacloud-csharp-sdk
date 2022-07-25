// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetCheckDetailResponseBody : TeaModel {
        [NameInMap("AssistInfo")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyAssistInfo AssistInfo { get; set; }
        public class GetCheckDetailResponseBodyAssistInfo : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

        [NameInMap("Description")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodyDescription Description { get; set; }
        public class GetCheckDetailResponseBodyDescription : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Solution")]
        [Validation(Required=false)]
        public GetCheckDetailResponseBodySolution Solution { get; set; }
        public class GetCheckDetailResponseBodySolution : TeaModel {
            [NameInMap("Link")]
            [Validation(Required=false)]
            public string Link { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }
        };

    }

}
