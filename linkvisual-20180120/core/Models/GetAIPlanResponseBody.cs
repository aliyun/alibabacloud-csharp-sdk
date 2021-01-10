// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class GetAIPlanResponseBody : TeaModel {
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
        public GetAIPlanResponseBodyData Data { get; set; }
        public class GetAIPlanResponseBodyData : TeaModel {
            [NameInMap("PlanId")]
            [Validation(Required=false)]
            public string PlanId { get; set; }
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }
            [NameInMap("PlanTemplateId")]
            [Validation(Required=false)]
            public string PlanTemplateId { get; set; }
            [NameInMap("TriggerEnum")]
            [Validation(Required=false)]
            public int? TriggerEnum { get; set; }
            [NameInMap("IntervalTiming")]
            [Validation(Required=false)]
            public int? IntervalTiming { get; set; }
            [NameInMap("PreTiming")]
            [Validation(Required=false)]
            public long? PreTiming { get; set; }
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }
        };

    }

}
