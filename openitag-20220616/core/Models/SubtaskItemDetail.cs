// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenITag20220616.Models
{
    public class SubtaskItemDetail : TeaModel {
        [NameInMap("Annotations")]
        [Validation(Required=false)]
        public List<SubtaskItemDetailAnnotations> Annotations { get; set; }
        public class SubtaskItemDetailAnnotations : TeaModel {
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

        [NameInMap("DataSource")]
        [Validation(Required=false)]
        public Dictionary<string, object> DataSource { get; set; }

        [NameInMap("ItemId")]
        [Validation(Required=false)]
        public long? ItemId { get; set; }

    }

}
