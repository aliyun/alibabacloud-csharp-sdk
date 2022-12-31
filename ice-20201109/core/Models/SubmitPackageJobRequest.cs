// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitPackageJobRequest : TeaModel {
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<SubmitPackageJobRequestInputs> Inputs { get; set; }
        public class SubmitPackageJobRequestInputs : TeaModel {
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitPackageJobRequestInputsInput Input { get; set; }
            public class SubmitPackageJobRequestInputsInput : TeaModel {
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestOutput Output { get; set; }
        public class SubmitPackageJobRequestOutput : TeaModel {
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitPackageJobRequestScheduleConfig : TeaModel {
            [NameInMap("PipelineId")]
            [Validation(Required=false)]
            public string PipelineId { get; set; }

            [NameInMap("Priority")]
            [Validation(Required=false)]
            public int? Priority { get; set; }

        }

        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
