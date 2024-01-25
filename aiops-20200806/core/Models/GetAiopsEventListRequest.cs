// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiops20200806.Models
{
    public class GetAiopsEventListRequest : TeaModel {
        [NameInMap("BusinessGroupId")]
        [Validation(Required=false)]
        public string BusinessGroupId { get; set; }

        [NameInMap("BusinessGroupName")]
        [Validation(Required=false)]
        public string BusinessGroupName { get; set; }

        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        [NameInMap("EventType")]
        [Validation(Required=false)]
        public int? EventType { get; set; }

        [NameInMap("EventUniqueId")]
        [Validation(Required=false)]
        public string EventUniqueId { get; set; }

        [NameInMap("FeedbackStatus")]
        [Validation(Required=false)]
        public int? FeedbackStatus { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OperaUid")]
        [Validation(Required=false)]
        public string OperaUid { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("PredictionState")]
        [Validation(Required=false)]
        public int? PredictionState { get; set; }

        [NameInMap("Severity")]
        [Validation(Required=false)]
        public int? Severity { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("Uid")]
        [Validation(Required=false)]
        public long? Uid { get; set; }

    }

}
