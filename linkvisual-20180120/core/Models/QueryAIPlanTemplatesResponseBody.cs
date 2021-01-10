// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkvisual20180120.Models
{
    public class QueryAIPlanTemplatesResponseBody : TeaModel {
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
        public List<QueryAIPlanTemplatesResponseBodyData> Data { get; set; }
        public class QueryAIPlanTemplatesResponseBodyData : TeaModel {
            [NameInMap("PlanTemplateId")]
            [Validation(Required=false)]
            public string PlanTemplateId { get; set; }

            [NameInMap("AppTemplateId")]
            [Validation(Required=false)]
            public string AppTemplateId { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("TriggerEnum")]
            [Validation(Required=false)]
            public int? TriggerEnum { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IntervalTiming")]
            [Validation(Required=false)]
            public int? IntervalTiming { get; set; }

        }

    }

}
