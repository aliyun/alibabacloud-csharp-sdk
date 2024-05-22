// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitSyncMediaInfoJobRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitSyncMediaInfoJobRequestInput Input { get; set; }
        public class SubmitSyncMediaInfoJobRequestInput : TeaModel {
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

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ScheduleConfig")]
        [Validation(Required=false)]
        public SubmitSyncMediaInfoJobRequestScheduleConfig ScheduleConfig { get; set; }
        public class SubmitSyncMediaInfoJobRequestScheduleConfig : TeaModel {
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
