// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SubtaskDetail : TeaModel {
        [NameInMap("CanDiscard")]
        [Validation(Required=false)]
        public bool? CanDiscard { get; set; }

        [NameInMap("CanReassign")]
        [Validation(Required=false)]
        public bool? CanReassign { get; set; }

        [NameInMap("CanRelease")]
        [Validation(Required=false)]
        public bool? CanRelease { get; set; }

        [NameInMap("CurrentWorkNode")]
        [Validation(Required=false)]
        public string CurrentWorkNode { get; set; }

        [NameInMap("ExtConfigs")]
        [Validation(Required=false)]
        public string ExtConfigs { get; set; }

        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<SubtaskDetailItems> Items { get; set; }
        public class SubtaskDetailItems : TeaModel {
            [NameInMap("AbandonFlag")]
            [Validation(Required=false)]
            public bool? AbandonFlag { get; set; }

            [NameInMap("AbandonRemark")]
            [Validation(Required=false)]
            public string AbandonRemark { get; set; }

            [NameInMap("DataId")]
            [Validation(Required=false)]
            public string DataId { get; set; }

            [NameInMap("FeedbackFlag")]
            [Validation(Required=false)]
            public bool? FeedbackFlag { get; set; }

            [NameInMap("FeedbackRemark")]
            [Validation(Required=false)]
            public string FeedbackRemark { get; set; }

            [NameInMap("FixedFlag")]
            [Validation(Required=false)]
            public bool? FixedFlag { get; set; }

            [NameInMap("Mine")]
            [Validation(Required=false)]
            public long? Mine { get; set; }

            [NameInMap("RejectFlag")]
            [Validation(Required=false)]
            public bool? RejectFlag { get; set; }

            [NameInMap("State")]
            [Validation(Required=false)]
            public string State { get; set; }

            [NameInMap("Weight")]
            [Validation(Required=false)]
            public long? Weight { get; set; }

        }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("SubtaskId")]
        [Validation(Required=false)]
        public string SubtaskId { get; set; }

        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        [NameInMap("Weight")]
        [Validation(Required=false)]
        public long? Weight { get; set; }

        [NameInMap("WorkNodeState")]
        [Validation(Required=false)]
        public string WorkNodeState { get; set; }

        [NameInMap("Workforce")]
        [Validation(Required=false)]
        public List<Workforce> Workforce { get; set; }

    }

}
