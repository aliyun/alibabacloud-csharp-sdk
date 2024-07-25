// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitPackageJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Inputs")]
        [Validation(Required=false)]
        public List<SubmitPackageJobRequestInputs> Inputs { get; set; }
        public class SubmitPackageJobRequestInputs : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Input")]
            [Validation(Required=false)]
            public SubmitPackageJobRequestInputsInput Input { get; set; }
            public class SubmitPackageJobRequestInputsInput : TeaModel {
                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Media")]
                [Validation(Required=false)]
                public string Media { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Output")]
        [Validation(Required=false)]
        public SubmitPackageJobRequestOutput Output { get; set; }
        public class SubmitPackageJobRequestOutput : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
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
