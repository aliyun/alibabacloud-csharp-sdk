// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitIProductionJobRequest : TeaModel {
        [NameInMap("FunctionName")]
        [Validation(Required=false)]
        public string FunctionName { get; set; }

        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitIProductionJobRequestInput Input { get; set; }
        public class SubmitIProductionJobRequestInput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("JobParams")]
        [Validation(Required=false)]
        public string JobParams { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitIProductionJobRequestOutput Output { get; set; }
        public class SubmitIProductionJobRequestOutput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }
        };

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitIProductionJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitIProductionJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }
            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }
        };

        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
