// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class ListCampaignsRequest : TeaModel {
        [NameInMap("ActualStartTimeFrom")]
        [Validation(Required=false)]
        public string ActualStartTimeFrom { get; set; }

        [NameInMap("ActualStartTimeTo")]
        [Validation(Required=false)]
        public string ActualStartTimeTo { get; set; }

        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        [NameInMap("PlanedStartTimeFrom")]
        [Validation(Required=false)]
        public string PlanedStartTimeFrom { get; set; }

        [NameInMap("PlanedStartTimeTo")]
        [Validation(Required=false)]
        public string PlanedStartTimeTo { get; set; }

        [NameInMap("QueueId")]
        [Validation(Required=false)]
        public string QueueId { get; set; }

        [NameInMap("State")]
        [Validation(Required=false)]
        public string State { get; set; }

    }

}
