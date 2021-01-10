// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetAIActionResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetAIActionResponseBodyData Data { get; set; }
        public class GetAIActionResponseBodyData : TeaModel {
            [NameInMap("ActionId")]
            [Validation(Required=false)]
            public string ActionId { get; set; }
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }
            [NameInMap("Action")]
            [Validation(Required=false)]
            public string Action { get; set; }
            [NameInMap("ActionTemplateId")]
            [Validation(Required=false)]
            public string ActionTemplateId { get; set; }
            [NameInMap("ActionIndex")]
            [Validation(Required=false)]
            public int? ActionIndex { get; set; }
            [NameInMap("Alog")]
            [Validation(Required=false)]
            public string Alog { get; set; }
            [NameInMap("AlgoConfig")]
            [Validation(Required=false)]
            public string AlgoConfig { get; set; }
            [NameInMap("ActionConfig")]
            [Validation(Required=false)]
            public string ActionConfig { get; set; }
        };

    }

}
